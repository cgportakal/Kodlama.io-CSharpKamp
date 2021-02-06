using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Dal=Data Access Layer
    /// Product nesnesinin Veri Erişim Katmanını işlemlerinin yapılacağı yer.
    /// </summary>
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
//Code Refactoring