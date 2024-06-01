using Ecommerce2.Models;

namespace Ecommerce2.Repositories
{
    public class DBManagerConnected
    {
        public static string conString = @"server=localhost;port=3306;user=root;password=admin123;database=ecommerce";
        public static Employee GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conString;
        }
    }
}
