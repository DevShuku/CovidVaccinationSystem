using System.ComponentModel.DataAnnotations;

namespace CovidVaccinationSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 2)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string VaccinationStatus { get; set; }
        public List<Vaccination> Vaccinations { get; set; }
    }

}
