using KosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KosMVC.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class NumberController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> NumberToWords(ulong number)
        {

            var client = new ServiceNumberConversion.NumberConversionSoapTypeClient(
                    ServiceNumberConversion.NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap12
                );
            var response = await client.NumberToWordsAsync(number);
            return Ok(new NumberWordResult { text = response.Body.NumberToWordsResult });

        }

        [HttpGet]
        public async Task<IActionResult> NumberToDollars(ulong number)
        {
            var client = new ServiceNumberConversion.NumberConversionSoapTypeClient(
                   ServiceNumberConversion.NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap12
               );
            var response = await client.NumberToDollarsAsync(number);
            return Ok(new NumberWordResult { text = response.Body.NumberToDollarsResult });
        }
       
    }
}
