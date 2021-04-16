using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetASPCore.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}