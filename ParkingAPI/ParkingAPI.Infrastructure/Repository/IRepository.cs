using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ParkingAPI.Infrastructure.Repository
{

        /// <summary>
        /// Base repository
        /// </summary>
        /// <typeparam name="TEntity">Entity type</typeparam>
        public interface IRepository<TEntity> where TEntity: class
        {
            /// <summary>
            /// Get all records
            /// </summary>
            /// <returns></returns>
            IQueryable<TEntity> GetAll();
        
            /// <summary>
            /// 
            /// </summary>
            /// <param name="predicat"></param>
            /// <returns></returns>
            IQueryable<TEntity> GetAllFiltered(Expression<Func<TEntity, bool>> predicat);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>
            Task<TEntity> GetByIdAsync(Guid id);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>
            Task AddAsync(TEntity model);
        
            /// <summary>
            /// 
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>
            Task UpdateAsync(TEntity model);
        
            /// <summary>
            /// 
            /// </summary>
            /// <param name="model"></param>
            /// <returns></returns>
            Task DeleteAsync(TEntity model);

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            Task SaveChangesAsync();
        }
}