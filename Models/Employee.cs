using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeRegisterAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EmployeeName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? Ocupation {  get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? ImageName { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        [NotMapped]
        public string? ImageSrc {  get; set; }

    }
}
