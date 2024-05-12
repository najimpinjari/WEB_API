using System.Web;
using System.Web.Mvc;

namespace ASP_MVC_WEB_API_CRUD
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
