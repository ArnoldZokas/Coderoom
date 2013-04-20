using System.Web.Routing;
using Coderoom.Web;
using Machine.Specifications;

namespace Coderoom.Specifications.Web
{
	public class ApplicationSpecs
	{
		 public class when_application_starts
		 {
			 Because of = () => new Application().Application_Start();

			 It should_map_routes = () => RouteTable.Routes.Count.ShouldBeGreaterThan(0);
		 }
	}
}