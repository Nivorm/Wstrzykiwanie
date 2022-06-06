using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.ModelsView;
using Wstrzykiwanie.Interfaces;

namespace WstrzykiwanieSerwisów.Pages
{
    public class OstatnioSzukane : PageModel
    {
        private readonly IPersonService _personService;
        public PersonListModelView Records { get; set; }
        public OstatnioSzukane(IPersonService personService)
        {
            _personService = personService;
        }
        public void OnGet()
        {
            Records = _personService.GetPeopleToday();
        }

    }
}