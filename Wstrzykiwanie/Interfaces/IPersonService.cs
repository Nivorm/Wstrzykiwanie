using Wstrzykiwanie.Models;
using Wstrzykiwanie.ViewModels.Person;

namespace Wstrzykiwanie.Interfaces
{
    public interface IPersonService
    {
        ListPersonForListVM GetPeopleForList();
    }
}
