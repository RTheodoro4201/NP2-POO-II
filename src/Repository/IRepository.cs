using System.Collections.Generic;
using System.Threading.Tasks;

namespace POO_II_NP2_WinForms.Repository;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int id);
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(int id);
}