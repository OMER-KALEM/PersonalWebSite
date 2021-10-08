using System.Data.Entity;

namespace PersonalWebSite.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<MainScreen> MainScreens { get; set; }
        public DbSet<Icon> Icons { get; set; }
    }
}