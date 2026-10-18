using System.Web;
using System.Web.Mvc;

namespace Carlos_Mendoza_Parcial1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
