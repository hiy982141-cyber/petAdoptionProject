namespace petAdoption.Domain
{
    public class Shelter : BaseDomainModel
    {
        public string? ShelterName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
    }
}