using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KennethWebDemos.Pages
{
    public class FallingRainbowModel : PageModel
    {
        private readonly ILogger<IndexModel> logger;

        public FallingRainbowModel(ILogger<IndexModel> logger)
        {
            this.logger = logger;
        }

        public void OnGet()
        {

        }
    }
}