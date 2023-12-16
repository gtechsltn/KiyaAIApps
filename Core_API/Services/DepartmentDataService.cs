using Core_API.Models;
using Dapper;
using System.Data;
using static Dapper.SqlMapper;

namespace Core_API.Services
{
    /// <summary>
    /// Inject the UCompanyContext class for Performing CRUD Operations
    /// </summary>
    public class DepartmentDataService : IDataService<Department, int>
    {
        private readonly UCompanyContext context;
        private IConfiguration config;
        ResponseObject<Department> response;
        public DepartmentDataService(UCompanyContext context, IConfiguration config)
        {
            this.context = context;
            this.config = config;
            response = new ResponseObject<Department>();
        }

        async Task<ResponseObject<Department>> IDataService<Department, int>.CreateAsync(Department entity)
        {
            var query = config["Queries:CreateDept"].ToString();
            // Define Parameters
            var parameters = new DynamicParameters();
            parameters.Add("@DeptNo", entity.DeptNo, DbType.Int32);
            parameters.Add("@DeptName", entity.DeptName, DbType.String);
            parameters.Add("@Location", entity.Location, DbType.String);
            parameters.Add("@Capacity", entity.Capacity, DbType.Int32);

            using (var conn = context.CreateConnection())
            {
                var result = await conn.ExecuteAsync(query, parameters);
                if (result > 0)
                {
                    response.Record = entity;
                }
            }
            return response;
        }

        async Task<ResponseObject<Department>> IDataService<Department, int>.DeleteAsync(int id)
        {
            var query = config["Queries:DeleteDept"].ToString();
            // Define Parameters
            var parameters = new DynamicParameters();
            parameters.Add("@DeptNo", id, DbType.Int32);
             
            using (var conn = context.CreateConnection())
            {
                var result = await conn.ExecuteAsync(query, parameters);
                if (result > 0)
                {
                    response.Message = $"Department with DeptNo {id} is deleted successfully";
                }
            }
            return response;
        }

        async Task<ResponseObject<Department>> IDataService<Department, int>.GetAsync()
        {
            var query = config["Queries:AllDept"].ToString();

            using (var conn = context.CreateConnection())
            {
               response.Records =  await conn.QueryAsync<Department>(query);
            }
            return response;

        }

        async Task<ResponseObject<Department>> IDataService<Department, int>.GetAsync(int id)
        {
            var query = config["Queries:DeptByNo"].ToString();
            // Lets define a parameter
            var parameters = new DynamicParameters();
            parameters.Add("@DeptNo", id, DbType.Int32);

            using (var conn = context.CreateConnection())
            {
                response.Record = await conn.QuerySingleOrDefaultAsync<Department>(query,parameters);
            }
            return response;
        }

        async Task<ResponseObject<Department>> IDataService<Department, int>.UpdateAsync(int id, Department entity)
        {
            var query = config["Queries:UpdateDept"].ToString();
            // Define Parameters
            var parameters = new DynamicParameters();
            parameters.Add("@DeptNo", entity.DeptNo, DbType.Int32);
            parameters.Add("@DeptName", entity.DeptName, DbType.String);
            parameters.Add("@Location", entity.Location, DbType.String);
            parameters.Add("@Capacity", entity.Capacity, DbType.Int32);

            using (var conn = context.CreateConnection())
            {
                var result = await conn.ExecuteAsync(query, parameters);
                if (result > 0)
                {
                    response.Record = entity;
                }
            }
            return response;
        }
    }
}
