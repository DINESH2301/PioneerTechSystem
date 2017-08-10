using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pioneerdataaccess
{
    public class EmployeeDataAcessLayer

    {
        
        public void SaveEmployee(string firstname, string lastname, string email, long mobilenumber, long alternatemobilenumber, string Address1, string Address2, string currentcountry, string homecountry, int zipcode)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                        "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO EMPLOYEEDETAILS(firstname,lastname,email,mobilenumber,alternatemobilenumber,Address1,Address2,currentcountry,Homecountry,zipcode)VALUES('" + firstname + "'," + "'" + lastname + "'," + "'" + email + "'," + "" + mobilenumber + "," + "" + alternatemobilenumber + "," + "'" + Address1 + "'," + "'" + Address2 + "'," + "'" + currentcountry + "'," + "'" + homecountry + "'," + "" + zipcode + ")";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
        }
    }
}


