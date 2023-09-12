using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManagerApp9000.Domain.Entities;

namespace TaxiManagerApp9000.Services.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        bool Add(T entity);
        bool Remove(int id);
        T GetById(int id);
        List<T> GetAll();
    }
}
