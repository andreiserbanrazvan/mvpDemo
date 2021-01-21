using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models.Department
{
    public class DepartmentModel : IDepartmentModel
    {
        public int DepartmentID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Department name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Department name must be between 5 and 20 characters")]
        public string DepartmentName { get; set; }
        [Required(ErrorMessage = "Department url is required")]
        [RegularExpression(@"^((http|ftp|https|www)://)?([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)\_\-\=\+\\\/\?\.\:\;\'\,]*)?$",
            ErrorMessage = "URL format is incorrect")]
        public string DepartmentUrl { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^[01]?[\(\)\.\- ]{0,}[0-9]{3}[\(\)\.\- ]{0,}[0-9]{3}[\(\)\.\- ]{0,}[0,9]{4}[\(\)\.\- ](0,)$",
            ErrorMessage = "Phone format is incorrect")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email is a Required field.")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "City is required")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "City must be between 5 and 20 characters")]
        public string CityLocation { get; set; }
        [Required(ErrorMessage = "State is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "state must be between 5 and 20 characters ")]
        public string StateLocation { get; set; }

    }
}
