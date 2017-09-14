using Microsoft.EntityFrameworkCore;

namespace chalkboard.Persistance
{
    public class ChalkboardDbContext : DbContext
    {
         public ChalkboardDbContext(DbContextOptions<ChalkboardDbContext> options)
            : base(options)
        {
        }
    }
}