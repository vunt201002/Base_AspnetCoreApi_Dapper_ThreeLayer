using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace Base_AspnetCoreApi_Dapper_ThreeLayer.DL.Context
{
    public class DapperContext
    {
        #region properties
        private readonly IConfiguration _configuration;
        private readonly string? _connectionString;
        #endregion

        #region constructor
        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MyConnection");
        }
        #endregion

        #region methods
        /// <summary>
        /// Tạo một kết nối đến database.
        /// </summary>
        /// <returns>IDbConnection</returns>
        /// Created by: ntvu (12/05/2023)
        public IDbConnection CreateConnection() => new MySqlConnection(_connectionString);
        #endregion
    }
}
