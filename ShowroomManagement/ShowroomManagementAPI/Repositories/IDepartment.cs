

using ShowroomManagementAPI.DTOs;

namespace ShowroomManagementAPI.Repositories
{
    public interface IDepartment
    {
        public Task<ResponseDTO> GetDepartments();
    }
}
