using Microsoft.EntityFrameworkCore;
using ZambarakUz.DataAccess.Context; // Veritabanı bağlamınızın namespace'i
using ZambarakUz.DataAccess.Entites;
using ZambarakUz.DataAccess.Repositories.Abstract;

namespace ZambarakUz.DataAccess.Repositories.Concrete
{
    public class UserGroupRepository : IRepository<UserGroup>
    {
        private readonly ApplicationDbContext _context;

        public UserGroupRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserGroup>> GetAll()
        {
            return await _context.USERS_GROUPS.ToListAsync();
        }

        public async Task<UserGroup> GetById(Guid id)
        {
            return await _context.USERS_GROUPS.FindAsync(id);
        }

        public void Add(UserGroup entity)
        {
            _context.USERS_GROUPS.Add(entity);
        }

        public void Update(UserGroup entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(UserGroup entity)
        {
            _context.USERS_GROUPS.Remove(entity);
        }
    }
}
