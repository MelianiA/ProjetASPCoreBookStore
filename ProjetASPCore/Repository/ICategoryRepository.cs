using ProjetASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetASPCore
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategory();
        Category GetCategoryById(int id);

    }
}
