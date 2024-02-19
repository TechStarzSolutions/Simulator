using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Simulator.Web.Pages;

public class IndexModel : SimulatorPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
