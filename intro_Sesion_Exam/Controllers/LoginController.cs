using intro_Sesion_Exam.Context;
using intro_Sesion_Exam.Dtos;
using intro_Sesion_Exam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace intro_Sesion_Exam.Controllers
{
	public class LoginController : Controller
	{
		private readonly DataContext _dataContext;
		public LoginController(Context.DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]

		public IActionResult Index(UserDto model)
		{
			//1. kullanım şekli. Direk modelin kendisi kullanıldı.
			//var kullanici = _dataContext.UserModel.Where(t => t.UserName == model.UserName && t.Password == model.Password).FirstOrDefault();
			//if (kullanici == null)

			//{
			//	ModelState.AddModelError(nameof(UserModel.UserName), "Kullanıcı İsmi veya Şifre Hatalı");
			//	return View(model);
			//}

			var kullanici = _dataContext.UserModel.Where(t => t.UserName == model.UserName && t.Password == model.Password).FirstOrDefault();
			if (kullanici == null)

			{
				ModelState.AddModelError(nameof(UserModel.UserName), "Kullanıcı İsmi veya Şifre Hatalı");
				return View(model);
			}

			var userJson = JsonSerializer.Serialize<UserModel>(kullanici);
			HttpContext.Session.SetString("userJson", userJson);

			//1. yol - string değişken oalrak veriyi taşıma
			//HttpContext.Session.SetString("user", $"{kullanici.Name} {kullanici.Surname}");

			//return RedirectToAction("Index", new RouteValueDictionary(new { Controller = "UserModel", action = "Index", id = model.Id }));
			//return RedirectToAction(nameof(Index));
			return RedirectToAction(nameof(Index), "Home");

		}
	}
}
