using System.ComponentModel.DataAnnotations;

namespace RemoteEmpoyeeManagementSystem.Models
{
    public class UserLogin
    {
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Enter User ID In Given format")]
        public string UserId { get; set; }
        [Required]
        [MinLength(8 ,ErrorMessage ="Password Must Contain 8 Characters")]
        public string Password { get; set; }
    }
}
