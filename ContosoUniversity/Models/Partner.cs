using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Partner
    {
        public int PartnerID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Número máximo de caracters atingido!")]
        public string Name { get; set; }
    }
}