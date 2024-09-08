using System.ComponentModel.DataAnnotations;

namespace Sushil_AssignmentTest.Models
{
    public class State
    {
        public int Id { get; set; }
        [Required]
        public string StateName { get; set; }
        public virtual ICollection<Customer_Info> Customer { get; set; }
    }
}
