using ShowroomManagementAPI.DTOs;

namespace ShowroomManagementAPI.Controllers
{
    public interface IDepartmernt
    {
        public Task<ResponseDTO> GetDepartments();
    }
}