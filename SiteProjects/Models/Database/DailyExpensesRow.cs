using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class DailyExpensesRow
    {
        [Key]
        public int ERowId { get; set; }
        [MaxLength(250)]
        public string Reason { get; set; }
        public string ProductName { get; set; }
        public float Quantity { get; set; }
        public float Price { get; set; }
        public int ImagesId { get; set; }
        public string Description { get; set; }
        public bool IsApporved { get; set; }
       
        public DateOnly ExpenseId { get; set; }
    }
}
