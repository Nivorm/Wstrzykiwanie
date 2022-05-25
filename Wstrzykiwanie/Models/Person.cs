namespace Wstrzykiwanie.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Address>? Addresses
        {
            get; set;
        }
        public ICollection<PersonGroup>? PersonGroups { get; set; }
        public bool IsActive { get; set; }
    }
}
