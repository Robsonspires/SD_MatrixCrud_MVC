using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

#nullable disable

namespace SD_MatrixCrud_MVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Nome")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Matrícula")]
        public string EmpCode { get; set; }


        [Column(TypeName = "varchar(50)")]
        [DisplayName("Setor")]
        public string EmpSector { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cargo")]
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Localização")]
        public string OfficeLocation { get; set; }
    }

}
