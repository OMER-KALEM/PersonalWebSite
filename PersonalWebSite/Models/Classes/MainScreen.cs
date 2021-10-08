using System.ComponentModel.DataAnnotations;

namespace PersonalWebSite.Models.Classes
{
    public class MainScreen
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfilPhoto { get; set; }
        public string JobTitle { get; set; }
        public string Explanation { get; set; }
        public string Contact { get; set; }
    }
}