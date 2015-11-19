using System.IO;
using System.Web.Mvc;
using System.Web.WebPages;
using RazorGeneratorTest.Views.Test;

namespace RazorGeneratorTest.Controllers
{
	public class TestController : Controller
	{
		// GET: Test
		public ActionResult Standard()
		{
			return View(model: "green");
		}

		public ActionResult MvcView()
		{
			var view = new Standard {ViewData = {Model = "red"}};
			view.PushContext(new WebPageContext(), new StringWriter());
			view.Execute();
			var result = view.Output.ToString();
			view.PopContext();
			return Content(result);
		}

		public ActionResult Helper()
		{
			return View(model: "green");
		}
	}
}