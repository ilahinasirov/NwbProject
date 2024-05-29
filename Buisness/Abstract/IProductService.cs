using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity.Results;
using Entities.Concrete;

namespace Buisness.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> Get(int productId);
        IDataResult<List<Product>>  GetList();
        IDataResult<List<Product>> GetByCategory(int categoryId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IResult SoftDelete(int  productId);

    }
}
