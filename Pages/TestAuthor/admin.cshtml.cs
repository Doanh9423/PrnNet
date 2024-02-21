using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestIdentity2.Pages.AdminPage
{
    [Authorize(Roles = "admin")]
    public class adminModel : PageModel
    { 
        public void OnGet()
        {
        }
    }
}
