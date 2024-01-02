using BusinessLayer.Interfaces;
using ModelLayer.Models;
using RepositoryLayer.Context;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepo productRepo;
        public ProductBusiness(IProductRepo repo)
        {
            this.productRepo = repo;
        }
        public ProductEntity Product(ProductModel product)
        {
            return productRepo.Product(product);
        }
        public IEnumerable<ProductEntity> DisplayProducts()
        {
            return productRepo.DisplayProducts();
        }
    }
}
