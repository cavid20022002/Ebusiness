using eBusinessTemplate.DAL;
using eBusinessTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBusinessTemplate.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
           _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog>blogs=await _context.Blogs.ToListAsync();
            return View(blogs);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (blog.Photo==null)
            {
                ModelState.AddModelError("Photo", "Sekil bos gonderile bilmez");
                return View();

            }

           RedirectToAction(nameof(Index));
            
            

        }
        public async Task<IActionResult> Create(Blog blog)
        {
            if (blog.Photo == null)
            {
                ModelState.AddModelError("Photo", "Sekil bos gonderile bilmez");
                return View();

            }

            RedirectToAction(nameof(Index));



        }


    }
}
