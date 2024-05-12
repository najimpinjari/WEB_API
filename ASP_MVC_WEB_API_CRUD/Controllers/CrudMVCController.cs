using ASP_MVC_WEB_API_CRUD.Models;
using Newtonsoft.Json; // Make sure you have Newtonsoft.Json package installed via NuGet
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ASP_MVC_WEB_API_CRUD.Controllers
{
    public class CrudMVCController : Controller
    {
        HttpClient client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            List<Employee> emp_list = new List<Employee>();
            client.BaseAddress = new Uri("http://localhost:52712/api/CrudAPI");

            var response = await client.GetAsync("CrudAPI");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                emp_list = JsonConvert.DeserializeObject<List<Employee>>(content);
            }

            return View(emp_list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create( Employee emp)
        {
            client.BaseAddress = new Uri("http://localhost:52712/api/CrudAPI");

            var response = client.PostAsJsonAsync<Employee>("CrudAPI",emp);
            response.Wait();


            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Create");
        }
    }
}
