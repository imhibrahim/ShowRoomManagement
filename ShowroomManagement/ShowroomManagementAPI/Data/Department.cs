using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShowroomManagementAPI.Data
{
    public class Department
    {
        [Key]
        public int id { get; set; }
        [Column("varchar(100)")]
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
