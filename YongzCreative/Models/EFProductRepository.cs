using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public class EFProductRepository : RepositoryBase<Product>, IProductRepository
    {
        //private AppDbContext _context;        public EFProductRepository(AppDbContext appDbContext)
            : base(appDbContext)
        {
        }    //    public IQueryable<Product> Products => _context.Products;

    //    public IQueryable<Product> Hoodies => _context.Products.Where(p => p.Category.CategoryName == "Hoodie");

    //    public IQueryable<Product> Caps => _context.Products.Where(p => p.Category.CategoryName == "Cap");

    //    public IQueryable<Product> Sweaters => _context.Products.Where(p => p.Category.CategoryName == "Sweater");

    //    public IQueryable<Product> Sweatpants => _context.Products.Where(p => p.Category.CategoryName == "Sweatpants");

    //    public IQueryable<Product> Leggings => _context.Products.Where(p => p.Category.CategoryName == "Leggings");

    //    public IQueryable<Product> TShirts => _context.Products.Where(p => p.Category.CategoryName == "T Shirt");

    //    public Product GetById(int id) => _context.Products.Find(id);
    }
}