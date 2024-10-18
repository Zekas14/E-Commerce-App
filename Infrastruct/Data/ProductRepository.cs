using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastruct.Data
{
    public class ProductRepository(StoreContext context) : IProductRepository
    {
        private readonly StoreContext context = context;
        public async Task<IReadOnlyList<Product>> GetAllProductsAsync()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
            return await context.Products.FindAsync(id);
        }
    }
}
