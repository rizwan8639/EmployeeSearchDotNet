using EmpSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace EmpSearch.Controllers
{
    public class EmployeeController : ApiController
    {

        public EmployeeController()
        {

        }

        [System.Web.Http.HttpGet()]
        public IHttpActionResult GetSearch(string search)
        {

            using (var ctx = new EmpContext())
            {

                IQueryable<Employee> query = ctx.Employees;

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(e => e.EmpName.Contains(search)
                            || e.EmpCode.Contains(search));
                    
                    if(query.Count() <1)
                    {
                        query = ctx.Employees;
                    }
                }
                return Ok(query.ToList<Employee>());
            }

        }
    }
}
