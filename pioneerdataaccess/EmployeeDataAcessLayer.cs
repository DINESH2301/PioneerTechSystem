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
            finally
            {

            }

        }
        public void SaveCompany(string EmployeeID, string Employeename, long Contactnumber, string Location, string Website)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO COMPANY_DETAILS(EmployeeID,Employeename,contactnumber,Location,Website)VALUES(" + EmployeeID + "," + "'" + Employeename + "'," + Contactnumber + "," + "'" + Location + "'," + "'" + Website + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }

        }
        public void SaveProject(long ProjectID, long EmployeeID, string ProjectName, string ClientName, string Location, string Role)
        {
            try
            {

                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO PROJECTDETAILS(ProjectID,EmployeeID,ProjectName,ClientName,Location,Role)VALUES(" + ProjectID + "," + "" + EmployeeID + "," + "'" + ProjectName + "'," + "'" + ClientName + "'," + "'" + Location + "'," + "'" + Role + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }
        }
        public void SaveTechnical(long EmployeeID, string UI, string Programminglanguages, string ORMTechnologies, string Databases)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO TECHNICALDETAILS(EmployeeID,UI,ProgrammingLanguages,ORMTechnologies,Databases)VALUES(" + EmployeeID + "," + "'" + UI + "'," + "'" + Programminglanguages + "'," + "'" + ORMTechnologies + "'," + "'" + Databases + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }
        }
        public void SaveEducational(long EmployeeID, string Coursetype, long Yearofpass, string CourseSpecialization)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO EDUCATIONDETAILS(EmployeeID,CourseType,Yearofpass,Coursespecialization)VALUES(" + EmployeeID + "," + "'" + Coursetype + "'," + "'" + Yearofpass + "'," + "'" + CourseSpecialization + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {
            }
        }
    }
}



