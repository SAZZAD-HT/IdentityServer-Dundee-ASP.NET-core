using System.ComponentModel.DataAnnotations;

namespace SiteProjects.Models.Database
{
    public class User
    {
        [Key]     
        public int ID { get; set; }
        [MaxLength(250)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Password { get; set; }
    }
}
