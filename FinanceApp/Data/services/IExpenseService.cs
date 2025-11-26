using FinanceApp.Models;

namespace FinanceApp.Data.services
{
    public interface IExpenseService
    {
        Task<IEnumerable<Expens>> GetAll();
        Task Add(Expens expese);
    }
}
