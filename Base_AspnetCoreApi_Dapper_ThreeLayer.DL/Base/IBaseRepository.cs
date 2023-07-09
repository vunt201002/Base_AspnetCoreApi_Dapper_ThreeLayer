using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Base_AspnetCoreApi_Dapper_ThreeLayer.DL.Base
{
    public interface IBaseRepository<TEntity>
    {
        #region methods
        /// <summary>
        /// Hàm lấy tất cả bản ghi.
        /// </summary>
        /// <returns>IEnumerable<TEntity></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<IEnumerable<TEntity>> GetListAsync();

        /// <summary>
        /// Hàm lấy một bản ghi.
        /// </summary>
        /// <param name="Id">Id của bản ghi</param>
        /// <returns>TEntity</returns>
        /// Created by: ntvu (09/07/2023)
        public Task<TEntity> GetAsync(Guid Id);

        /// <summary>
        /// Hàm thêm một bản ghi.
        /// </summary>
        /// <param name="entity">Giá trị bản ghi</param>
        /// <returns></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<int> AddAsync(TEntity entity);

        /// <summary>
        /// Hàm chỉnh sửa bản ghi.
        /// </summary>
        /// <param name="Id">Id bản ghi</param>
        /// <param name="entity">Thông tin chỉnh sửa</param>
        /// <returns></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<int> UpdateAsync(Guid Id, TEntity entity);

        /// <summary>
        /// Hàm xóa (một hoặc nhiều) bản ghi.
        /// </summary>
        /// <param name="Ids">Id bản ghi</param>
        /// <returns></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<int> DeleteAsync(object Ids);
        #endregion
    }
}
