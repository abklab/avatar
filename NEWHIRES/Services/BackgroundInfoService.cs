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
    public class BackgroundInfoService : IBackgroundInfo
    {
        private NHDBContext _context;

        /// <summary>
        /// DbContext Constructor injection
        /// </summary>
        /// <param name="context"></param>
        public BackgroundInfoService(NHDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Inser BackgroundInfo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<bool> Create(BackgroundInfo entity)
        {
            using (_context)
            {
                _context.BackgroundInfo.AddAsync(entity);
                return Save();
            }
        }
       
        /// <summary>
        /// Delete BackgroundInfo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<bool> Delete(int id)
        {
            using (_context)
            {
                var entity = _context.BackgroundInfo.Find(id);   
                _context.BackgroundInfo.Remove(entity);
                return Save();
            }
        }

        /// <summary>
        /// Find BackgroundInfo by EntryID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<BackgroundInfo> Find(int id)
        {
            using (_context)
            {
               return _context.BackgroundInfo.FindAsync(id);              
            }
        }

        /// <summary>
        /// Find BackgroundInfo by AppID
        /// </summary>
        /// <param name="appid"></param>
        /// <returns></returns>
        public Task<BackgroundInfo> FindByAppId(int appid)
        {
            using (_context)
            {
                return _context.BackgroundInfo.FirstOrDefaultAsync(x=>x.AppID==appid);
            }
        }

        /// <summary>
        /// Get all BackgroundInfo
        /// </summary>
        /// <returns>List of BackgroundInfo</returns>
        public async Task<IEnumerable<BackgroundInfo>> GetAll()
        {
            using (_context)
            {
                return await _context.BackgroundInfo.ToListAsync();
            }
        }

        /// <summary>
        /// Search by providing filter values
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public async Task<IEnumerable<BackgroundInfo>> Search(Expression<Func<BackgroundInfo, bool>> expression)
        {
            using (_context)
            {
                return await _context.BackgroundInfo.Where(expression).ToListAsync();
            }
        }

        /// <summary>
        /// Update Background info
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<bool> Update(BackgroundInfo entity)
        {
            using (_context)
            {
                 _context.BackgroundInfo.Update(entity);                
                return Save();
            }
        }

        /// <summary>
        ///   Save changes
        /// </summary>      
        private async Task<bool> Save()
        {
            var i = await _context.SaveChangesAsync();
            return i > 0;
        }
    }
}
