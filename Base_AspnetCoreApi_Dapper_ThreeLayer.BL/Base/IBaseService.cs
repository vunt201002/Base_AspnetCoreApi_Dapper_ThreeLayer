using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_AspnetCoreApi_Dapper_ThreeLayer.BL.Base
{
    /// <summary>
    /// interface base service
    /// </summary>
    /// <typeparam name="TEntityDto"></typeparam>
    /// <typeparam name="TEntityCreateDto"></typeparam>
    /// <typeparam name="TEntityUpdateDto"></typeparam>
    /// created by: ntvu (09/07/2023)
    public interface IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto>
    {
        #region methods
        /// <summary>
        /// Hàm gọi tới repo, lấy tất cả bản ghi.
        /// </summary>
        /// <returns>IEnumerable<TEntityDto></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<IEnumerable<TEntityDto>> GetListAsync();

        /// <summary>
        /// Hàm gọi tới repo, lấy một bản ghi
        /// </summary>
        /// <param name="Id">Id của bản ghi</param>
        /// <returns>TEntityDto</returns>
        /// Created by: ntvu (09/07/2023)
        public Task<TEntityDto> GetAsync(Guid Id);

        /// <summary>
        /// Hàm gọi tới repo, thêm một bản ghi
        /// </summary>
        /// <param name="TEntityCreateDto">Giá trị bản ghi</param>
        /// <returns></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<int> AddAsync(TEntityCreateDto entityCreateDto);

        /// <summary>
        /// Hàm gọi tới repo, chỉnh sửa một bản ghi
        /// </summary>
        /// <param name="Id">Id cần chỉnh sửa</param>
        /// <param name="entityUpdateDto">Thông tin chỉnh sửa</param>
        /// <returns></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<int> UpdateAsync(Guid Id, TEntityUpdateDto entityUpdateDto);

        /// <summary>
        /// Hàm gọi tới repo, xóa bản ghi
        /// </summary>
        /// <param name="Ids">Danh sách id của các cần xóa</param>
        /// <returns></returns>
        /// Created by: ntvu (09/07/2023)
        public Task<int> DeleteAsync(object Ids); 

        #endregion
    }
}
