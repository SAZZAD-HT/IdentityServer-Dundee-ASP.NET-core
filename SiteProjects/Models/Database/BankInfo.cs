using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class BankInfo
    {
        [Key]
        public int InfId { get; set; }
        [MaxLength(200)]
        public string BankAccountNumber { get; set; }
        [MaxLength(200)]
        public string Branch { get; set; }
        [MaxLength(200)]
        public string InfBranchId { get; set; }
    }
}
