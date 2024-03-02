using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class salary
    {
        [Key]
        public int SalID { get; set; }
        public float BasicSalary { get; set; }
        public float GrossSalary { get; set; }
        public float Deduction { get; set; }

    }
}
