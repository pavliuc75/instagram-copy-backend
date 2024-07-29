using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LocalFunctionProj
{
    public class HttpExample2
    {
        private readonly ILogger<HttpExample> _logger;

        public HttpExample2(ILogger<HttpExample> logger)
        {
            _logger = logger;
        }
        
        [Function("HttpExample2")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation(req.Query["a"]);
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            _logger.LogInformation($"Request Body: {requestBody}");
            // MyClass myClass = JsonConvert.DeserializeObject<MyClass>(content);
            return new OkObjectResult("2");
        }
    }
}