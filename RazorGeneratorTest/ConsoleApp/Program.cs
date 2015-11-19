using System;
using System.IO;
using System.Web.Mvc;
using System.Web.WebPages;
using RazorGeneratorTest.Views.Test;

namespace ConsoleApp
{
	static class Program
	{
		static void Main()
		{
			PrintView();
			PrintHelper();
		}

		private static void PrintHtml(WebViewPage<string> view, string color)
		{
			try
			{
				view.ViewData.Model = color;
				view.PushContext(new WebPageContext(), new StringWriter());
				view.Execute();
				Console.Out.WriteLine(view.Output.ToString());
				view.PopContext();
			}
			catch (Exception ex)
			{
				Console.Out.WriteLine(ex.ToString());
			}
		}

		private static void PrintView()
		{
			PrintHtml(new Standard(), "green");
		}

		private static void PrintHelper()
		{
			PrintHtml(new Helper(), "red");
		}
	}
}
