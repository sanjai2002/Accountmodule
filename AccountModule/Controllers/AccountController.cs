using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AccountModule.Model;

namespace AccountModule.Controllers
{

    [Route("bankingrest/api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private static List<Account> Accountdetails = new List<Account>() { };

        [HttpPost]
        public ActionResult PostAccount(Account account )
        {
            Accountdetails.Add(account);
            return Ok(account);

        }
        [HttpGet]
        public IEnumerable<Account> GetAccountdetails()
        {
            return Accountdetails;
        }



    }
}
