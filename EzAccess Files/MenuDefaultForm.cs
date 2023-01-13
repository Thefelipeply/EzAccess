using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace GUI
{
    public partial class MenuDefaultForm : Form
    {
        EzAccess connect = new EzAccess();
        private string DefaultPicPath = "";
        string picpath;
        int counter_reset = 0;
        string barcodetemp;
        public MenuDefaultForm()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(BarNumTxtBox);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            BarNumTxtBox.Text = e.Barcode;
            //MessageBox.Show(BarNumTxtBox.Text); // test lang to
            string temp = BarNumTxtBox.Text.ToUpper(); 
            MessageBox.Show(temp);
            
            if (temp == "OPENMENUTAB")
            {
                Menu_Panel.Visible = true;
                Identification_Panel.Visible = false;
            }
            else
            {
                
                barcodetemp = BarNumTxtBox.Text;
                // query shits
                connect.sql = "SELECT * FROM UserTable WHERE UserTable.ID = '" + BarNumTxtBox.Text + "'";
                connect.cmd();
                connect.sqladapterSelect();
                connect.sqlDataSetSelect_UserTable();

                IDNumber_Label.Text = connect.sql_dataset.Tables[0].Rows[0][0].ToString();
                GivenName_Label.Text = connect.sql_dataset.Tables[0].Rows[0][1].ToString() + " " + connect.sql_dataset.Tables[0].Rows[0][2].ToString();
                SurName_Label.Text = connect.sql_dataset.Tables[0].Rows[0][3].ToString() + " " + connect.sql_dataset.Tables[0].Rows[0][4].ToString();
                Occupation_Label.Text = connect.sql_dataset.Tables[0].Rows[0][9].ToString();
                Status_Label.Text = connect.sql_dataset.Tables[0].Rows[0][10].ToString();
                picpath = connect.sql_dataset.Tables[0].Rows[0][10].ToString();
                PictureBox.Image = Image.FromFile(picpath);
                ResetTimer.Start();
                if (Status_Label.Text == "Active")
                {
                    Verified_Panel.Visible = true;
                    Status_Label.ForeColor = Color.ForestGreen;
                    while (counter_reset != 4)
                    {
                        if (BarNumTxtBox.Text != barcodetemp)
                        {
                            counter_reset = 4;
                            reset();
                        }
                        if (counter_reset == 3)
                        {
                            reset();
                        }
                    }
                }
                else
                {
                    noAccess_Panel.Enabled = true;
                    Status_Label.ForeColor = Color.Khaki;
                    while (counter_reset != 4)
                    {
                        if (BarNumTxtBox.Text != barcodetemp)
                        {
                            counter_reset = 4;
                            reset();
                        }
                        if (counter_reset == 3)
                        {
                            reset();
                        }
                    }
                }
                ResetTimer.Stop();
                counter_reset = 0;
                /*
                try
                {

                }
                catch (Exception)
                {
                    Alert_Panel.Visible = true;
                    Status_Label.ForeColor = Color.Crimson;
                    while (counter_reset != 4)
                    {
                        if (BarNumTxtBox.Text != barcodetemp)
                        {
                            counter_reset = 4;
                            reset();
                        }
                        if (counter_reset == 3)
                        {
                            reset();
                        }
                    }
                }
                */
                
            }
            
        }

        private void reset()
        {
            IDNumber_Label.Text = "UNKNOWN";
            GivenName_Label.Text = "FirstName";
            SurName_Label.Text = "LastName";
            Occupation_Label.Text = "UNKNOWN";
            Status_Label.Text = "UNKNOWN";
            picpath = DefaultPicPath;
            PictureBox.Image = Image.FromFile(picpath);
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
