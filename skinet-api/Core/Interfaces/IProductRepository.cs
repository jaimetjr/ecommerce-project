using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductById(int id);
       
        // ReadOnlyList is a specific type of list 
        // as the name suggest is a read only type
        Task<IReadOnlyList<Product>> GetProducts();
    }
}
