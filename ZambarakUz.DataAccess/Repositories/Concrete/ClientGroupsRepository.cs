using ZambarakUz.DataAccess.Entities;
using ZambarakUz.DataAccess.Repositories.Abstract;

namespace ZambarakUz.DataAccess.Repositories.Concrete
{
    public class ClientGroupsRepository : IRepository<ClientGroup>
    {
        public void Add(ClientGroup entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ClientGroup entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClientGroup>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ClientGroup> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(ClientGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
