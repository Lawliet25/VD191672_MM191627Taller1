using System.Web;
using System.Web.Mvc;

namespace VD191672_MM191627Taller1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
