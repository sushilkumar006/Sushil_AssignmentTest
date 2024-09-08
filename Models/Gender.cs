using System.ComponentModel.DataAnnotations;

namespace Sushil_AssignmentTest.Models
{
    public class Gender
    {
        public int Id { get; set; }
        [Required]
        public string GenderName { get; set; }

        public virtual ICollection<Customer_Info> Customer { get; set; }
    }
}
