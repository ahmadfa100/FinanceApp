using FinanceApp.Data;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly FinanceAppContext _context;
        public ExpensesController(FinanceAppContext context)
        {
                       _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var expnses = await _context.Expnses.ToListAsync();
            return View(expnses);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Create(Expens Ex)
        {
            if (ModelState.IsValid)
            {
                _context.Expnses.Add(Ex);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(Ex);
        }
    }
}
