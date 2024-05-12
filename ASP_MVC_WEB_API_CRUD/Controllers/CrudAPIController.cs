using ASP_MVC_WEB_API_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace ASP_MVC_WEB_API_CRUD.Controllers
{
    public class CrudAPIController : ApiController
    {
        WEB_API_crudDBEntities db = new WEB_API_crudDBEntities();

        [HttpGet]
        public IHttpActionResult GetEmployee()
        {
            List<Employee> List = db.Employees.ToList();
            return Ok(List);
        }

        [HttpPost]
        public IHttpActionResult EmpInsert( Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();   

            return Ok();
        }
    }
}
