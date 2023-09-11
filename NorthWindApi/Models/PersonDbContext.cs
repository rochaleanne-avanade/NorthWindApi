using Microsoft.EntityFrameworkCore;

namespace NorthWindApi.Models
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions<PersonDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
