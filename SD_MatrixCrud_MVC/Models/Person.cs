using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.VisualBasic;
using MessagePack.Formatters;

#nullable disable

namespace SD_MatrixCrud_MVC.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Nome")]
        public string FullName { get; set; }

        [Column(TypeName ="datetime")]
        //[DisplayFormat(DateTimeFormatter = "dd/mm/yyyy")]
        [Required(ErrorMessage = "Campo obrigatório")]
        [DisplayName("Data de Nascimento")]
        public DateTime DateOfBirth { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [DisplayName("Endereço")]
        public string Adress { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [DisplayName("Endereço")]
        public string Adress2 { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Complemento")]
        public string Complement { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Cidade")]
        public string City { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Estado")]
        public string State { get; set; }

    }

}
