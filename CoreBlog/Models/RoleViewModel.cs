

using System.ComponentModel.DataAnnotations;

namespace CoreBlog.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Lütfen rol adı giriniz")]
        public string name { get; set; }
    }
}
