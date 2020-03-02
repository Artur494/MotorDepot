using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MotorDepot.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //TODO ���������� ��� ��������� �� ���� � ������� ������� � ������
        //TODO ���������� ��� ��� ValidationErrors � OperationStatus
        //TODO ���������� �� �������
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
