using finalProject.data;
using finalProject.model;
using finalProject.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private  IDepartmentService departmentService;

        public DepartmentController(IDepartmentService _departmentService )
        {
            departmentService = _departmentService;
        }
        [HttpGet]
        [Route("LoadAll")]
        public List<Department> LoadAll()
        {
            List<Department> li = departmentService.LoadAll();
            return li;
        }
        [HttpGet]
        [Route("Load")]
        public List<VMDepartment> Load()
        {
            List<VMDepartment> li = departmentService.Load();
            return li;
        }
    }
}
