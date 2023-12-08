using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    // class => can be reference typce || generic constrains.
    // The margin of error has been minimized by introducing constrains to prevent spelling errors in the value substituted for T.

    public interface IEntityRepository<T> where T:class, IEntity, new()
        // classes can be new() but interfaces are not. So, we can use constrains like that to prevent using the interfaces.
    {
        //general entity
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
