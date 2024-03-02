using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class MasterDesigination
    {
        [Key]
        public int DesiginationId { get; set; }
        [MaxLength(50)]
        public string DesiginationName { get; set; }
        [MaxLength(100)]
        public string DesiginationType { get; set; }
        public bool IsActive { get; set; }

    }
}
