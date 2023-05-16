using AllUp.DAL;
using AllUp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUp.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _Db;
        public CategoriesController(AppDbContext db)
        {
            _Db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _Db.Categories.Include(x=>x.Children).Include(x=>x.Parent).ToListAsync();
                return View(categories);
        }
    }
}
