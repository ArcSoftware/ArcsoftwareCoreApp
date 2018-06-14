using Microsoft.AspNetCore.Mvc;

namespace ArcsoftwareCoreApp.Controllers
{
    [Produces("application/json")]
    
    public class ApiController : Controller
    {
        [HttpGet]
        [Route("/v1/trustaccounts/lookupids")]
        public string GetLookUpId(string accountNumber, string routingNumber)
        {
            return null;
        }

        [HttpGet]
        [Route("/v1/trustaccounts/partnerids")]
        public int? GetBankAccountId(string lookupId)
        {
            return null;
        }
    }
}
//To Run core iis service, proxy must be set by the following:
//$_ npm install -g iisexpress-proxy
//$_ iisexpress-proxy 50154 to 81
//That allows for IP usage on VPN vs localhost. 