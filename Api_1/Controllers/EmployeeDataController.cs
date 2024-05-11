using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_10.Controllers
{
    public class EmployeeDataController : ApiController
    {
        string[] employees = { "arbaj", "Akash", "Rupesh", "shailesh" };

        [HttpGet]
        public string[] GetEmployee()
        {
            return employees;
        }

        public string GetEmployeeById( int id )
        {
            return employees[id];
        }
    }
}
