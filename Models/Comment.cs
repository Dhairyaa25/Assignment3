using System.ComponentModel.DataAnnotations;

namespace EcomAssignment3.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string? Text { get; set; }

        public List<User> Users { get; set; }
    }
}
