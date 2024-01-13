using InsuranceStore.DataObjects.Enums;

namespace InsuranceStore.DataObjects
{
    internal class Insurance
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Id { get; set; }
        public GenderEnum Gender { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int? House { get; set; }
        public int? Floor { get; set; }
        public int? Apartment { get; set; }
    }

    internal class LifeInsurance : Insurance
    {
        public int? Hobbies { get; set; }
        public int? Occupation { get; set; }
    }

    internal class ApartmentInsurance : Insurance
    {
        public int? ApartmentType { get; set; }
        public int? BuildingAge { get; set; }
        public int? ApartmentSize { get; set; }
    }
}
