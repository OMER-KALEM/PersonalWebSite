using System.ComponentModel.DataAnnotations;

namespace PersonalWebSite.Models.Classes
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }
        public string IconName { get; set; }
        public string Link { get; set; }
    }
}