using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<PersonModel> Person {  get; set; }
    }
}
