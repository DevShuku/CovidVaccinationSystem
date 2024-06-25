using System.ComponentModel.DataAnnotations;

namespace CovidVaccinationSystem.Models
{    public class Vaccination
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        [Required]
        public DateTime VaccinationDate { get; set; }
        public string VaccineType { get; set; }
    }

}
