using System.Web;
using System.Web.Mvc;

namespace BE_MyStore_25DH110986
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
