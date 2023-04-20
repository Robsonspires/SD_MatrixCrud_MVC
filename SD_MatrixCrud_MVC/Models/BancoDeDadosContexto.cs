using Microsoft.EntityFrameworkCore;


namespace SD_MatrixCrud_MVC.Models
{
    public class BancoDeDadosContexto: DbContext
    {

        public BancoDeDadosContexto(DbContextOptions<BancoDeDadosContexto> options): base(options) 
        { 

        }
       
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> Peoples { get; set; }
    }
}
