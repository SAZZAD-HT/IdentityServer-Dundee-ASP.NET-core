using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class DailyExpensesHeader
    {
        [Key]
        public int ExpenseId { get; set; }
        [MaxLength(50)]
        public string ExpenseType { get; set; }
        public float TotalPrice { get; set; }
        public int EmpId { get; set; }
        public DateOnly ExpenseDate { get; set; }
    }
}
