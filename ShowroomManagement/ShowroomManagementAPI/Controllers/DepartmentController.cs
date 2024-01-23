using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowroomManagementAPI.DTOs;
using ShowroomManagementAPI.Repositories;

namespace ShowroomManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartment service;

        public DepartmentController(IDepartment _service)
        {
            service = _service;


        }


        [HttpGet("GetDepartments")]
        public async Task<string> GetDepartments()
        {
            var data = await service.GetDepartments();
            var convertedData = JsonConvert.SerializeObject(data);
            return convertedData;

        }

        [HttpPost("AddDepartment")]
        public async Task<string> AddDepartment(DepartmentDTO departmentDTO)
        {
            return JsonConvert.SerializeObject(await service.AddDepartment(departmentDTO));

        }



    }
}
 

