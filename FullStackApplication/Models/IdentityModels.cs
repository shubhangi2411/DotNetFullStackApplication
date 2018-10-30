using Microsoft.AspNet.Identity.EntityFramework;

namespace FullStackApplication.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
