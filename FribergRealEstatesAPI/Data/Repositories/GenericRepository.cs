using FribergRealEstatesAPI.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FribergRealEstatesAPI.Data.Repositories
{
    // Made by Samuel
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApiDbContext _context;

        public GenericRepository(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if(entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);
        

        public async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
