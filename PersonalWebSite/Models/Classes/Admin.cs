using System.ComponentModel.DataAnnotations;

namespace PersonalWebSite.Models.Classes
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}