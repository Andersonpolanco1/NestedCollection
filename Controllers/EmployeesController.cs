using Microsoft.AspNetCore.Mvc;
using PruebaAyu.Models;

namespace PruebaAyu.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Index(bool? success)
        {

            if (success == true)
            {
                ViewBag.Message = "Record added";
            }

            if (success == false)
            {
                ViewBag.Message = "Failed to add record";
            }

            var employee = new Employee();
            return View(employee);
        }


        [HttpPost]
        public ActionResult Index(Employee employee)
        {


            return Redirect("~/home/index?success=true");
        }
    }
}
