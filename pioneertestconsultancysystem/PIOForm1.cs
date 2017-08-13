using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pioneerdataaccess;
using PioneerTech;
namespace pioneertestconsultancysystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDetailsModel emp = new EmployeeDetailsModel();

                emp.Firstname = FirstNametextbox.Text;
                emp.Lastname = LastNametextbox.Text;
                emp.Email = Emailtextbox.Text;
                emp.MobileNumber = Convert.ToInt64(MobileNumbertextbox.Text);
                emp.AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumbertextbox.Text);
                emp.Address1 = Address1textbox.Text;
                emp.Address2 = Address2textbox.Text;
                emp.CurrentCountry = CurrentCountrytextbox.Text;
                emp.HomeCountry = HomeCountrytextbox.Text;
                emp.Zipcode = Convert.ToInt32(Zipcodetextbox.Text);

                EmployeeDataAcessLayer objemployeedetails = new EmployeeDataAcessLayer();
                objemployeedetails.SaveEmployee(emp);

                //string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                //    "Integrated Security=True";
                //SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                //mysqlconnection.Open();
                //string COMMAND = "INSERT INTO EMPLOYEEDETAILS(FirstName,LastName,EmailId,mobilenumber,Alternatemobilenumber,Address1,Address2,currentcountry,Homecountry,zipcode)VALUES('"+Firstname+"',"+"'"+Lastname+"',"+"'"+Email+"',"+""+MobileNumber+","+""+AlternateMobileNumber+","+"'"+Address1+"',"+"'"+Address2+"',"+"'"+CurrentCountry+"',"+"'"+HomeCountry+"',"+""+Zipcode+")";
                //SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                //cmd.ExecuteNonQuery();
                //mysqlconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error occured:" +ex.Message);
            }
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton3_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyDetailsModel com = new CompanyDetailsModel();
                com.EmployeeID = Convert.ToInt32(employeeidtextbox10.Text);
                 com.Employeename = Employeenametextbox.Text;
                com.Contactnumber = Convert.ToInt64(contactnumbertextbox.Text);
                com.Location = LocationtextBox.Text;
                com.Website = Websitetextbox.Text;
                EmployeeDataAcessLayer objcompanydetails = new EmployeeDataAcessLayer();
                objcompanydetails.SaveCompany(com);
                /*string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO COMPANY_DETAILS(EmployeeID,Employeename,contactnumber,Location,Website)VALUES("+EmployeeID+","+"'"+Employeename+"',"+Contactnumber+","+"'"+Location+"',"+"'"+Website+"')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Savebutton5_Click(object sender, EventArgs e)
        {
            try
            {
                ProjectDetailsModel pro = new ProjectDetailsModel();
               
                pro.ProjectID = Convert.ToInt32(ProjectIDtextBox.Text);
                pro.EmployeeID = Convert.ToInt32(EmployeeID1textbox.Text);
                pro.ProjectName = ProjectNametextbox.Text;
                pro.ClientName = Clientnametextbox.Text;
                pro.Location = Location1textbox.Text;
                pro.Role = Roletextbox.Text;
                EmployeeDataAcessLayer objprojectdetails = new EmployeeDataAcessLayer();
                objprojectdetails.SaveProject(pro);
                /*string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open();
                string COMMAND = "INSERT INTO PROJECTDETAILS(ProjectID,EmployeeID,ProjectName,ClientName,Location,Role)VALUES("+ProjectID+","+""+ EmployeeID + "," + "'" + ProjectName + "'," + "'" + ClientName + "'," + "'" + Location + "'," + "'" + Role + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        private void EmployeeID1textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton7_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicalDetailsModel tech = new TechnicalDetailsModel();
                tech.EmployeeID = Convert.ToInt32(EmployeeID5textbox.Text);
                tech.UI = UItextbox.Text;
                tech.ProgrammingLanguages = programminglanguagestextbox.Text;
                tech.ORMTechnologies = ORMtechnologiestextbox.Text;
                tech.Databases = databasestextBox.Text;
                EmployeeDataAcessLayer objtechnicaldetails = new EmployeeDataAcessLayer();
                objtechnicaldetails.SaveTechnical(tech);
               /* string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO TECHNICALDETAILS(EmployeeID,UI,ProgrammingLanguages,ORMTechnologies,Databases)VALUES(" +EmployeeID+","+"'" + UI + "',"+"'"+Programminglanguages+"',"+"'" +ORMTechnologies +"',"+"'"+Databases+"')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Websitetextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton9_Click(object sender, EventArgs e)
        {
            try
            {
                EducationDetailsModel edu = new EducationDetailsModel();
                edu.EmployeeID = Convert.ToInt32(employeeid9textbox.Text);
                edu.Coursetype = Coursetypetextbox.Text;
                edu.Yearofpass = Convert.ToInt32(yearofpasstextbox.Text);
                edu.CourseSpecialization = coursespecializationtextbox.Text;
                EmployeeDataAcessLayer objeducationdetails = new EmployeeDataAcessLayer();
                objeducationdetails.SaveEducational(edu);
             /*   string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                    "Integrated Security=True";
                SqlConnection mysqlconnection = new SqlConnection(connectionstring);
                mysqlconnection.Open(); string COMMAND = "INSERT INTO EDUCATIONDETAILS(EmployeeID,CourseType,Yearofpass,Coursespecialization)VALUES("+EmployeeID+","+"'" + Coursetype + "'," + "'" + Yearofpass + "'," + "'" + CourseSpecialization + "')";
                SqlCommand cmd = new SqlCommand(COMMAND, mysqlconnection);
                cmd.ExecuteNonQuery();
                mysqlconnection.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

      

     

        private void clearbutton_Click(object sender, EventArgs e)
        {
            FirstNametextbox.Text = string.Empty;
            LastNametextbox.Text = string.Empty;
            Emailtextbox.Text = string.Empty;
            MobileNumbertextbox.Text = string.Empty;
            AlternateMobileNumbertextbox.Text = string.Empty;
            Address1textbox.Text = string.Empty;
            Address2textbox.Text = string.Empty;
            CurrentCountrytextbox.Text = string.Empty;
            HomeCountrytextbox.Text = string.Empty;
            Zipcodetextbox.Text = string.Empty;
        }

        private void clearbutton2_Click(object sender, EventArgs e)
        {
            Employeenametextbox.Text = string.Empty;
            contactnumbertextbox.Text = string.Empty;
            LocationtextBox.Text = string.Empty;
            Websitetextbox.Text = string.Empty;
        }

        private void clearbutton3_Click(object sender, EventArgs e)
        {
            ProjectIDtextBox.Text = string.Empty;
            ProjectNametextbox.Text = string.Empty;
            Clientnametextbox.Text = string.Empty;
            Location1textbox.Text = string.Empty;
            Roletextbox.Text = string.Empty;

        }

        private void clearbutton4_Click(object sender, EventArgs e)
        {
            UItextbox.Text = string.Empty;
            programminglanguagestextbox.Text = string.Empty;
            ORMtechnologiestextbox.Text = string.Empty;
            databasestextBox.Text = string.Empty;

        }

        private void clearbutton5_Click(object sender, EventArgs e)
        {
            Coursetypetextbox.Text = string.Empty;
            yearofpasstextbox.Text = string.Empty;
            coursespecializationtextbox.Text = string.Empty;

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click_1(object sender, EventArgs e)
        {

        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            try { 
                int EmployeeID = Convert.ToInt32(employeeidtextbox1.Text);
                string connectionstring = @"Data Source=DINESH-COMPUTER\MYSQL;Initial Catalog = pioneerdb;" +
                "Integrated Security=True";
            SqlConnection mysqlconnection = new SqlConnection(connectionstring);
            mysqlconnection.Open();
            string sqlemployeedetails = ("SELECT * FROM EMPLOYEEDETAILS WHERE EmployeeID="+EmployeeID);
            string sqlprojectdetails = ("SELECT * FROM PROJECTDETAILS WHERE EmployeeID="+EmployeeID);
            string sqleducationdetails = ("SELECT * FROM EDUCATIONDETAILS WHERE EmployeeID="+EmployeeID);
            string sqlcompanydetails = ("SELECT * FROM COMPANY_DETAILS WHERE EmployeeID="+EmployeeID);
            string sqltechnicaldetails = ("SELECT * FROM TECHNICALDETAILS WHERE EmployeeID=" + EmployeeID);
            SqlCommand command;
            command = new SqlCommand(sqlemployeedetails, mysqlconnection);
            SqlDataReader employeedata = command.ExecuteReader();
            BindingSource gridview = new BindingSource();
            gridview.DataSource = employeedata;
            employeeidgridbox.DataSource = gridview;
            employeedata.Close();
                command = new SqlCommand(sqlprojectdetails, mysqlconnection);
                SqlDataReader projectdata = command.ExecuteReader();
                BindingSource projectgridview = new BindingSource();
                projectgridview.DataSource = projectdata;
                projectdataGridbox.DataSource = projectgridview;
                projectdata.Close();
                command = new SqlCommand(sqleducationdetails, mysqlconnection);
                SqlDataReader educationdata = command.ExecuteReader();
                BindingSource educationgridview = new BindingSource();
                educationgridview.DataSource = educationdata;
                educationdataGridbox.DataSource = educationgridview;
                educationdata.Close();
                command = new SqlCommand(sqlcompanydetails, mysqlconnection);
                SqlDataReader companydata = command.ExecuteReader();
                BindingSource companydatabindingsource = new BindingSource();
                companydatabindingsource.DataSource = companydata;
                companydataGridview.DataSource = companydatabindingsource;
                companydata.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been occured, please contact the administartor: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

