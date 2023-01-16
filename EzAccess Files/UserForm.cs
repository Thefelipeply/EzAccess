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
    public partial class UserForm : Form
    {        
        EzAccess connect = new EzAccess();

        public UserForm()
        {
            connect.connString();
            InitializeComponent();
        }

        string Username;
        string IDNumber;
        private void UserForm_Load(object sender, EventArgs e)
        {
            ChangePass_Panel.Visible = false;
            UserInfo_Panel.Visible = false;
            ConfirmUpdate = "";

            //dataGridView1.Visible = false;
            //dataGridView2.Visible = false;
            Username = LogInForm.SendUsername;
            Username_Textbox.Text = Username;

            connect.sql = "SELECT * FROM LoginTable WHERE CONVERT(VARCHAR, Username) = '" + Username + "'";
            connect.cmd();
            connect.sqladapterSelect();
            connect.sqlDataSetSelect_LoginTable();
            dataGridView2.DataSource = connect.sql_dataset.Tables[0];
     
            IDNumber = connect.sql_dataset.Tables[0].Rows[0][0].ToString();

            connect.sql = "SELECT * FROM UserTable WHERE ID = '" + IDNumber + "'";
            connect.cmd();
            connect.sqladapterSelect();
            connect.sqlDataSetSelect_UserTable();
            dataGridView1.DataSource = connect.sql_dataset.Tables[0];

            IDNum_Label.Text = connect.sql_dataset.Tables[0].Rows[0][0].ToString();
            FirstName_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][1].ToString();
            MiddleName_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][2].ToString();
            LastName_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][3].ToString();
            Suffix_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][4].ToString();
            Age_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][5].ToString();
            Sex_CombBox.Text = connect.sql_dataset.Tables[0].Rows[0][6].ToString();
            Address_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][7].ToString();
            Email_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][8].ToString();
            Occupation_CombBox.Text = connect.sql_dataset.Tables[0].Rows[0][9].ToString();
            Status_Label.Text = connect.sql_dataset.Tables[0].Rows[0][10].ToString();
            Picpath_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][11].ToString();
            pictureBox2.Image = Image.FromFile(Picpath_TextBox.Text);

            // sql query in logs
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.bmp; *.jfif; *.jpeg;";
                openFileDialog1.ShowDialog();
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                Picpath_TextBox.Text = openFileDialog1.FileName;
            }
            catch (Exception)
            {
                // display form with warnings no images selected
                MessageBox.Show("LOLS");
            }     
        }
        public static string ConfirmUpdate = "";
       private void Update_Button_Click(object sender, EventArgs e)
        {
            ConfirmUpdate = "UpdateUser";
            FormConfirmation_UserForm confirmForm = new FormConfirmation_UserForm();
            confirmForm.ShowDialog();
            if (FormConfirmation_UserForm.SystemConfirmation == true)
            {
                connect.sql = "UPDATE UserTable SET " +
                               "FirstName = '" + FirstName_Textbox.Text + "', " +
                               "MiddleName = '" + FirstName_Textbox.Text + "', " +
                               "LastName = '" + LastName_Textbox.Text + "', " +
                               "Suffix = '" + Suffix_Textbox.Text + "', " +
                               "Age = '" + Age_Textbox.Text + "', " +
                               "Sex = '" + Sex_CombBox.Text + "', " +
                               "Address = '" + Address_Textbox.Text + "', " +
                               "Email = '" + Email_Textbox.Text + "', " +
                               "Occupation = '" + Occupation_CombBox.Text + "', " +
                               "PicturePath = '" + Picpath_TextBox.Text + "' " +
                               "WHERE ID = '" + IDNum_Label.Text + "'";
                connect.cmd();
                connect.sqladapterUpdate();
                Updated_Label.Visible = true;
                FormConfirmation_UserForm.SystemConfirmation = false;

                // sql query in logs
            }
        }

        private void LogOut_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logInfrm = new LogInForm();
            logInfrm.Show();     
        }

        private void ChangePassClose_Button_Click(object sender, EventArgs e)
        {
            ChangePass_Panel.Visible = false;
            Main_Panel.Visible = true;
        }

        private void CloseUserForm_Button_Click(object sender, EventArgs e)
        {
            UserInfo_Panel.Visible = false;
            Main_Panel.Visible = true;
        }

        private void UpdateInfo_Button_Click(object sender, EventArgs e)
        {
            UserInfo_Panel.Visible = true;
            Main_Panel.Visible = false;
            Updated_Label.Visible = false;
        }

        private void ChangePass_Button_Click(object sender, EventArgs e)
        {
            ChangePass_Panel.Visible = true;
            Main_Panel.Visible = false;
            PasswordChange.Visible = false;
            Password_Textbox.Text = "";
            NewPass_Textbox.Text = "";
            ConfirmNewPass_Textbox.Text = "";
        }

        private void ChangePassword_Button_Click(object sender, EventArgs e)
        {
            connect.sql = "SELECT * FROM LoginTable WHERE ID = '" + IDNumber + "'";
            connect.cmd();
            connect.sqladapterSelect();
            connect.sqlDataSetSelect_LoginTable();

            string pass = Address_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][2].ToString();
            if (pass == Password_Textbox.Text)
            {
                if (NewPass_Textbox.Text == ConfirmNewPass_Textbox.Text)
                {
                    ConfirmUpdate = "UpdatePass";
                    FormConfirmation_UserForm confirmForm = new FormConfirmation_UserForm();
                    confirmForm.ShowDialog();

                    if(FormConfirmation_UserForm.SystemConfirmation == true)
                    {
                        connect.sql = "UPDATE LoginTable SET " +
                                  "Password = '" + NewPass_Textbox.Text + "' " +
                                  "WHERE ID = '" + IDNum_Label.Text + "'";
                        connect.cmd();
                        connect.sqladapterUpdate();
                        Password_Textbox.Text = "";
                        ConfirmNewPass_Textbox.Text = "";
                        NewPass_Textbox.Text = "";
                        PasswordChange.Visible = true;
                        FormConfirmation_UserForm.SystemConfirmation = false;

                        // sql query in logs
                    }
                }
                else
                {
                    MessageBox.Show("New Passwords does not match");
                    ConfirmNewPass_Textbox.Clear();
                    ConfirmNewPass_Textbox.Focus();
                }
            }
            else
            {
                Password_Textbox.Text = "";
                MessageBox.Show("Wrong pass!");
            }          
        }
    }
}
