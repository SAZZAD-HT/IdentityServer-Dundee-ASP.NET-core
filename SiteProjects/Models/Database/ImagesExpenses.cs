using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace SiteProjects.Models.Database
{
    public class ImagesExpenses
    {
        [Key]
        public int ImageId { get; set; }
        public byte[] Image { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
