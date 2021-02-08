using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public class CartInfo{
        public string cartID;
    }

    public static class GetCartInfo
    {
        [FunctionName("GetCartInfo")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string responseMessage = "";
            CartInfo cartInfo = new CartInfo() { cartID = "asfd-sfda-saf-sfd" };
            return new JsonResult(cartInfo);
        }
    }
}
