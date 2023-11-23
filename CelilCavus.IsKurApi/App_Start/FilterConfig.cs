using System.Web;
using System.Web.Mvc;

namespace CelilCavus.IsKurApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
