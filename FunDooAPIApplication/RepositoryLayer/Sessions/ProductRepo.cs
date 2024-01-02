using Microsoft.EntityFrameworkCore.Query;
using ModelLayer.Models;
using RepositoryLayer.Context;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace RepositoryLayer.Sessions
{
    public class ProductRepo : IProductRepo
    {
        private readonly FunDooContext funDooContext;
        public ProductRepo(FunDooContext funDooContext)
        {
            this.funDooContext = funDooContext;
        }

        public ProductEntity Product(ProductModel product)
        {

            ProductEntity productEntity = new ProductEntity();
            productEntity.ProductName = product.ProductName;
            productEntity.Brand = product.Brand;
            productEntity.price = product.price;
            productEntity.quantity = product.quantity;
            funDooContext.Product.Add(productEntity);
            funDooContext.SaveChanges();
            return productEntity;
        }

        public IEnumerable<ProductEntity> DisplayProducts()
        {
            if(funDooContext.Product == null)
            {
                return null;
            }
            return funDooContext.Product.ToList();
        }



    }
}
