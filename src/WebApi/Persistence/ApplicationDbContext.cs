using Microsoft.EntityFrameworkCore;

namespace WebApi.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {   
        }     
    }
}