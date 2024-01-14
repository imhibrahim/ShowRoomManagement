using Microsoft.EntityFrameworkCore;


namespace ShowroomManagementAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
          
        }
        public DbSet<Department> Departments { get; set; }
    } 
}
