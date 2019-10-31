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
    public class ApplicationInfoServices : IApplicationInfo
    {
        private NHDBContext _context;

        /// <summary>
        /// Constructor injection
        /// </summary>
        /// <param name="context"></param>
        public ApplicationInfoServices(NHDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Get applicationInfo by id=appid
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<ApplicationInfo> Find(int id)
        {
            using (_context)
            {
                return _context.ApplicationInfo.FindAsync(id);
            }
        }

        /// <summary>
        /// Get applicationInfo by appid
        /// </summary>
        /// <param name="AppID"></param>
        /// <returns></returns>
        public Task<ApplicationInfo> FindByAppId(int appid)
        {
            using (_context)
            { return _context.ApplicationInfo.FindAsync(appid); }
        }

        /// <summary>
        /// Get All Applications
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ApplicationInfo>> GetAll()
        {
            using (_context)
            {
                return await _context.ApplicationInfo.ToListAsync();
            }
        }

        /// <summary>
        /// Search application
        /// </summary>
        /// <param name="expression">expression to search</param>
        /// <returns></returns>
        public async Task<IEnumerable<ApplicationInfo>> Search(Expression<Func<ApplicationInfo, bool>> expression)
        {
            using (_context)
            { return await _context.ApplicationInfo.Where(expression).ToListAsync(); }
        }

        /// <summary>
        /// Remove Application by ID. This will remove all other entries associated with the selected application.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> Delete(int id)
        {
            using (_context)
            {
                var itemToDelete = _context.ApplicationInfo.Find(id);
                return Save();
            }
        }

        public Task<bool> Update(ApplicationInfo entity)
        {
            //var itemToUpdate =await _context.ApplicationInfo.FindAsync(entity.AppID);
            using (_context)
            {
                _context.ApplicationInfo.Update(entity);
                return Save();
            }
        }

        public Task<bool> Create(ApplicationInfo entity)
        {
            using (_context)
            {
                _context.ApplicationInfo.AddAsync(entity);
                return Save();
            }
        }

        
        private async Task<bool> Save()
        {
            using (_context)
            {
                var status = await _context.SaveChangesAsync();
                return status > 0;
            }
        }

        //#region IDisposable Support
        //private bool disposedValue = false; // To detect redundant calls

        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposedValue)
        //    {
        //        if (disposing)
        //        {
        //            // TODO: dispose managed state (managed objects).
        //            _context.Dispose();
        //        }

        //        // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
        //        // TODO: set large fields to null.

        //        disposedValue = true;
        //    }
        //}

        //// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        //// ~ApplicationInfoServices() {
        ////   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        ////   Dispose(false);
        //// }

        //// This code added to correctly implement the disposable pattern.
        //public void Dispose()
        //{
        //    // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //    Dispose(true);
        //    // TODO: uncomment the following line if the finalizer is overridden above.
        //    GC.SuppressFinalize(this);
        //}
        //#endregion


    }
}
