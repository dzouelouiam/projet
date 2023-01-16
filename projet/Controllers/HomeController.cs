using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projet.Data;
using projet.Models;

namespace projet.Views
{
    public class HomeController : Controller
    {

        private readonly projetContext _context;

        public HomeController(projetContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Hotel.ToListAsync());
        }

        // GET: Hotels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.Id == id);

            var reviews = await _context.Reviews.Where(e => e.HotelId == id).ToListAsync();

            Console.WriteLine(reviews.GetType());
            var model = (hotel, reviews);
            Console.WriteLine(model.GetType());

            if (hotel == null)
            {
                return NotFound();
            }

            return View(model);
        }

    }
}
