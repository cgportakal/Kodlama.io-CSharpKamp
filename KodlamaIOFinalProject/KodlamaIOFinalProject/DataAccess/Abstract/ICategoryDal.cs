using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Dal=Data Access Layer
    /// Category nesnesinin Veri Erişim Katmanını işlemlerinin yapılacağı yer.
    /// </summary>
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
