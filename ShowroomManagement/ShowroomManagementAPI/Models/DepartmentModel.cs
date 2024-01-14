using Microsoft.EntityFrameworkCore;
using ShowroomManagementAPI.Data;
using ShowroomManagementAPI.DTOs;
using ShowroomManagementAPI.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace ShowroomManagementAPI.Models
{
    public class DepartmentModel : IDepartment

    {
        private readonly ApplicationDbContext db_context;

        public DepartmentModel(ApplicationDbContext dbContext)
        {
            this.db_context = dbContext;
        }


        public async Task<ResponseDTO> GetDepartments()
        {
            var response = new ResponseDTO();
            try {
               response.Response=await db_context.Departments.ToListAsync();
            }
            catch (Exception ex)
            {
                response.ErrorMassage = ex.Message;
            }
            return response;
        }
    }
}
