using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestIdentity2.Pages.TestAuthor
{
    [Authorize(Roles = "client")]
    public class clientModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
