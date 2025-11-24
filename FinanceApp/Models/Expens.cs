using System.ComponentModel.DataAnnotations;
namespace FinanceApp.Models
{
    public class Expens
    {
        public int Id { get; set; }
        
        [Required (ErrorMessage ="Enter the description please")] 
        public string Description { get; set; } = null;
        
        [Required]
        [Range(0.01 , double.MaxValue, ErrorMessage = "amount must be highr than 0.00")]
        public double Amount { get; set; }
        
        [Required]
        public string Catogry { get; set; } = null;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
