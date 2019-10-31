using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using NEWHIRES.DAL;
using NEWHIRES.Interfaces;

namespace NEWHIRES.Services
{
    public class DriversLicenseService : IDriversLicense
    {
        private NHDBContext _context;

        public DriversLicenseService(NHDBContext context)
        {
            _context = context;
        }
        public Task<bool> Create(DriversLicense entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<DriversLicense> Find(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DriversLicense>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DriversLicense> GetByAppId(int appid)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DriversLicense>> Search(Expression<Func<DriversLicense, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(DriversLicense entity)
        {
            throw new NotImplementedException();
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
