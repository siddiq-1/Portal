using Microsoft.EntityFrameworkCore;
using Portal.DATA.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.DATA.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        readonly PortalContext _db;
        readonly DbSet<T> _dbEntities; 
        public Repository(PortalContext dbset)
        {
            _db = dbset;
            _dbEntities = _db.Set<T>();
        }

        public async Task<int> Add(T Model)
        {
           _dbEntities.Add(Model);
            var result = await _db.SaveChangesAsync();
            return result;
        }

        public async Task<int> Delete(T Model)
        {
            _dbEntities.Remove(Model);
            var result = await _db.SaveChangesAsync();
            return result;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbEntities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            
           T modelResult = await _dbEntities.FindAsync(id);
            
            if (modelResult == null)
            {
                throw new ArgumentException("Model Not Found");
            }
            return modelResult;
        }

        public async Task<int> Update(T Model)
        {
              _dbEntities.Attach(Model);
            _db.Entry(Model).State = EntityState.Modified;
            var result = await _db.SaveChangesAsync();

            return result;
        }
    }
}
