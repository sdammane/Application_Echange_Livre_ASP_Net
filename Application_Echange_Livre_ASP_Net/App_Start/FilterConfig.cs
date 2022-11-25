using System.Web;
using System.Web.Mvc;

namespace Application_Echange_Livre_ASP_Net
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
