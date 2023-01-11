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
    public partial class LogInForm : Form
    {        
        EzAccess connect = new EzAccess();

        public LogInForm()
        {
            connect.connString();
            InitializeComponent();
        }
        public static string SendUsername = "";

        private void LogInForm_Load(object sender, EventArgs e)
        {
            SendUsername = "";
            Warning_Panel.Hide();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            string AccountType = "";

            try{
                //connect.sql = "SELECT * FROM LoginTable WHERE Username = '" + username_TxtBox.Text + "', Password = '" + password_Txtbox.Text + "', '";
                connect.sql = "SELECT * FROM LoginTable WHERE CONVERT(varchar, Username) = '" + username_TxtBox.Text + "' AND " +
                    "CONVERT(varchar, Password) = '" + password_Txtbox.Text + "'";
                connect.cmd();
                connect.sqladapterSelect();
                connect.sqlDataSetSelect_LoginTable();


                dataGridView1.DataSource = connect.sql_dataset.Tables[0];
                AccountType = connect.sql_dataset.Tables[0].Rows[0][3].ToString();
                SendUsername = username_TxtBox.Text;

                if (AccountType == "Admin")
                {
                    
                    this.Hide();
                    AdminForm Admin_Form = new AdminForm();
                    Admin_Form.ShowDialog();
                }
                else if (AccountType == "User")
                {
                    
                    this.Hide();
                    UserForm User_Form = new UserForm();
                    User_Form.ShowDialog();
                }

            }
            catch (Exception)
            {
                Warning_Panel.Visible = true;
            }          
        }
                

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (password_Txtbox.Text == "")
            {
                password_Txtbox.Text = "Password";
                password_Txtbox.ForeColor = Color.DimGray;
                password_Txtbox.PasswordChar = '\0';
            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (password_Txtbox.Text == "")
            {
                password_Txtbox.Text = "Password";
                password_Txtbox.ForeColor = Color.DimGray;
                password_Txtbox.PasswordChar = '\0';
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuDefaultForm Defaultform = new MenuDefaultForm();
            Defaultform.ShowDialog();
            
        }

        private void username_TxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            username_TxtBox.ForeColor = Color.Black;
            if(username_TxtBox.Text == "Username")
            {
                username_TxtBox.Text = "";
            }
        }

        private void password_Txtbox_MouseClick(object sender, MouseEventArgs e)
        {
            password_Txtbox.ForeColor = Color.Black;
            if (password_Txtbox.Text == "Password")
            {
                password_Txtbox.Text = "";
            }
            password_Txtbox.PasswordChar = '*';
        }

        private void username_TxtBox_Leave(object sender, EventArgs e)
        {
            if (username_TxtBox.Text == "")
            {
                username_TxtBox.Text = "Username";
                username_TxtBox.ForeColor = Color.DimGray;
            }
        }

        private void username_TxtBox_Enter(object sender, EventArgs e)
        {
            if (username_TxtBox.Text == "")
            {
                username_TxtBox.Text = "Username";
                username_TxtBox.ForeColor = Color.DimGray;
            }
        }

        private void CloseError_Button_Click(object sender, EventArgs e)
        {
            Warning_Panel.Visible = false;
        }
    }
}
