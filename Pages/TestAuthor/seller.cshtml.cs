using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestIdentity2.Pages.TestAuthor
{
    [Authorize(Roles = "seller")]
    public class sellerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
