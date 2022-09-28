using EmpSearch.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(string searchItem)
        {
            IEnumerable<Employee> employees = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44304/api/");
                //HTTP GET
                var responseTask = client.GetAsync("employee?name=" + searchItem);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {

                    var emp = result.Content.ReadAsStringAsync().Result;
                    employees = JsonConvert.DeserializeObject<IList<Employee>>(emp);

                }
                else //web api sent error response 
                {
                    //log response status here..

                    employees = Enumerable.Empty<Employee>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(employees);
        }

        [HttpPost]
        public ActionResult Search(string searchItem)
        {
            return RedirectToAction("Index", "Employee", new { searchItem = searchItem });
        }
    }
}