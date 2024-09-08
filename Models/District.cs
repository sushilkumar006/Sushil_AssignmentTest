using System.ComponentModel.DataAnnotations;

namespace Sushil_AssignmentTest.Models
{
    public class District
    {
        public int Id { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        public int StId { get; set; }
        public virtual ICollection<Customer_Info> Customer { get; set; }
    }
}
