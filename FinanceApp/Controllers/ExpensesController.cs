using FinanceApp.Data;
using FinanceApp.Data.services;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpenseService _ExpenseService;
        public ExpensesController(IExpenseService ExpenseService)
        {
            _ExpenseService = ExpenseService;
        }


        public async Task<IActionResult> Index()
        {
            var expnses = await _ExpenseService.GetAll();
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
                await _ExpenseService.Add(Ex);
                return RedirectToAction("Index");
            }
            return View(Ex);
        }
    }
}
