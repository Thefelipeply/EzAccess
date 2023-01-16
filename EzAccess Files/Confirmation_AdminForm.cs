using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Confirmation_AdminForm : Form
    {
        public Confirmation_AdminForm()
        {
            InitializeComponent();
        }
        string request = "";
        public static bool ReturnRequest = false;
        private void Confirmation_AdminForm_Load(object sender, EventArgs e)
        {
            ClearLogs.Visible = false;
            UpdateUser.Visible = false;
            ResetPass.Visible = false;
            DeleteUser.Visible = false;
            request = AdminForm.request;
            if (request == "ClearLogs")
            {
                ClearLogs.Visible = true;
                UpdateUser.Visible = false;
                ResetPass.Visible = false;
                DeleteUser.Visible = false;
            }
            else if (request == "UpdateUser")
            {
                ClearLogs.Visible = false;
                UpdateUser.Visible = true;
                ResetPass.Visible = false;
                DeleteUser.Visible = false;
            }
            else if (request == "ResetPass")
            {
                ClearLogs.Visible = false;
                UpdateUser.Visible = false;
                ResetPass.Visible = true;
                DeleteUser.Visible = false;
            }
            else if (request == "DeleteUser")
            {
                ClearLogs.Visible = false;
                UpdateUser.Visible = false;
                ResetPass.Visible = false;
                DeleteUser.Visible = true;
            }

            AdminForm.request = "";

        }

        private void NO_Click(object sender, EventArgs e)
        {
            ReturnRequest = false;
            this.Close();
        }

        private void YES_Click(object sender, EventArgs e)
        {
            ReturnRequest = true;
            this.Close();
        }
    }
}
