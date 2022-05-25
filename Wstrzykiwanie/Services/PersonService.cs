using Wstrzykiwanie.Data;
using Wstrzykiwanie.Interfaces;
using Wstrzykiwanie.Models;
using Wstrzykiwanie.ViewModels.Person;

namespace Wstrzykiwanie.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepo;
        public PersonService(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }
        public ListPersonForListVM GetPeopleForList()
        {
            var people = _personRepo.GetAllActivePeople();
            ListPersonForListVM result = new
            ListPersonForListVM();
            result.People = new List<PersonForListVm>();
            foreach (var person in people)
            {
                // mapowanie obiektow
                var pVM = new PersonForListVm()
                {
                    Id = person.Id,
                    FullName = person.FirstName + " " + person.LastName
                };
                result.People.Add(pVM);
            }
            result.Count = result.People.Count;
            return result;
        }
    }
}
