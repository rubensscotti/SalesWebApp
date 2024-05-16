using Microsoft.EntityFrameworkCore;
using SalesWebApp.Data;
using SalesWebApp.Models;

namespace SalesWebApp.Services
{
    public class DepartmentService
    {
        private readonly SalesWebAppContext _appContext;

        public DepartmentService(SalesWebAppContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _appContext.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
