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

        public List<Department> FindAll()
        {
            return _appContext.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
