using Microsoft.EntityFrameworkCore;
using Videos.Entidad;

namespace Videos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Video> Videos { get; set; }
    }
}
