using intro_Sesion_Exam.Context;
using intro_Sesion_Exam.Models;
using Microsoft.AspNetCore.Mvc;

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

		public IActionResult Index(UserModel model)
		{

		var kullanici = _dataContext.UserModel.Where(t=> t.UserName == model.UserName && t.Password == model.Password).FirstOrDefault();
			if (kullanici == null)

			{
				ModelState.AddModelError(nameof(UserModel.UserName), "Kullanıcı İsmi veya Şifre Hatalı");
				return View(model);
			}

			//return RedirectToAction("Index", new RouteValueDictionary(new { Controller = "UserModel", action = "Index", id = model.Id }));
			//return RedirectToAction(nameof(Index));
			return RedirectToAction(nameof(Index), "Home");

		}
	}
}
