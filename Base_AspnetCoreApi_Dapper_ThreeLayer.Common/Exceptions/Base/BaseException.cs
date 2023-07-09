using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Base_AspnetCoreApi_Dapper_ThreeLayer.Common.Exceptions.Base
{
    /// <summary>
    /// Lớp lỗi cơ sở
    /// </summary>
    /// created by: ntvu (09/07/2023)
    public class BaseException
    {
        #region properties
        public int ErrorCode { get; set; }                  // mã lỗi
        public string? UserMessage { get; set; }            // thông báo cho người dùng
        public string? DevMessage { get; set; }             // thông báo cho dev
        public string? TraceId { get; set; }                // mã tra cứu
        public string? MoreInfo { get; set; }               // thông tin thêm  
        #endregion

        #region methods
        /// <summary>
        /// Override phương thức ToString của class Exception
        /// </summary>
        /// <returns>string</returns>
        /// created by: ntvu (09/07/2023)
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        #endregion
    }
}
