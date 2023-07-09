using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_AspnetCoreApi_Dapper_ThreeLayer.DL.Base
{
    /// <summary>
    /// Lớp cơ sở
    /// </summary>
    /// Created by: ntvu (09/07/2023)
    public class BaseEntity
    {
        #region properties
        public string? created_by { get; set; }                             // người tạo
        public DateTime created_date { get; set; } = DateTime.Now;          // ngày tạo
        public string? modified_by { get; set; }                            // người sửa
        public DateTime modified_date { get; set; } = DateTime.Now;         // ngày sửa 
        #endregion
    }
}
