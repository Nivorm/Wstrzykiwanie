using Wstrzykiwanie.Models;
using Microsoft.EntityFrameworkCore;
namespace Wstrzykiwanie.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options) { }
        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
