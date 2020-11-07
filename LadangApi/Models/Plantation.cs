using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LadangApi.Models
{
    public class Plantation
    {
        public int Id { get; set; }

        [Required] public double Rate { get; set; }

        [Required] public string Location { get; set; }

        [Required] public string Vacancy { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone Format is not valid")]
        public string Phone { get; set; }

        [Required] public int PalmAge { get; set; }

        public string ImagePath { get; set; }

        [NotMapped] public byte[] ImageArray { get; set; }

        public string UserId { get; set; }
    }
}