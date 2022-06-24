using Careo_Back.DAL;
using Careo_Back.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Careo_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        // GET: HomeController
        public ActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                FeedBacks= _context.FeedBacks.Where(f=>f.IsDeleted==false).ToList()
            };
            return View(homeVM);
        }

        
    }
}
