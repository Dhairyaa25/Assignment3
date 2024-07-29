using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EcomAssignment3.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public List<Product> Products { get; set; }
    }
}
