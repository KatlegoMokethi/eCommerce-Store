using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public class EFProductRepository : IProductRepository
    {
        private AppDbContext _context;        public EFProductRepository(AppDbContext context)        {            _context = context;        }        public IQueryable<Product> Products => _context.Products;

        public IQueryable<Product> Hoodies => _context.Products.Where(p => p.category == Category.Hoodie);

        public IQueryable<Product> Caps => _context.Products.Where(p => p.category == Category.Cap);

        public IQueryable<Product> Sweaters => _context.Products.Where(p => p.category == Category.Sweater);

        public IQueryable<Product> Sweatpants => _context.Products.Where(p => p.category == Category.Sweatpants);

        public IQueryable<Product> Leggings => _context.Products.Where(p => p.category == Category.Leggings);

        public IQueryable<Product> TShirts => _context.Products.Where(p => p.category == Category.T_Shirt);

        public Product GetById(int id) => _context.Products.Find(id);
    }
}