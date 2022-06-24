using Careo_Back.DAL;
using Careo_Back.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Careo_Back.Areas.Manaje.Controllers
{
    [Area("Manaje")]
    public class FeedBackController : Controller
    {
        private readonly AppDbContext _context;

        public FeedBackController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.FeedBacks.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Create(FeedBack feedBack)
        {
            if (feedBack is null) return NotFound();
            _context.FeedBacks.Add(feedBack);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult Edit(int? id)
        //{
        //    FeedBack feedBack = _context.FeedBacks
        //}
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
