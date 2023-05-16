using AllUp.DAL;
using AllUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AllUp.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _Db;
        public HomeController(AppDbContext Db)
        {
			_Db = Db;
        }


        public async Task<IActionResult> Index()
		{
			return View(await _Db.Categories.ToListAsync());
		}

		
		public IActionResult Error()
		{
			return View();
		}
	}
}