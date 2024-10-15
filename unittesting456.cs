using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class unittesting456
    {
        private readonly ILogger<unittesting456> _logger;

        public unittesting456(ILogger<unittesting456> logger)
        {
            _logger = logger;
        }

        [Function("unittesting456")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request123456578889.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
