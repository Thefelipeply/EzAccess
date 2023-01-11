using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace GUI
{
    public partial class MenuDefaultForm : Form
    {
        public MenuDefaultForm()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(BarNumTxtBox);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            BarNumTxtBox.Text = e.Barcode;
            MessageBox.Show(BarNumTxtBox.Text); // test lang to

            if (BarNumTxtBox.Text == "OPEN_TAB")
            {
                // will open the TAB selection (LOGIN/REGISTER)
            }
            else
            {
                // query shits
            }
            
        }

        private void MenuDefaultForm_Load(object sender, EventArgs e)
        {
            BarNumTxtBox.Select();
            Alert_Panel.Visible = false;
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
            Panel1.Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
