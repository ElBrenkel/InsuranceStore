using InsuranceStore.DataObjects;
using InsuranceStore.DataObjects.Enums;

namespace InsuranceStore.BL
{
    internal static class Common
    {
        public static string GetResultText(Insurance insurance, InsuranceTypeEnum type)
        {
            if (type == InsuranceTypeEnum.Apartment)
            {
                return $"Total amount for apartment insurance is {((ApartmentInsurance)insurance).ApartmentType + ((ApartmentInsurance)insurance).BuildingAge * 5 + ((ApartmentInsurance)insurance).ApartmentSize * 8}NIS";
            }
            else
            {
                int? risk = ((LifeInsurance)insurance).Hobbies + ((LifeInsurance)insurance).Occupation;
                if (risk >= 75)
                {
                    return "Unfortunately, risk is too high to buy insurance.";
                }
                else
                {
                    // Assignment stated to use age in the calculation, but age was no mentioned before
                    return $"Life insurance cost amount to {500 + risk}NIS";
                }
            }
        }
    }
}
