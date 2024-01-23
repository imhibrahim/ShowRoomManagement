

using ShowroomManagementAPI.DTOs;

namespace ShowroomManagementAPI.Repositories
{
    public interface IDepartment
    {
        public Task<ResponseDTO> GetDepartments();

        public Task<ResponseDTO> AddDepartment(DepartmentDTO departmentDTO);
    }

    }
