using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _conext;

        public DepartmentService(SalesWebMVCContext context)
        {
            _conext = context;
        }

        public List<Department> FindAll()
        {
            return _conext.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
