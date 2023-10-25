using Microsoft.EntityFrameworkCore;
using learning_mvc.Models;

namespace learning_mvc.Data
{
    public class learning_MVC : DbContext
    {
        public learning_MVC(DbContextOptions<learning_MVC> options) : base(options)
        { }
        public DbSet<learning_mvc.Models.EmployeeModel>? EmployeeModel { get; set; }
    }
}
