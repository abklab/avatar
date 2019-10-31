using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NEWHIRES.DAL;
using NEWHIRES.Interfaces;

namespace NEWHIRES.Services
{
    public class AddressService : IAddress
    {
        private NHDBContext _context;

        public AddressService(NHDBContext context)
        {
            _context = context;
        }

        public Task<bool> Create(Address entity)
        {
            using (_context)
            {
                _context.Address.AddAsync(entity);
                return Save();
            }
        }

        public Task<bool> Delete(int id)
        {
            using (_context)
            {
                var entity = _context.Address.Find(id);
                _context.Address.Remove(entity);
                return Save();
            }
        }

        public Task<Address> Find(int id)
        {
            using (_context)
            {
                return _context.Address.FindAsync(id);
            }
        }

        public async Task<IEnumerable<Address>> GetAll()
        {
            using (_context)
            {
                return await _context.Address.ToListAsync();
            }
        }

        public Task<Address> GetByAppId(int appid)
        {
            using (_context)
            {
                return _context.Address.FirstOrDefaultAsync(x => x.AppID == appid);
            }
        }

        /// <summary>
        /// Seach Address by given condition
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Address>> Search(Expression<Func<Address, bool>> expression)
        {
            using (_context)
            {
                return await _context.Address.Where(expression).ToListAsync();
            }
        }

        public Task<bool> Update(Address entity)
        {
            using (_context)
            {
                _context.Address.Update(entity);               
                return Save();
            }
        }

        /// <summary>
        /// Persists changes by calling the context.SaveChangesAsync method;
        /// </summary>
        /// <returns>True if successfull</returns>
        private async Task<bool> Save()
        {
            var i = await _context.SaveChangesAsync();
            return i > 0;
        }
    }
}
