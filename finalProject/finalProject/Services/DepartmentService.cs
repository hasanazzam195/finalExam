using finalProject.data;
using finalProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public class DepartmentService : IDepartmentService
    {
        private HospetalContext context;

        public DepartmentService(HospetalContext _context)
        {
            context = _context;
        }

        public List<VMDepartment> Load()
        {
            List<VMDepartment> li = context.departments.Select(data =>
           new VMDepartment
           {
               dept = data,
               Count = data.liPatiant.Count()
           }
           ).ToList();

            return li;
        }

        public List<Department> LoadAll()
        {
            List<Department> li = context.departments.ToList();
            return li;
        }


    }
}
