using ProjetASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetASPCore.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
