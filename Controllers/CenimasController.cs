using eCommerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Controllers
{
    public class CenimasController : Controller
    {
        private readonly AppDbContext _context;
        public CenimasController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCenimas = await _context.Cenimas.ToListAsync();
            return View();
        }
    }
}
