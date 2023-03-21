using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<int> Add(T Model);
        Task<int> Update(T Model);
        Task<int> Delete(T Model);
    }
}
