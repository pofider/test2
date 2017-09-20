using jsreport.Binary;
using jsreport.Local;
using jsreport.MVC;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            filters.Add(new JsReportFilterAttribute(new LocalReporting()
                .UseBinary(JsReportBinary.GetBinary())
                .AsUtility()
                .Create()));
        }
    }
}
