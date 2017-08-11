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
                string Firstname = FirstNametextbox.Text;
                string Lastname = LastNametextbox.Text;
                string Email = Emailtextbox.Text;
                var MobileNumber = Convert.ToInt64(MobileNumbertextbox.Text);
                long AlternateMobileNumber = Convert.ToInt64(AlternateMobileNumbertextbox.Text);
                string Address1 = Address1textbox.Text;
                string Address2 = Address2textbox.Text;
                string CurrentCountry = CurrentCountrytextbox.Text;
                string HomeCountry = HomeCountrytextbox.Text;
                int Zipcode = Convert.ToInt32(Zipcodetextbox.Text);

                EmployeeDataAcessLayer objpioneerdatacees = new EmployeeDataAcessLayer();
                objpioneerdatacees.SaveEmployee(Firstname,Lastname,Email,MobileNumber,AlternateMobileNumber,Address1,Address2,CurrentCountry,HomeCountry,Zipcode);

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
                string EmployeeID = employeeidtextbox10.Text;
                 string Employeename = Employeenametextbox.Text;
                var Contactnumber = Convert.ToInt64(contactnumbertextbox.Text);
                string Location = LocationtextBox.Text;
                string Website = Websitetextbox.Text;
                EmployeeDataAcessLayer objcompanydetails = new EmployeeDataAcessLayer();
                objcompanydetails.SaveCompany(EmployeeID, Employeename, Contactnumber, Location, Website);
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
                int ProjectID = Convert.ToInt32(ProjectIDtextBox.Text);
                int EmployeeID = Convert.ToInt32(EmployeeID1textbox.Text);
                string ProjectName = ProjectNametextbox.Text;
                string ClientName = Clientnametextbox.Text;
                string Location = Location1textbox.Text;
                string Role = Roletextbox.Text;
                EmployeeDataAcessLayer objprojectdetails = new EmployeeDataAcessLayer();
                objprojectdetails.SaveProject(ProjectID, EmployeeID, ProjectName, ClientName, Location, Role);
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
                int EmployeeID = Convert.ToInt32(EmployeeID5textbox.Text);
                string UI = UItextbox.Text;
                string Programminglanguages = programminglanguagestextbox.Text;
                string ORMTechnologies = ORMtechnologiestextbox.Text;
                string Databases = databasestextBox.Text;
                EmployeeDataAcessLayer objtechnicaldetails = new EmployeeDataAcessLayer();
                objtechnicaldetails.SaveTechnical(EmployeeID, UI, Programminglanguages, ORMTechnologies, Databases);
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
                long EmployeeID = Convert.ToInt32(employeeid9textbox.Text);
                string Coursetype = Coursetypetextbox.Text;
                int Yearofpass = Convert.ToInt32(yearofpasstextbox.Text);
                string CourseSpecialization = coursespecializationtextbox.Text;
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

