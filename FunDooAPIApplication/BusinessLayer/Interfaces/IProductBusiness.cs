using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    public interface IProductBusiness
    {
        ProductEntity Product(ProductModel product);
        IEnumerable<ProductEntity> DisplayProducts();
    }
}