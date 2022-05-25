using Wstrzykiwanie.Models;

namespace Wstrzykiwanie.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAllActivePeople();
    }
}
