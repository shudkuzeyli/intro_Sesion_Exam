using System.Diagnostics;
using System.Text.Json;
using intro_Sesion_Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace intro_Sesion_Exam.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			//Session a ulaþma
			var sessionUser = HttpContext.Session.GetString("userJson");
			if (string.IsNullOrWhiteSpace(sessionUser))
			{
				return RedirectToAction(nameof(Index), "Login");
			}

			var girisYapanKullanici = JsonSerializer.Deserialize<UserModel>(sessionUser);

			//ViewBag.girisYapanKullaniciAdi = girisYapanKullanici.Name;


			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
