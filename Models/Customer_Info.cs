using System.ComponentModel.DataAnnotations;

namespace Sushil_AssignmentTest.Models
{
    public class Customer_Info
    {

        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int? GenderId { get; set; }
        [Required]
        public int? StateId { get; set; }
        [Required]
        public int? DistrictId { get; set; }

        public virtual Gender? Gender { get; set; }
        public virtual State? State { get; set; }  
        public virtual District? District { get; set; }
    }
}

