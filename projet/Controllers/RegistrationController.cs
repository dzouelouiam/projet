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
    public class RegistrationController : Controller
    {
        private readonly projetContext _context;

        public RegistrationController(projetContext context)
        {
            _context = context;
        }

        // GET: Hotels
        public IActionResult Index()
        {

            return RedirectToAction("LoginPage", "Registration");

        }

        [NoLayout]
        [HttpGet]
        public IActionResult LoginPage()
        {
            return View();

        }

        [NoLayout]
        [HttpPost]
        public async Task<IActionResult> LoginPage(Users user)
        {
            Console.WriteLine(user);
            if (ModelState.IsValid)
            {
                Console.WriteLine("valid");

                var users = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
                

                if (users == null)
                {
                    return NotFound();
                }

                if(users.IsAdmin == true)
                {
                    return RedirectToAction("Index", "Hotels");
                }

                return RedirectToAction("Index", "Home");

            }

            return View();

        }

    }
}
