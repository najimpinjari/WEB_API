using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.net_web_api_.Controllers
{
    public class EmployeeDataController : ApiController
    {
        public string[] myEmployee = { "Arbaj", "Rupesh", "Shailesh", "Najim" };

        [HttpGet]
        public string[] GetEmployee()
        {
            return myEmployee;
        }

        [HttpGet]
        public string GetEmployeeByIndex( int Id)
        {
            return myEmployee[Id];
        }
    }
}
