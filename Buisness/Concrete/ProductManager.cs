using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Buisness.Abstract;
using Core.Entity.Messages;
using Core.Entity.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Buisness.Concrete
{
    public class ProductManager : IProductService

    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public IDataResult<Product> Get(int productId)
        {
            return new SuccesDataResult<Product>(_productDal.Get(x => x.ProductId == productId)) ;
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetList().ToList()) ;
        }

        public IDataResult<List<Product>> GetByCategory(int categoryId)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetList(x => x.CategoryId == categoryId).ToList()) ;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.Deleted);
        }
    }
}
