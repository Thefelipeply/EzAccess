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

namespace GUI
{
    public partial class RegistrationForm : Form
    {        
        EzAccess connect = new EzAccess();
        private string GeneratedID;
        public RegistrationForm()
        {
            connect.connString();
            InitializeComponent(); 
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
            EmptyFieldError_Label.Visible = false;
            TermsUseError_Label.Visible = false;
            UserExistError_Label.Visible = false;
            WrongPass_Label.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            try
            { 
                
                connect.UserSelect();
                connect.cmd();
                connect.sqladapterSelect();
                connect.sqlDataSetSelect_UserTable();
                dataGridView1.DataSource = connect.sql_dataset.Tables[0];
                
                connect.LoginSelect();
                connect.cmd();
                connect.sqladapterSelect();
                connect.sqlDataSetSelect_LoginTable();
                dataGridView2.DataSource = connect.sql_dataset.Tables[0];
                
            }
            catch (Exception)
            {
                MessageBox.Show("LOAD");
            }
            
            bool IDExist = true; 
            while (IDExist == true)
            {     
                GeneratedID = "";
                string GenerateIDtemp(int length)
                {
                    var alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    var random = new Random();
                    return new string(Enumerable.Repeat(alphabet, length).Select(s => s[random.Next(s.Length)]).ToArray());
                }
                GeneratedID = GenerateIDtemp(16);
                

                
                connect.sql = "SELECT * FROM UserTable " + "WHERE ID = '" + GeneratedID + "'";
                connect.cmd();
                connect.sqladapterSelect();
                connect.sqlDataSetSelect_UserTable();
                dataGridView3.DataSource = connect.sql_dataset.Tables[0];
                
                if(dataGridView3.Rows.Count != 0)
                {
                    IDExist = false;
                    RandomID_TextBox.Text = GeneratedID;
                }
            }   
        }

        private void backBtn_Click(object sender, EventArgs e)
        {            
            MenuDefaultForm mainfrm = new MenuDefaultForm();
            mainfrm.Show();
            this.Hide();
        }
        
        private void registerBtn_Click(object sender, EventArgs e)
        {

            if ((FirstName_Textbox.Text == "")||(MiddleName_Textbox.Text == "")||(LastName_Textbox.Text == "")||(Suffix_Textbox.Text == "") ||(Email_Textbox.Text == "") ||(Occupation_Textbox.Text == "")||(Username_Textbox.Text == "") ||(Password_Textbox.Text == "") ||(ConfirmPassword_Textbox.Text == ""))
            {
                EmptyFieldError_Label.Visible = true;
            }
            else
            {
                if (Agree_CheckBox.Checked)
                {
                    if (Password_Textbox.Text != ConfirmPassword_Textbox.Text)
                    {
                        WrongPass_Label.Visible = true;
                    }
                    else
                    {
                        connect.sql = "SELECT * FROM LoginTable WHERE CONVERT(VARCHAR, Username) = '" + Username_Textbox.Text + "'";
                        connect.cmd();
                        connect.sqladapterSelect();
                        connect.sqlDataSetSelect_LoginTable();
                        dataGridView4.DataSource = connect.sql_dataset.Tables[0];

                        if (dataGridView4.Rows.Count != 0)
                        {
                            try
                            {
                                string defaultpath = "C:\\Users\\Emil Calilung\\Documents\\GitHub\\EzAccess\\EzAccess Files\\Resources\\default 1x1.png";
                                connect.sql = "INSERT INTO UserTable (ID, FirstName, MiddleName, LastName, Suffix, Age, Sex, Address, Email, Occupation, Status, PicturePath)"
                                + "VALUES ('" + GeneratedID + "', '" + FirstName_Textbox.Text + "', '" + MiddleName_Textbox.Text + "', '" + LastName_Textbox.Text + "', '" + Suffix_Textbox.Text
                                + "', '" + "NA" + "', '" + "NA" + "', '" + "NA" + "', '" + Email_Textbox.Text + "', '" + Occupation_Textbox.Text + "', '" + "Inactive" + "', '" + defaultpath + "')";
                                connect.cmd();
                                connect.sqladapterInsert();

                                connect.sql = "INSERT INTO LoginTable (ID, Username, Password, AccountType) VALUES ('" + GeneratedID + "', '" + Username_Textbox.Text + "', '" + Password_Textbox.Text + "', '" + AccountType.Text + "')";
                                connect.cmd();
                                connect.sqladapterInsert();

                                connect.UserSelect();
                                connect.cmd();
                                connect.sqladapterSelect();
                                connect.sqlDataSetSelect_UserTable();
                                dataGridView1.DataSource = connect.sql_dataset.Tables[0];

                                connect.LoginSelect();
                                connect.cmd();
                                connect.sqladapterSelect();
                                connect.sqlDataSetSelect_LoginTable();
                                dataGridView2.DataSource = connect.sql_dataset.Tables[0];

                                // Display "ACCOUNT IS SUCCESSFULLY CREATED!"

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("REGISTRATION QUERY ERROR!");
                            }
                        }
                        else
                        {
                            UserExistError_Label.Visible = true;
                        }
                    }                   
                }
                else
                {
                    TermsUseError_Label.Visible = true;
                }
            }      
        }
    }
}
