using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManagerApp9000.Domain.Entities;

namespace TaxiManagerApp9000.DataAccess.Interfaces
{
    public interface IDb<T> where T : BaseEntity
    {
        int Add(T entity);
        bool RemoveById(int id);
        bool Update(T entity);
        List<T> GetAll();
        T GetById(int id);


    }
}
