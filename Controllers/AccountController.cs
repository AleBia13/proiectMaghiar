using Microsoft.AspNetCore.Mvc;
using proiectMaghiar.Models;
using System.Data.SqlClient;

namespace proiectMaghiar.Controllers
{
    public class AccountController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            con.ConnectionString = "data source =DESKTOP-4VK87CC;database=proiect1; integrated security=SSPI";
        }

       

        public ActionResult Verify(Account acc)
        {

            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_login where username='" + acc.Name + "' and password='" + acc.Password+"";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View("Create");
            }
            else
            {
                con.Close();
                return View("Error");
            }
           

            
        }
    }
}
