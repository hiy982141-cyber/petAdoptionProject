using System.ComponentModel.DataAnnotations.Schema;

namespace petAdoption.Domain
{
    public class Pet : BaseDomainModel
    {
        public string? PetName { get; set; }
        public string? Species { get; set; }
        public string? Breed { get; set; }
        public int Age { get; set; }
        public string? Gender { get; set; }
        public string? Status { get; set; }

        // Foreign Key to Shelter
        public int ShelterId { get; set; }

        // Navigation Property (Optional, but best practice)
        [ForeignKey("ShelterId")]
        public Shelter? Shelter { get; set; }
    }
}