using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _conext;

        public DepartmentService(SalesWebMVCContext context)
        {
            _conext = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _conext.Department
                .OrderBy(x => x.Name)
                .ToListAsync();
        }
    }
}