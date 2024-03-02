using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class MasterSiteSetup
    {
        [Key]
        public int SiteId { get; set; }
        [MaxLength(100)]
        public string SiteName { get; set; }
        public string SiteLocation { get; set; }
        public DateTime WorkStartDate { get; set; }
        public DateTime WorkEndDate { get; set; }


    }
}
