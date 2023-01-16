using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuDefaultForm : Form
    {
        EzAccess connect = new EzAccess();
        private string DefaultPicPath = "C:\\Users\\Emil Calilung\\Documents\\GitHub\\EzAccess\\EzAccess Files\\Resources\\default 1x1.png";
        string picpath;
        int counter_reset = 0;

        string tempinput;
        bool NextScan = true;
        public MenuDefaultForm()
        {
            InitializeComponent();        
        }
        int test = 0;
        private void InputChecker_Tick(object sender, EventArgs e)
        {
            test = test + 1;
            textBox1.Text = Convert.ToString(test);
            if (NextScan == true)
            {
                if (BarNumTxtBox.Text != "")
                {
                    tempinput = BarNumTxtBox.Text;
                    reset();
                    BarNumTxtBox.Text = tempinput;
                    tempinput = "";
                    BarNumTxtBox.Focus();
                }

                NextScan = false;
            }
            if (counter_reset == 4)
            {
                reset();
            }
        }
        private void BarNumTxtBox_TextChanged(object sender, EventArgs e)
        {
            int length = 0;
            int lengthtemp = 0;
            length = BarNumTxtBox.Text.Length;

            if(length == 12)
            {
                bool NextScan = true;
                string temp = BarNumTxtBox.Text;
                BarNumTxtBox.Text = BarNumTxtBox.Text.ToUpper();
                //MessageBox.Show(temp);

                if (temp == "OPENMENU-TAB")
                {
                    Menu_Panel.Visible = true;
                    Identification_Panel.Visible = false;
                }
                else
                {
                    try
                    {
                        reset();
                        // query shits
                        connect.sql = "SELECT * FROM UserTable WHERE ID = '" + BarNumTxtBox.Text + "'";
                        connect.cmd();
                        connect.sqladapterSelect();
                        connect.sqlDataSetSelect_UserTable();

                        IDNumber_Label.Text = connect.sql_dataset.Tables[0].Rows[0][0].ToString();
                        GivenName_Label.Text = connect.sql_dataset.Tables[0].Rows[0][1].ToString() + " " + connect.sql_dataset.Tables[0].Rows[0][2].ToString();
                        SurName_Label.Text = connect.sql_dataset.Tables[0].Rows[0][3].ToString() + " " + connect.sql_dataset.Tables[0].Rows[0][4].ToString();
                        Occupation_Label.Text = connect.sql_dataset.Tables[0].Rows[0][9].ToString();
                        Status_Label.Text = connect.sql_dataset.Tables[0].Rows[0][10].ToString();
                        picpath = connect.sql_dataset.Tables[0].Rows[0][11].ToString();
                        PictureBox.Image = Image.FromFile(picpath);
                        
                        ResetTimer.Start();

                        if (Status_Label.Text == "Active")
                        {  
                            Verified_Panel.Visible = true;
                            Status_Label.ForeColor = Color.ForestGreen;                           
                        }
                        else
                        {
                            noAccess_Panel.Enabled = true;
                            Status_Label.ForeColor = Color.Khaki;       
                        }

                        // sql log query
                    }
                    catch (Exception)
                    {
                        reset();
                        ResetTimer.Start();
                        Alert_Panel.Visible = true;
                        Status_Label.ForeColor = Color.Crimson;
                    }
                    BarNumTxtBox.Text = "";
                }
            }
            BarNumTxtBox.Focus();
        }
        private void reset()
        {
            Status_Label.ForeColor = Color.Black;
            IDNumber_Label.Text = "";
            GivenName_Label.Text = "FirstName";
            SurName_Label.Text = "LastName";
            Occupation_Label.Text = "";
            Status_Label.Text = "";
            picpath = DefaultPicPath;
            PictureBox.Image = Image.FromFile(picpath);
            Alert_Panel.Visible = false;
            noAccess_Panel.Visible = false;
            Verified_Panel.Visible = false;
            ResetTimer.Stop();
            counter_reset = 0;
        }
        private void MenuDefaultForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            RealTime_Label.Text = DateTime.Now.ToLongTimeString();
            connect.connString();
            BarNumTxtBox.Select();
            Alert_Panel.Visible = false;
            noAccess_Panel.Visible = false;
            Verified_Panel.Visible = false;
            Menu_Panel.Visible = false;
            InputChecker.Start();
            reset();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            LogInForm logform = new LogInForm();
            logform.Show();
            this.Hide();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm regisfrm = new RegistrationForm();
            regisfrm.Show();
            this.Hide();
        }
        private void MenuDefaultForm_Click(object sender, EventArgs e)
        {
            BarNumTxtBox.Focus(); 
        }
        private void MenuDefaultForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            BarNumTxtBox.Focus();
        }     
        private void ButtonToCloseTab_Click(object sender, EventArgs e)
        {
            Menu_Panel.Visible = false;
            Identification_Panel.Visible = true;
        }
        private void RealTime_Label_Click(object sender, EventArgs e)
        {
            Menu_Panel.Visible = true;
            Identification_Panel.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            RealTime_Label.Text = DateTime.Now.ToLongTimeString();
        }
        private void ResetTimer_Tick(object sender, EventArgs e)
        {
            counter_reset = counter_reset + 1;
        }   
    }
}
