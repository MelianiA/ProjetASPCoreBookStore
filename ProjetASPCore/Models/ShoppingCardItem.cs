using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ShoppingCartItemId { get; set; }
        public Book Book { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartSessionId { get; set; }
    }
}
