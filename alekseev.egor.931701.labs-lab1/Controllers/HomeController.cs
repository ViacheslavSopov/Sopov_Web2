using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
using Lab1.ViewModels;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult PassUsingModel()
		{
			LabModel model = Calculate();

			return View(model);
		}

		public IActionResult PassUsingViewData()
		{
			ViewData["data"] = Calculate();

			return View();
		}

		public IActionResult PassUsingViewBag()
		{
			ViewBag.data = Calculate();

			return View();
		}

		public IActionResult PassUsingService()
		{
			return View();
		}

		public LabModel Calculate()
		{
			Random rnd = new Random(DateTime.Now.Millisecond);
			(var first, var second) = (rnd.Next() % 10, rnd.Next() % 10);

			int divResult;
			try
			{
				divResult = first / second;
			}
			catch (DivideByZeroException)
			{
				divResult = -1;
			}

			return new LabModel
			{
				firstRndNum = first,
				secondRndNum = second,
				sumResult = first + second,
				subResult = first - second,
				divResult = divResult,
				mulResult = first * second
			};
		}



		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
