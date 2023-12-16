using System.Data.SqlClient;
using System.Data;

namespace Core_API.Models
{
    /// <summary>
    /// Inject the ICOnfiguration to Read Conectionstring
    /// Use the IDbConnetion that will return the the Database Connection based on provider
    /// SqlConnection
    /// </summary>
    public class UCompanyContext
    {
        private readonly IConfiguration configuration;
        private readonly string connStr;
        // DI for IConfguration to Read the ConnectonString
        public UCompanyContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            // REad the Connection string from appsettings.json file
            connStr = this.configuration.GetConnectionString("AppConnStr");
        }
        // Returning the COnnection Object
        public IDbConnection CreateConnection()
            => new SqlConnection(connStr);
    }
}
