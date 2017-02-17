using System.ComponentModel.DataAnnotations;

namespace validatingForm.Models
{
    public abstract class BaseEntity {}
    public class User : BaseEntity
    {
        [Required]
        [MinLength(3)]
        [DisplayAttribute(Name = "First Name")]
        public string FirstName {get; set;}

        [Required]
        [MinLength(3)]
        [DisplayAttribute(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [Range(0, 150)]
        [DisplayAttribute(Name = "Age")]
        public int Age {get; set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayAttribute(Name = "Email Address")]
        public string Email {get; set;}

        [Required]
        [MinLength(8)]
        [DisplayAttribute(Name = "Password")]
        public string Password {get; set;}
    }
}