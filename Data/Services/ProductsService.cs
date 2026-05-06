using Sporta.Data.Base;
using Sporta.Data.ViewModels;
using Sporta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Linq;

namespace Sporta.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewProductAsync(NewProductVM data)
        {
            var newProduct = new Product()
            {
                Name = data.Name,
                ProductCategory = data.ProductCategory,
                Price = data.Price,
                Description = data.Description,
                Color = data.Color,
                Style = data.Style,
                Picture1 = data.Picture1,
                Picture2 = data.Picture2,
                Picture3 = data.Picture3,
                Picture4 = data.Picture4,
                Picture5 = data.Picture5,
                Picture6 = data.Picture6,
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var productDetails = await _context.Products
                .FirstOrDefaultAsync(n => n.Id == id);

            return productDetails;
        }

        public async Task UpdateProductAsync(NewProductVM data)
        {
            var dbProduct = await _context.Products.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbProduct != null)
            {
                dbProduct.Name = data.Name;
                dbProduct.ProductCategory = data.ProductCategory;
                dbProduct.Price = data.Price;
                dbProduct.Description = data.Description;
                dbProduct.Color = data.Color;
                dbProduct.Style = data.Style;
                dbProduct.Picture1 = data.Picture1;
                dbProduct.Picture2 = data.Picture2;
                dbProduct.Picture3 = data.Picture3;
                dbProduct.Picture4 = data.Picture4;
                dbProduct.Picture5 = data.Picture5;
                dbProduct.Picture6 = data.Picture6;
                await _context.SaveChangesAsync();
            }
        }
    }
}
