using System.Web;
using System.Web.Mvc;

namespace DiegoSuarez_SyncView
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}