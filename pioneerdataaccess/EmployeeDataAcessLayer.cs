using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PioneerTech;

namespace pioneerdataaccess
{
    public class EmployeeDataAcessLayer

    {        
        public void SaveEmployee(EmployeeDetailsModel emp)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                        "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO EMPLOYEEDETAILS(firstname,lastname,email,mobilenumber,alternatemobilenumber,Address1,Address2,currentcountry,Homecountry,zipcode)VALUES('" + emp.Firstname + "'," + "'" + emp.Lastname + "'," + "'" + emp.Email + "'," + "" + emp.MobileNumber + "," + "" + emp.AlternateMobileNumber + "," + "'" + emp.Address1 + "'," + "'" + emp.Address2 + "'," + "'" + emp.CurrentCountry + "'," + "'" + emp.HomeCountry + "'," + "" + emp.Zipcode + ")";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }

        }
        public void SaveCompany(CompanyDetailsModel com)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO COMPANY_DETAILS(EmployeeID,Employeename,contactnumber,Location,Website)VALUES(" + com.EmployeeID + "," + "'" +com.Employeename + "'," +com.Contactnumber + "," + "'" +com.Location + "'," + "'" +com.Website + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }

        }
        public void SaveProject(ProjectDetailsModel pro)
        {
            try
            {

                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO PROJECTDETAILS(ProjectID,EmployeeID,ProjectName,ClientName,Location,Role)VALUES(" + pro.ProjectID + "," + "" + pro.EmployeeID + "," + "'" + pro.ProjectName + "'," + "'" + pro.ClientName + "'," + "'" + pro.Location + "'," + "'" + pro.Role + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }
        }
        public void SaveTechnical(TechnicalDetailsModel tech)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO TECHNICALDETAILS(EmployeeID,UI,ProgrammingLanguages,ORMTechnologies,Databases)VALUES(" + tech.EmployeeID + "," + "'" + tech.UI + "'," + "'" + tech.ProgrammingLanguages + "'," + "'" + tech.ORMTechnologies + "'," + "'" + tech.Databases + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();
            }
            finally
            {

            }
        }
        public void SaveEducational(EducationDetailsModel edu)
        {
            try
            {
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO EDUCATIONDETAILS(EmployeeID,CourseType,Yearofpass,Coursespecialization)VALUES(" + edu.EmployeeID + "," + "'" + edu.Coursetype + "'," + "'" + edu.Yearofpass + "'," + "'" + edu.CourseSpecialization + "')";
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



