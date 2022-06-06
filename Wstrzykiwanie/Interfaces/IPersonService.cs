using Models.ModelsView;
using Wstrzykiwanie.Models;
using Wstrzykiwanie.ViewModels.Person;

namespace Wstrzykiwanie.Interfaces
{
    public interface IPersonService
    {

        public void AddEntry(Person person);

        public PersonListModelView GetPeople();

        public PersonListModelView GetPeopleToday();
    }


}