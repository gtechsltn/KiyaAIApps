using Core_API.Models;

namespace Core_API.Services
{
    /// <summary>
    /// Inject the UCompanyContext class for Performing CRUD Operations
    /// </summary>
    public class DepartmentDataService : IDataService<Department, int>
    {
        private readonly UCompanyContext context;
        public DepartmentDataService(UCompanyContext context)
        {
            this.context = context;
        }

        Task<ResponseObject<Department>> IDataService<Department, int>.CreateAsync(Department entity)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Department>> IDataService<Department, int>.DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Department>> IDataService<Department, int>.GetAsync()
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Department>> IDataService<Department, int>.GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<ResponseObject<Department>> IDataService<Department, int>.UpdateAsync(int id, Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
