using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestIdentity2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async void OnGet()
    {
         var message = await MailUtils.MailUtils.
            SendGmail("tuanvahe140809@fpt.edu.vn",
            "tuanvahe2021@gmail.com",
            "Test Gmail", "Xin chao tuan",
            "tuanvahe140809@fpt.edu.vn",
            "vzqc wrvg fbqb ivmq"
            );

    }
}
