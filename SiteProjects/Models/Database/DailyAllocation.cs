using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class DailyAllocation
    {
        [Key]
        public int AllotId { get; set; }
        [MaxLength(200)]
        public float AllocationAmount { get; set; }
        [MaxLength(200)]
        public DateTime AllocationDate { get; set; }
        [MaxLength(200)]
        public DateTime ActionDate { get; set; }
        public bool IsActive { get; set; }
    }
}
