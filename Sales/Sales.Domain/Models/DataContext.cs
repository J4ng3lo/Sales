namespace Sales.Domain.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext(): base("DefaultConnection") //Se conecta a la BD en la nube
        {

        }
     }
}
