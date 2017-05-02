using MyEcommerce.Domain.Entities;
using System.Linq;

namespace MyEcommerce.Domain.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
