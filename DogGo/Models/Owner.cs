using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number, please format it like (123)-456-7890")]
        public string Phone { get; set; }
    }
}