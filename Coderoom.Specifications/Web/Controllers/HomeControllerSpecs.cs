using System.Web.Mvc;
using Coderoom.Web.Controllers;
using Machine.Specifications;

namespace Coderoom.Specifications.Web.Controllers
{
	public class HomeControllerSpecs
	{
		public class when_home_page_is_requested
		{
			private static ActionResult result;

			Because of = () => result = new HomeController().Index();

			It should_display_home_page = () => result.ShouldNotBeNull();
		} 
	}
}