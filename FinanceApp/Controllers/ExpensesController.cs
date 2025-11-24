using FinanceApp.Data;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly FinanceAppContext _context;
        public ExpensesController(FinanceAppContext context)
        {
                       _context = context;
        }


        public IActionResult Index()
        {
            var expnses = _context.Expnses.ToList();
            return View(expnses);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Expens Ex)
        {
            if (ModelState.IsValid)
            {
                _context.Expnses.Add(Ex);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Ex);
        }
    }
}
