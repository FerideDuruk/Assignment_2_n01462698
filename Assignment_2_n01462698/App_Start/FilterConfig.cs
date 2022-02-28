using System.Web;
using System.Web.Mvc;

namespace Assignment_2_n01462698
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
