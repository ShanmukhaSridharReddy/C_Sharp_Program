using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using System.Collections.Generic;

namespace RepositoryLayer.Interfaces
{
    public interface IProductRepo
    {
        ProductEntity Product(ProductModel product);
        IEnumerable<ProductEntity> DisplayProducts();
    }
}