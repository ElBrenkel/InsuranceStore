

namespace InsuranceStore
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InsuranceTypePanel = new Panel();
            InsuranceTypeNextButton = new Button();
            InsuranceTypeComboBox = new ComboBox();
            InsuranceTypeLabel = new Label();
            personalDetailsPanel = new Panel();
            lifeInsurancePanel = new Panel();
            occupationComboBox = new ComboBox();
            occupationLabel = new Label();
            surfingCheckBox = new CheckBox();
            caveDivingCheckBox = new CheckBox();
            parkourCheckBox = new CheckBox();
            iceClimbingCheckBox = new CheckBox();
            divingCheckBox = new CheckBox();
            raftingCheckBox = new CheckBox();
            bungeeCheckBox = new CheckBox();
            wingsuitCheckBox = new CheckBox();
            paraglidingCheckBox = new CheckBox();
            parachutingCheckBox = new CheckBox();
            hobbiesLabel = new Label();
            idNumericUpDown = new NumericUpDown();
            otherRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            genderLabel = new Label();
            idLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            personalDetailsBackButton = new Button();
            personalDetailsNextButton = new Button();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            locationPanel = new Panel();
            floorNumericUpDown = new NumericUpDown();
            apartmentNumericUpDown = new NumericUpDown();
            houseNumericUpDown = new NumericUpDown();
            floorLabel = new Label();
            ApartmentNumberLabel = new Label();
            houseNumberLabel = new Label();
            apartmentInsurancePanel = new Panel();
            apartmentSizeNumericUpDown = new NumericUpDown();
            apartmentSizeLabel = new Label();
            buildingAgeNumericUpDown = new NumericUpDown();
            buildingAgeLabel = new Label();
            apartmentTypeComboBox = new ComboBox();
            apartmentTypeLabel = new Label();
            button1 = new Button();
            button3 = new Button();
            streetComboBox = new ComboBox();
            StreetLabel = new Label();
            cityComboBox = new ComboBox();
            cityLabel = new Label();
            locationBackButton = new Button();
            locationNextButton = new Button();
            finalPanel = new Panel();
            finalResultLabel = new Label();
            finalBackButton = new Button();
            finalFinishbutton = new Button();
            resultLabel = new Label();
            thanksLabel = new Label();
            InsuranceTypePanel.SuspendLayout();
            personalDetailsPanel.SuspendLayout();
            lifeInsurancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            locationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)floorNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)apartmentNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)houseNumericUpDown).BeginInit();
            apartmentInsurancePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)apartmentSizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buildingAgeNumericUpDown).BeginInit();
            finalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // InsuranceTypePanel
            // 
            InsuranceTypePanel.Controls.Add(InsuranceTypeNextButton);
            InsuranceTypePanel.Controls.Add(InsuranceTypeComboBox);
            InsuranceTypePanel.Controls.Add(InsuranceTypeLabel);
            InsuranceTypePanel.Location = new Point(12, 12);
            InsuranceTypePanel.Name = "InsuranceTypePanel";
            InsuranceTypePanel.Size = new Size(772, 477);
            InsuranceTypePanel.TabIndex = 0;
            // 
            // InsuranceTypeNextButton
            // 
            InsuranceTypeNextButton.Location = new Point(636, 433);
            InsuranceTypeNextButton.Name = "InsuranceTypeNextButton";
            InsuranceTypeNextButton.Size = new Size(122, 30);
            InsuranceTypeNextButton.TabIndex = 2;
            InsuranceTypeNextButton.Text = "Next";
            InsuranceTypeNextButton.UseVisualStyleBackColor = true;
            InsuranceTypeNextButton.Click += InsuranceTypeNextButton_Click;
            // 
            // InsuranceTypeComboBox
            // 
            InsuranceTypeComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            InsuranceTypeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            InsuranceTypeComboBox.FormattingEnabled = true;
            InsuranceTypeComboBox.Items.AddRange(new object[] { "Apartment", "Life" });
            InsuranceTypeComboBox.Location = new Point(233, 42);
            InsuranceTypeComboBox.Name = "InsuranceTypeComboBox";
            InsuranceTypeComboBox.Size = new Size(320, 29);
            InsuranceTypeComboBox.TabIndex = 1;
            InsuranceTypeComboBox.Text = "Select insurance type";
            InsuranceTypeComboBox.MouseDown += InsuranceTypeComboBox_MouseDown;
            // 
            // InsuranceTypeLabel
            // 
            InsuranceTypeLabel.AutoSize = true;
            InsuranceTypeLabel.Location = new Point(114, 45);
            InsuranceTypeLabel.Name = "InsuranceTypeLabel";
            InsuranceTypeLabel.Size = new Size(113, 21);
            InsuranceTypeLabel.TabIndex = 0;
            InsuranceTypeLabel.Text = "Insurance Type";
            // 
            // personalDetailsPanel
            // 
            personalDetailsPanel.Controls.Add(lifeInsurancePanel);
            personalDetailsPanel.Controls.Add(idNumericUpDown);
            personalDetailsPanel.Controls.Add(otherRadioButton);
            personalDetailsPanel.Controls.Add(maleRadioButton);
            personalDetailsPanel.Controls.Add(femaleRadioButton);
            personalDetailsPanel.Controls.Add(genderLabel);
            personalDetailsPanel.Controls.Add(idLabel);
            personalDetailsPanel.Controls.Add(lastNameTextBox);
            personalDetailsPanel.Controls.Add(lastNameLabel);
            personalDetailsPanel.Controls.Add(personalDetailsBackButton);
            personalDetailsPanel.Controls.Add(personalDetailsNextButton);
            personalDetailsPanel.Controls.Add(firstNameTextBox);
            personalDetailsPanel.Controls.Add(firstNameLabel);
            personalDetailsPanel.Location = new Point(12, 12);
            personalDetailsPanel.Name = "personalDetailsPanel";
            personalDetailsPanel.Size = new Size(772, 477);
            personalDetailsPanel.TabIndex = 3;
            // 
            // lifeInsurancePanel
            // 
            lifeInsurancePanel.Controls.Add(occupationComboBox);
            lifeInsurancePanel.Controls.Add(occupationLabel);
            lifeInsurancePanel.Controls.Add(surfingCheckBox);
            lifeInsurancePanel.Controls.Add(caveDivingCheckBox);
            lifeInsurancePanel.Controls.Add(parkourCheckBox);
            lifeInsurancePanel.Controls.Add(iceClimbingCheckBox);
            lifeInsurancePanel.Controls.Add(divingCheckBox);
            lifeInsurancePanel.Controls.Add(raftingCheckBox);
            lifeInsurancePanel.Controls.Add(bungeeCheckBox);
            lifeInsurancePanel.Controls.Add(wingsuitCheckBox);
            lifeInsurancePanel.Controls.Add(paraglidingCheckBox);
            lifeInsurancePanel.Controls.Add(parachutingCheckBox);
            lifeInsurancePanel.Controls.Add(hobbiesLabel);
            lifeInsurancePanel.Location = new Point(0, 186);
            lifeInsurancePanel.Name = "lifeInsurancePanel";
            lifeInsurancePanel.Size = new Size(772, 238);
            lifeInsurancePanel.TabIndex = 9;
            // 
            // occupationComboBox
            // 
            occupationComboBox.FormattingEnabled = true;
            occupationComboBox.Items.AddRange(new object[] { "Firefighter", "Police officer", "Construction worker", "Military personnel", "Miner", "Aircraft pilot", "Teacher", "Student" });
            occupationComboBox.Location = new Point(213, 99);
            occupationComboBox.Name = "occupationComboBox";
            occupationComboBox.Size = new Size(340, 29);
            occupationComboBox.TabIndex = 12;
            occupationComboBox.Text = "Select occupation";
            occupationComboBox.MouseDown += OccupationComboBox_MouseDown;
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Location = new Point(114, 102);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new Size(89, 21);
            occupationLabel.TabIndex = 11;
            occupationLabel.Text = "Occupation";
            // 
            // surfingCheckBox
            // 
            surfingCheckBox.AutoSize = true;
            surfingCheckBox.Location = new Point(330, 50);
            surfingCheckBox.Name = "surfingCheckBox";
            surfingCheckBox.Size = new Size(80, 25);
            surfingCheckBox.TabIndex = 7;
            surfingCheckBox.Tag = "10";
            surfingCheckBox.Text = "Surfing";
            surfingCheckBox.UseVisualStyleBackColor = true;
            // 
            // caveDivingCheckBox
            // 
            caveDivingCheckBox.AutoSize = true;
            caveDivingCheckBox.Location = new Point(603, 50);
            caveDivingCheckBox.Name = "caveDivingCheckBox";
            caveDivingCheckBox.Size = new Size(112, 25);
            caveDivingCheckBox.TabIndex = 10;
            caveDivingCheckBox.Tag = "45";
            caveDivingCheckBox.Text = "Cave Diving";
            caveDivingCheckBox.UseVisualStyleBackColor = true;
            // 
            // parkourCheckBox
            // 
            parkourCheckBox.AutoSize = true;
            parkourCheckBox.Location = new Point(427, 19);
            parkourCheckBox.Name = "parkourCheckBox";
            parkourCheckBox.Size = new Size(83, 25);
            parkourCheckBox.TabIndex = 3;
            parkourCheckBox.Tag = "20";
            parkourCheckBox.Text = "Parkour";
            parkourCheckBox.UseVisualStyleBackColor = true;
            // 
            // iceClimbingCheckBox
            // 
            iceClimbingCheckBox.AutoSize = true;
            iceClimbingCheckBox.Location = new Point(603, 19);
            iceClimbingCheckBox.Name = "iceClimbingCheckBox";
            iceClimbingCheckBox.Size = new Size(115, 25);
            iceClimbingCheckBox.TabIndex = 5;
            iceClimbingCheckBox.Tag = "45";
            iceClimbingCheckBox.Text = "Ice Climbing";
            iceClimbingCheckBox.UseVisualStyleBackColor = true;
            // 
            // divingCheckBox
            // 
            divingCheckBox.AutoSize = true;
            divingCheckBox.Location = new Point(427, 50);
            divingCheckBox.Name = "divingCheckBox";
            divingCheckBox.Size = new Size(74, 25);
            divingCheckBox.TabIndex = 8;
            divingCheckBox.Tag = "25";
            divingCheckBox.Text = "Diving";
            divingCheckBox.UseVisualStyleBackColor = true;
            // 
            // raftingCheckBox
            // 
            raftingCheckBox.AutoSize = true;
            raftingCheckBox.Location = new Point(516, 50);
            raftingCheckBox.Name = "raftingCheckBox";
            raftingCheckBox.Size = new Size(79, 25);
            raftingCheckBox.TabIndex = 9;
            raftingCheckBox.Tag = "15";
            raftingCheckBox.Text = "Rafting";
            raftingCheckBox.UseVisualStyleBackColor = true;
            // 
            // bungeeCheckBox
            // 
            bungeeCheckBox.AutoSize = true;
            bungeeCheckBox.Location = new Point(516, 19);
            bungeeCheckBox.Name = "bungeeCheckBox";
            bungeeCheckBox.Size = new Size(81, 25);
            bungeeCheckBox.TabIndex = 4;
            bungeeCheckBox.Tag = "30";
            bungeeCheckBox.Text = "Bungee";
            bungeeCheckBox.UseVisualStyleBackColor = true;
            // 
            // wingsuitCheckBox
            // 
            wingsuitCheckBox.AutoSize = true;
            wingsuitCheckBox.Location = new Point(330, 19);
            wingsuitCheckBox.Name = "wingsuitCheckBox";
            wingsuitCheckBox.Size = new Size(91, 25);
            wingsuitCheckBox.TabIndex = 2;
            wingsuitCheckBox.Tag = "40";
            wingsuitCheckBox.Text = "Wingsuit";
            wingsuitCheckBox.UseVisualStyleBackColor = true;
            // 
            // paraglidingCheckBox
            // 
            paraglidingCheckBox.AutoSize = true;
            paraglidingCheckBox.Location = new Point(213, 50);
            paraglidingCheckBox.Name = "paraglidingCheckBox";
            paraglidingCheckBox.Size = new Size(107, 25);
            paraglidingCheckBox.TabIndex = 6;
            paraglidingCheckBox.Tag = "25";
            paraglidingCheckBox.Text = "Paragliding";
            paraglidingCheckBox.UseVisualStyleBackColor = true;
            // 
            // parachutingCheckBox
            // 
            parachutingCheckBox.AutoSize = true;
            parachutingCheckBox.Location = new Point(213, 19);
            parachutingCheckBox.Name = "parachutingCheckBox";
            parachutingCheckBox.Size = new Size(111, 25);
            parachutingCheckBox.TabIndex = 1;
            parachutingCheckBox.Tag = "20";
            parachutingCheckBox.Text = "Parachuting";
            parachutingCheckBox.UseVisualStyleBackColor = true;
            // 
            // hobbiesLabel
            // 
            hobbiesLabel.AutoSize = true;
            hobbiesLabel.Location = new Point(114, 20);
            hobbiesLabel.Name = "hobbiesLabel";
            hobbiesLabel.Size = new Size(67, 21);
            hobbiesLabel.TabIndex = 0;
            hobbiesLabel.Text = "Hobbies";
            // 
            // idNumericUpDown
            // 
            idNumericUpDown.Location = new Point(213, 113);
            idNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            idNumericUpDown.Name = "idNumericUpDown";
            idNumericUpDown.Size = new Size(146, 29);
            idNumericUpDown.TabIndex = 5;
            // 
            // otherRadioButton
            // 
            otherRadioButton.AutoSize = true;
            otherRadioButton.Location = new Point(365, 149);
            otherRadioButton.Name = "otherRadioButton";
            otherRadioButton.Size = new Size(68, 25);
            otherRadioButton.TabIndex = 8;
            otherRadioButton.Text = "Other";
            otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(297, 149);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(62, 25);
            maleRadioButton.TabIndex = 7;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Checked = true;
            femaleRadioButton.Location = new Point(213, 148);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(78, 25);
            femaleRadioButton.TabIndex = 6;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(114, 150);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(61, 21);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(114, 115);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(25, 21);
            idLabel.TabIndex = 8;
            idLabel.Text = "ID";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(213, 77);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(340, 29);
            lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(114, 80);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(81, 21);
            lastNameLabel.TabIndex = 60;
            lastNameLabel.Text = "Last name";
            // 
            // personalDetailsBackButton
            // 
            personalDetailsBackButton.Location = new Point(507, 430);
            personalDetailsBackButton.Name = "personalDetailsBackButton";
            personalDetailsBackButton.Size = new Size(122, 34);
            personalDetailsBackButton.TabIndex = 50;
            personalDetailsBackButton.Text = "Back";
            personalDetailsBackButton.UseVisualStyleBackColor = true;
            personalDetailsBackButton.Click += PersonalDetailsBackButton_Click;
            // 
            // personalDetailsNextButton
            // 
            personalDetailsNextButton.Location = new Point(637, 430);
            personalDetailsNextButton.Name = "personalDetailsNextButton";
            personalDetailsNextButton.Size = new Size(122, 34);
            personalDetailsNextButton.TabIndex = 51;
            personalDetailsNextButton.Text = "Next";
            personalDetailsNextButton.UseVisualStyleBackColor = true;
            personalDetailsNextButton.Click += PersonalDetailsNextButton_ClickAsync;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(213, 42);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(340, 29);
            firstNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(114, 45);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 21);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "First name";
            // 
            // locationPanel
            // 
            locationPanel.Controls.Add(floorNumericUpDown);
            locationPanel.Controls.Add(apartmentNumericUpDown);
            locationPanel.Controls.Add(houseNumericUpDown);
            locationPanel.Controls.Add(floorLabel);
            locationPanel.Controls.Add(ApartmentNumberLabel);
            locationPanel.Controls.Add(houseNumberLabel);
            locationPanel.Controls.Add(apartmentInsurancePanel);
            locationPanel.Controls.Add(streetComboBox);
            locationPanel.Controls.Add(StreetLabel);
            locationPanel.Controls.Add(cityComboBox);
            locationPanel.Controls.Add(cityLabel);
            locationPanel.Controls.Add(locationBackButton);
            locationPanel.Controls.Add(locationNextButton);
            locationPanel.Location = new Point(12, 12);
            locationPanel.Name = "locationPanel";
            locationPanel.Size = new Size(772, 477);
            locationPanel.TabIndex = 61;
            // 
            // floorNumericUpDown
            // 
            floorNumericUpDown.Location = new Point(213, 183);
            floorNumericUpDown.Name = "floorNumericUpDown";
            floorNumericUpDown.Size = new Size(146, 29);
            floorNumericUpDown.TabIndex = 68;
            // 
            // apartmentNumericUpDown
            // 
            apartmentNumericUpDown.Location = new Point(213, 148);
            apartmentNumericUpDown.Name = "apartmentNumericUpDown";
            apartmentNumericUpDown.Size = new Size(146, 29);
            apartmentNumericUpDown.TabIndex = 67;
            // 
            // houseNumericUpDown
            // 
            houseNumericUpDown.Location = new Point(213, 112);
            houseNumericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            houseNumericUpDown.Name = "houseNumericUpDown";
            houseNumericUpDown.Size = new Size(146, 29);
            houseNumericUpDown.TabIndex = 66;
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Location = new Point(114, 185);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(59, 21);
            floorLabel.TabIndex = 65;
            floorLabel.Text = "Floor #";
            // 
            // ApartmentNumberLabel
            // 
            ApartmentNumberLabel.AutoSize = true;
            ApartmentNumberLabel.Location = new Point(114, 150);
            ApartmentNumberLabel.Name = "ApartmentNumberLabel";
            ApartmentNumberLabel.Size = new Size(97, 21);
            ApartmentNumberLabel.TabIndex = 64;
            ApartmentNumberLabel.Text = "Apartment #";
            // 
            // houseNumberLabel
            // 
            houseNumberLabel.AutoSize = true;
            houseNumberLabel.Location = new Point(114, 115);
            houseNumberLabel.Name = "houseNumberLabel";
            houseNumberLabel.Size = new Size(67, 21);
            houseNumberLabel.TabIndex = 63;
            houseNumberLabel.Text = "House #";
            // 
            // apartmentInsurancePanel
            // 
            apartmentInsurancePanel.Controls.Add(apartmentSizeNumericUpDown);
            apartmentInsurancePanel.Controls.Add(apartmentSizeLabel);
            apartmentInsurancePanel.Controls.Add(buildingAgeNumericUpDown);
            apartmentInsurancePanel.Controls.Add(buildingAgeLabel);
            apartmentInsurancePanel.Controls.Add(apartmentTypeComboBox);
            apartmentInsurancePanel.Controls.Add(apartmentTypeLabel);
            apartmentInsurancePanel.Controls.Add(button1);
            apartmentInsurancePanel.Controls.Add(button3);
            apartmentInsurancePanel.Location = new Point(0, 218);
            apartmentInsurancePanel.Name = "apartmentInsurancePanel";
            apartmentInsurancePanel.Size = new Size(772, 203);
            apartmentInsurancePanel.TabIndex = 62;
            // 
            // apartmentSizeNumericUpDown
            // 
            apartmentSizeNumericUpDown.Location = new Point(213, 113);
            apartmentSizeNumericUpDown.Name = "apartmentSizeNumericUpDown";
            apartmentSizeNumericUpDown.Size = new Size(146, 29);
            apartmentSizeNumericUpDown.TabIndex = 70;
            // 
            // apartmentSizeLabel
            // 
            apartmentSizeLabel.AutoSize = true;
            apartmentSizeLabel.Location = new Point(114, 115);
            apartmentSizeLabel.Name = "apartmentSizeLabel";
            apartmentSizeLabel.Size = new Size(64, 21);
            apartmentSizeLabel.TabIndex = 58;
            apartmentSizeLabel.Text = "Apt size";
            // 
            // buildingAgeNumericUpDown
            // 
            buildingAgeNumericUpDown.Location = new Point(213, 78);
            buildingAgeNumericUpDown.Name = "buildingAgeNumericUpDown";
            buildingAgeNumericUpDown.Size = new Size(146, 29);
            buildingAgeNumericUpDown.TabIndex = 69;
            // 
            // buildingAgeLabel
            // 
            buildingAgeLabel.AutoSize = true;
            buildingAgeLabel.Location = new Point(114, 80);
            buildingAgeLabel.Name = "buildingAgeLabel";
            buildingAgeLabel.Size = new Size(96, 21);
            buildingAgeLabel.TabIndex = 56;
            buildingAgeLabel.Text = "Building age";
            // 
            // apartmentTypeComboBox
            // 
            apartmentTypeComboBox.FormattingEnabled = true;
            apartmentTypeComboBox.Location = new Point(213, 42);
            apartmentTypeComboBox.Name = "apartmentTypeComboBox";
            apartmentTypeComboBox.Size = new Size(340, 29);
            apartmentTypeComboBox.TabIndex = 55;
            apartmentTypeComboBox.Text = "Select apartment type";
            apartmentTypeComboBox.MouseDown += ApartmentTypeComboBox_MouseDown;
            // 
            // apartmentTypeLabel
            // 
            apartmentTypeLabel.AutoSize = true;
            apartmentTypeLabel.Location = new Point(114, 45);
            apartmentTypeLabel.Name = "apartmentTypeLabel";
            apartmentTypeLabel.Size = new Size(68, 21);
            apartmentTypeLabel.TabIndex = 54;
            apartmentTypeLabel.Text = "Apt type";
            // 
            // button1
            // 
            button1.Location = new Point(505, 429);
            button1.Name = "button1";
            button1.Size = new Size(122, 34);
            button1.TabIndex = 52;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(635, 429);
            button3.Name = "button3";
            button3.Size = new Size(122, 34);
            button3.TabIndex = 53;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            // 
            // streetComboBox
            // 
            streetComboBox.FormattingEnabled = true;
            streetComboBox.Location = new Point(213, 77);
            streetComboBox.Name = "streetComboBox";
            streetComboBox.Size = new Size(340, 29);
            streetComboBox.TabIndex = 57;
            streetComboBox.Text = "Select street";
            streetComboBox.MouseDown += StreetComboBox_MouseDown;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(114, 80);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(50, 21);
            StreetLabel.TabIndex = 56;
            StreetLabel.Text = "Street";
            // 
            // cityComboBox
            // 
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(213, 42);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(340, 29);
            cityComboBox.TabIndex = 55;
            cityComboBox.Text = "Select city";
            cityComboBox.SelectedIndexChanged += CityComboBox_SelectedIndexChanged;
            cityComboBox.MouseDown += CityComboBox_MouseDown;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(114, 45);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(37, 21);
            cityLabel.TabIndex = 54;
            cityLabel.Text = "City";
            // 
            // locationBackButton
            // 
            locationBackButton.Location = new Point(505, 429);
            locationBackButton.Name = "locationBackButton";
            locationBackButton.Size = new Size(122, 34);
            locationBackButton.TabIndex = 52;
            locationBackButton.Text = "Back";
            locationBackButton.UseVisualStyleBackColor = true;
            locationBackButton.Click += LocationBackButton_Click;
            // 
            // locationNextButton
            // 
            locationNextButton.Location = new Point(635, 429);
            locationNextButton.Name = "locationNextButton";
            locationNextButton.Size = new Size(122, 34);
            locationNextButton.TabIndex = 53;
            locationNextButton.Text = "Next";
            locationNextButton.UseVisualStyleBackColor = true;
            locationNextButton.Click += LocationNextButton_Click;
            // 
            // finalPanel
            // 
            finalPanel.Controls.Add(finalResultLabel);
            finalPanel.Controls.Add(finalBackButton);
            finalPanel.Controls.Add(finalFinishbutton);
            finalPanel.Controls.Add(resultLabel);
            finalPanel.Controls.Add(thanksLabel);
            finalPanel.Location = new Point(12, 12);
            finalPanel.Name = "finalPanel";
            finalPanel.Size = new Size(772, 477);
            finalPanel.TabIndex = 62;
            // 
            // finalResultLabel
            // 
            finalResultLabel.AutoSize = true;
            finalResultLabel.Location = new Point(93, 112);
            finalResultLabel.Name = "finalResultLabel";
            finalResultLabel.Size = new Size(14, 21);
            finalResultLabel.TabIndex = 56;
            finalResultLabel.Text = " ";
            // 
            // finalBackButton
            // 
            finalBackButton.Location = new Point(508, 427);
            finalBackButton.Name = "finalBackButton";
            finalBackButton.Size = new Size(122, 34);
            finalBackButton.TabIndex = 55;
            finalBackButton.Text = "Back";
            finalBackButton.UseVisualStyleBackColor = true;
            finalBackButton.Click += FinalBackButton_Click;
            // 
            // finalFinishbutton
            // 
            finalFinishbutton.Location = new Point(637, 427);
            finalFinishbutton.Name = "finalFinishbutton";
            finalFinishbutton.Size = new Size(122, 34);
            finalFinishbutton.TabIndex = 54;
            finalFinishbutton.Text = "Finish";
            finalFinishbutton.UseVisualStyleBackColor = true;
            finalFinishbutton.Click += FinalFinishbutton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(87, 112);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 21);
            resultLabel.TabIndex = 1;
            // 
            // thanksLabel
            // 
            thanksLabel.AutoSize = true;
            thanksLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thanksLabel.Location = new Point(87, 50);
            thanksLabel.Name = "thanksLabel";
            thanksLabel.Size = new Size(450, 37);
            thanksLabel.TabIndex = 0;
            thanksLabel.Text = "Thanks for using our insurance store!";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 501);
            Controls.Add(personalDetailsPanel);
            Controls.Add(InsuranceTypePanel);
            Controls.Add(finalPanel);
            Controls.Add(locationPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Insurance store";
            InsuranceTypePanel.ResumeLayout(false);
            InsuranceTypePanel.PerformLayout();
            personalDetailsPanel.ResumeLayout(false);
            personalDetailsPanel.PerformLayout();
            lifeInsurancePanel.ResumeLayout(false);
            lifeInsurancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            locationPanel.ResumeLayout(false);
            locationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)floorNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)apartmentNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)houseNumericUpDown).EndInit();
            apartmentInsurancePanel.ResumeLayout(false);
            apartmentInsurancePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)apartmentSizeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)buildingAgeNumericUpDown).EndInit();
            finalPanel.ResumeLayout(false);
            finalPanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel InsuranceTypePanel;
        private Button InsuranceTypeNextButton;
        private ComboBox InsuranceTypeComboBox;
        private Label InsuranceTypeLabel;
        private Label firstNameLabel;
        private Panel personalDetailsPanel;
        private TextBox firstNameTextBox;
        private Button personalDetailsBackButton;
        private Button personalDetailsNextButton;
        private Label genderLabel;
        private Label idLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private RadioButton otherRadioButton;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private NumericUpDown idNumericUpDown;
        private Panel lifeInsurancePanel;
        private CheckBox raftingCheckBox;
        private CheckBox bungeeCheckBox;
        private CheckBox wingsuitCheckBox;
        private CheckBox paraglidingCheckBox;
        private CheckBox parachutingCheckBox;
        private Label hobbiesLabel;
        private CheckBox surfingCheckBox;
        private CheckBox caveDivingCheckBox;
        private CheckBox parkourCheckBox;
        private CheckBox iceClimbingCheckBox;
        private CheckBox divingCheckBox;
        private ComboBox occupationComboBox;
        private Label occupationLabel;
        private Panel locationPanel;
        private Button locationBackButton;
        private Button locationNextButton;
        private ComboBox streetComboBox;
        private Label StreetLabel;
        private ComboBox cityComboBox;
        private Label cityLabel;
        private Panel apartmentInsurancePanel;
        private Label buildingAgeLabel;
        private ComboBox apartmentTypeComboBox;
        private Label apartmentTypeLabel;
        private Button button1;
        private Button button3;
        private NumericUpDown floorNumericUpDown;
        private NumericUpDown apartmentNumericUpDown;
        private NumericUpDown houseNumericUpDown;
        private Label floorLabel;
        private Label ApartmentNumberLabel;
        private Label houseNumberLabel;
        private NumericUpDown apartmentSizeNumericUpDown;
        private Label apartmentSizeLabel;
        private NumericUpDown buildingAgeNumericUpDown;
        private Panel finalPanel;
        private Label thanksLabel;
        private Button finalBackButton;
        private Button finalFinishbutton;
        private Label resultLabel;
        private Label finalResultLabel;
    }
}
