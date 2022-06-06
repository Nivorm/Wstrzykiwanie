using Models.ModelsView;
using Wstrzykiwanie.Models;

namespace Extensions;

public static class ModelExtensions
{
    public static IQueryable<PersonModelView> ToModel(this IQueryable<Person> source)
    {
        return source.Select(person => new PersonModelView()
        {
            Id = person.PersonID,
            FullName = person.Name + " " + person.LastName
        });
    }
}