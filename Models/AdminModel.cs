using System.ComponentModel.DataAnnotations;

namespace CoreRegSite.Models
{
    public class AdminModel
    {
        [Required]
        public string Login{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}