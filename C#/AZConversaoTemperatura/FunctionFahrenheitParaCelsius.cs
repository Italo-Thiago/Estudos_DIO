using System.IO;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace ConversaoTemperatura
{
    public class FunctionFahrenheitParaCelsius
    {
        private readonly ILogger<FunctionFahrenheitParaCelsius> _logger;

        public FunctionFahrenheitParaCelsius(ILogger<FunctionFahrenheitParaCelsius> log)
        {
            _logger = log;
        }

        [FunctionName("ConverterFahrenheitParaCelsius")]
        [OpenApiOperation(operationId: "Run", tags: new[] { "Conversão" })]
        [OpenApiParameter(name: "fahrenheit", In = ParameterLocation.Path, Required = true, Type = typeof(double), Description = "O valor de **Fahrenheit para conversão em Celsius")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "Retorna o valor de Celsius")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "ConverterFahrenheitParaCelsius/{fahrenheit}")] HttpRequest req,
            double fahrenheit)
        {
            _logger.LogInformation($"Parâmetro recebido: {fahrenheit}", fahrenheit);

            var valorEmCelsius = (fahrenheit - 32) * 5 / 9;

            string responseMessage = $"O valor em Fahrenheit {fahrenheit} em Celsius é {valorEmCelsius}";

            _logger.LogInformation($"Conversão efetuada. Resultado: {valorEmCelsius}");

            return new OkObjectResult(responseMessage);
        }
    }
}

