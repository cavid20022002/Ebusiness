using eBusinessTemplate.DAL;
using eBusinessTemplate.Models;
using eBusinessTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBusinessTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Blog> blogs=await _context.Blogs.ToListAsync();
            List<CustomService> customServices=await _context.CustomServices.ToListAsync();
            List<TeamMember> tmember = await _context.TeamMembers.ToListAsync();

            HomeVM homeVM = new HomeVM()
            {
                CustomServices=customServices,
                TeamMembers=tmember,
                Blogs=blogs

            };


            return View(homeVM);
        }
    }
}
