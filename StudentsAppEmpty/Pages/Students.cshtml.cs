
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentsAppEmpty.Pages
{
    public class StudentsModel : PageModel
    {
        public IEnumerable<string>? Students { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "SEV-AUEB";
            Students = new[]
            {
                "Alice W.",
                "Bob D.",
                "Costas A."
           };

            //return Page();
        }
    }
}
