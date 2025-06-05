using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartInventory.Data.Models;

namespace SmartInventory.Data.Interfaces
{
    public  interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
