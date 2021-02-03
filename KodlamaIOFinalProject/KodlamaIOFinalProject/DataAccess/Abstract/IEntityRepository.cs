using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Generic Constraint
    /// where T: bir Class olabilir
    /// IEntity: IEntity olabilir ve IEntity implemente eden bir nesne olabilir.
    /// </summary>
    public interface IEntityRepository<T> where T : class, IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);// Önemli ve ileri seviye kod
        T Get(Expression<Func<T, bool>> filter);
        //Üstteki iki kod filtre kullanabilmemize olanak tanıyor.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId);//Ürünleri kategoriye göre filtreleyen kod.
        //Üstteki kodu iptal ettik.
    }
}
