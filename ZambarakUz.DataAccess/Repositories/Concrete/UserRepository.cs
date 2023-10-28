using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZambarakUz.DataAccess.Context;
using ZambarakUz.DataAccess.Repositories.Abstract;
using ZambarakUz.Model.DTOs;
using AutoMapper;

namespace ZambarakUz.DataAccess.Repositories.Concrete
{
    public class UserRepository : IRepository<UserDTO> // IRepository<UserDTO> kullanıyoruz
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetAll() // Dönüş türünü UserDTO olarak değiştiriyoruz
        {
            var users = await _context.USERS.ToListAsync();
            var userDTOs = _mapper.Map<List<UserDTO>>(users);

            return userDTOs;
        }

        public async Task<UserDTO> GetById(Guid id) // Dönüş türünü UserDTO olarak değiştiriyoruz
        {
            var user = await _context.USERS.FindAsync(id);

            if (user == null)
            {
                return null;
            }

            var userDTO = _mapper.Map<UserDTO>(user);

            return userDTO;
        }

        public void Add(UserDTO entity) // Kullanılmayan metotları kaldırabilirsiniz
        {
            
        }

        public void Update(UserDTO entity) // Kullanılmayan metotları kaldırabilirsiniz
        {
            // Güncelleme işlemini burada gerçekleştirin.
        }

        public void Delete(UserDTO entity) // Kullanılmayan metotları kaldırabilirsiniz
        {
            // Silme işlemini burada gerçekleştirin.
        }
    }
}

