
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using TryLogin.Models;
using TryLogin.ServiceReference1;

namespace TryLogin.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(LoginModel model)
        {
            ICUTechClient iCUTechClient = new ICUTechClient();
            var loginDataFromService = await iCUTechClient.LoginAsync(model.UserName, model.Password,string.Empty);
            if(!loginDataFromService.@return.Contains("-1"))
            {
                return View("Success");
            }
            else
            {
                return View("False");
            }
            
        }
        [HttpGet]
        public ActionResult Register()
        {


            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            ICUTechClient iCUTechClient = new ICUTechClient();

            Random rnd = new Random();

            var createRandomCusturem = await iCUTechClient.RegisterNewCustomerAsync(
                model.Email,
                model.Password, 
                model.FirstName,
                model.LastName,
                model.Mobile,
                rnd.Next(20),
                rnd.Next(20),
                string.Empty
                );
           
                return View();
           
        }



    }
}