using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xurmo.Data.IRepastories;
using Xurmo.Domain.Entities;
using Xurmo.Models.Products;
using Xurmo.Service.Interfaces;

namespace Xurmo.Service.Services;

public class ProductService : IPoductService
{
    private readonly IRepository<Product> repository;

    public ProductService(IRepository<Product> repository)
    {
        this.repository = repository;
    }

    public Task<ProductViewModel> CreateAsync(ProductCreateModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductViewModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductViewModel> UpdateAsync(long id, ProductUpdateModel model)
    {
        throw new NotImplementedException();
    }
}
