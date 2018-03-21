using System.Web;
using System.Web.Mvc;

namespace BrnoMvc1.WebWithoutAuthetication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
