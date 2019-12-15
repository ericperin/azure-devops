using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Example.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _env;

        public IndexModel(ILogger<IndexModel> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public void OnGet()
        {
            _logger.LogInformation($"!!!! {_env.EnvironmentName} !!!");

            _logger.LogError("LogError....");
            _logger.LogInformation("LogInformation....");
            _logger.LogWarning("LogWarning....");
        }
    }
}
