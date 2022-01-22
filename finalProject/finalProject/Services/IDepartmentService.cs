using finalProject.data;
using finalProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Services
{
    public interface IDepartmentService
    {
        List<Department> LoadAll();
        List<VMDepartment> Load();
    }
}
