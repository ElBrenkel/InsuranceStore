using InsuranceStore.BL;
using InsuranceStore.DataObjects;
using InsuranceStore.DataObjects.Enums;

namespace InsuranceStore
{
    public partial class MainForm : Form
    {
        private InsuranceTypeEnum insuranceType;
        private Insurance insurance;
        public MainForm()
        {
            InitializeComponent();
            finalPanel.Visible = false;
            personalDetailsPanel.Visible = false;
            locationPanel.Visible = false;
            StreetLabel.Visible = false;
            streetComboBox.Visible = false;
        }

        private void InsuranceTypeNextButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<InsuranceTypeEnum>(InsuranceTypeComboBox.Text, true, out insuranceType))
            {
                if (insuranceType == InsuranceTypeEnum.Life)
                {
                    lifeInsurancePanel.Visible = true;
                    occupationComboBox.DisplayMember = "Job";
                    occupationComboBox.ValueMember = "Risk";
                    occupationComboBox.DataSource = new[] {
                        new { Job = "Firefighter", Risk = 35 },
                        new { Job = "Police officer", Risk = 30 },
                        new { Job = "Construction worker", Risk = 25 },
                        new { Job = "Military personnel", Risk = 50 },
                        new { Job = "Miner", Risk = 45 },
                        new { Job = "Aircraft pilot", Risk = 15 },
                        new { Job = "Teacher", Risk = 0 },
                        new { Job = "Student", Risk = 5 },
                        new { Job = "Reporter", Risk = 20 }
                    };
                }
                else
                {
                    lifeInsurancePanel.Visible = false;
                }
                InsuranceTypePanel.Visible = false;
                personalDetailsPanel.Visible = true;
            }
            else
                MessageBox.Show("Please choose Apartment or Life insurance.");
        }

        private void InsuranceTypeComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            InsuranceTypeComboBox.DroppedDown = !InsuranceTypeComboBox.DroppedDown;
        }

        private void PersonalDetailsBackButton_Click(object sender, EventArgs e)
        {
            personalDetailsPanel.Visible = false;
            InsuranceTypePanel.Visible = true;
        }

        private async void PersonalDetailsNextButton_ClickAsync(object sender, EventArgs e)
        {
            if (insuranceType == InsuranceTypeEnum.Life)
            {
                insurance = new LifeInsurance
                {
                    Hobbies = lifeInsurancePanel.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Sum(cb => Convert.ToInt32(cb.Tag)),
                    Occupation = (int?)occupationComboBox.SelectedValue
                };
            }
            else
            {
                insurance = new ApartmentInsurance();
            }

            var checkedButton = personalDetailsPanel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("First name missing.");
            }
            else if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Last name missing.");
            }
            else
            {
                insurance.FirstName = firstNameTextBox.Text;
                insurance.LastName = lastNameTextBox.Text;
                insurance.Id = (int)idNumericUpDown.Value;
                insurance.Gender = Enum.Parse<GenderEnum>(checkedButton.Text);
                cityComboBox.DataSource = await LocationInformationClient.GetCitiesAsync();

                if (insuranceType == InsuranceTypeEnum.Apartment)
                {
                    apartmentInsurancePanel.Visible = true;
                    apartmentTypeComboBox.DisplayMember = "Type";
                    apartmentTypeComboBox.ValueMember = "Value";
                    apartmentTypeComboBox.DataSource = Enum.GetValues(typeof(ApartmentTypeEnum))
                        .Cast<ApartmentTypeEnum>()
                        .Select(enumValue => new { Type = enumValue.ToString(), Value = (int)enumValue })
                        .ToArray();
                }
                else
                {
                    apartmentInsurancePanel.Visible = false;
                }

                personalDetailsPanel.Visible = false;
                locationPanel.Visible = true;
            }
        }

        private void LocationBackButton_Click(object sender, EventArgs e)
        {
            locationPanel.Visible = false;
            personalDetailsPanel.Visible = true;
            ValidateInsurance();
        }

        private void OccupationComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            occupationComboBox.DroppedDown = !occupationComboBox.DroppedDown;
        }

        private async void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreetLabel.Visible = true;
            streetComboBox.Visible = true;
            streetComboBox.DataSource = await LocationInformationClient.GetStreetsAsync(cityComboBox.Text);
        }

        private void CityComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            cityComboBox.DroppedDown = !cityComboBox.DroppedDown;
        }

        private void StreetComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            streetComboBox.DroppedDown = !streetComboBox.DroppedDown;
        }

        private void ApartmentTypeComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            apartmentTypeComboBox.DroppedDown = !apartmentTypeComboBox.DroppedDown;
        }

        private void LocationNextButton_Click(object sender, EventArgs e)
        {
            insurance.City = cityComboBox.Text;
            insurance.Street = streetComboBox.Text;
            insurance.House = (int)houseNumericUpDown.Value;
            insurance.Floor = (int)floorNumericUpDown.Value;
            insurance.Apartment = (int)apartmentNumericUpDown.Value;
            if (insuranceType == InsuranceTypeEnum.Apartment)
            {
                ((ApartmentInsurance)insurance).ApartmentType = (int?)apartmentTypeComboBox.SelectedValue;
                ((ApartmentInsurance)insurance).BuildingAge = (int)buildingAgeNumericUpDown.Value;
                ((ApartmentInsurance)insurance).ApartmentSize = (int)apartmentSizeNumericUpDown.Value;
            }

            finalResultLabel.Text = Common.GetResultText(insurance, insuranceType);

            locationPanel.Visible = false;
            finalPanel.Visible = true;
        }

        private void FinalBackButton_Click(object sender, EventArgs e)
        {
            finalPanel.Visible = false;
            locationPanel.Visible = true;
            ValidateInsurance();
        }

        private void FinalFinishbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateInsurance()
        {
            if (insuranceType == InsuranceTypeEnum.Apartment)
            {
                apartmentInsurancePanel.Visible = true;
                lifeInsurancePanel.Visible = false;
            }
            else
            {
                apartmentInsurancePanel.Visible = false;
                lifeInsurancePanel.Visible = true;
            }
        }
    }
}
