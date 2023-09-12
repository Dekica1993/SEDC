using TaxiManagerApp9000.Domain.Entities;

namespace TaxiManagerApp9000.DataAccess
{
    public interface Idb<T> where T : BaseEntity
    {
        int Add(T entity);

        bool RemoveById(int id);

        bool Update(T entity);

        List<T> GetAll();

        T GetById(int id);

    }
}


    
