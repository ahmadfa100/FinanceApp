using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.services
{
    public class ExpenseService : IExpenseService
    {
        private readonly FinanceAppContext _context;

        public ExpenseService (FinanceAppContext context)
        {
            _context = context;
        }

        public async Task Add(Expens expense)
        {
            _context.Add(expense);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Expens>> GetAll()
        {
           var expnses = await _context.Expnses.ToListAsync();
            return expnses;
        }
    }
}
