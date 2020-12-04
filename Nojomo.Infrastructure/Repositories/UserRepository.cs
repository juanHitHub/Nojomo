using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Models;
using Nojomo.Core.Entities;
using Nojomo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Nojomo.Infrastructure.Repositories
{
   public class UserRepository:IUserRepository
    {
        private readonly nojomoContext _context;
       

        public UserRepository(nojomoContext context)
        {
            _context = context;
          
        }
        public async Task<IEnumerable<Usuario>> GetUsers()
        {
            var users = await _context.Usuarios.ToListAsync();

            return (IEnumerable<Usuario>)users;
        }

        public async Task<Usuario> GetUser(int id)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x=>x.Id==id);

            return user;
        }

        public async Task<bool> InsertUser(Usuario user)
        {
            try
            {
                _context.Usuarios.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (System.Exception)
            {

                return false;
            }
           
        }

        public async Task DeleteUser(int id)
        {

          var user= await _context.Usuarios.FindAsync(id);
                    _context.Usuarios.Remove(user);
                    await _context.SaveChangesAsync();
        }

        public async Task UpdateUser(int id,Usuario user)
        {
                   user.Id = id;
                  _context.Usuarios.Update(user);
            await _context.SaveChangesAsync();

        }

       
    }
}
