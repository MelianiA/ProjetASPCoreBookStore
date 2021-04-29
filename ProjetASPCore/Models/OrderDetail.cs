using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetASPCore.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int BookId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Book Book { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
