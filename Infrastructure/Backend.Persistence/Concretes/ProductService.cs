using Backend.Application.Abstraction;
using Backend.Domain.Entities;
using Backend.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        private readonly PsqlDbContext _psqlDbContext;
        public ProductService(PsqlDbContext psqlDbContext)
        {
            _psqlDbContext = psqlDbContext;
        }
        public List<Product> GetProducts() 
        {
            var result = _psqlDbContext.Products.ToList();
            return result;
        }
        public Product GetProductById(string id) 
        {
            Product product;
            try {
                product = _psqlDbContext.Products.Where(x => x.Id == Guid.Parse(id)).First();
            }
            catch(Exception e) {
                product = new Product();
            }
            
            return product;

        }
    }
}
