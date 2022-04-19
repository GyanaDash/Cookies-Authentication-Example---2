using Cookies_Authentication_2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cookies_Authentication_2.Controllers
{

    public class SecuredController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult ViewEmployeeList()
        {
            Employee emp = new Employee();
            var res = emp.GetEmployees();
            return View(res);
        }
    }
}
