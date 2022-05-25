using Wstrzykiwanie.Models;
using Microsoft.EntityFrameworkCore;
namespace Wstrzykiwanie.Data
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }
}
