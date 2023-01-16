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
    public partial class FormConfirmation_UserForm : Form
    {
        public FormConfirmation_UserForm()
        {
            InitializeComponent();
        }
        string request = "";
        public static bool SystemConfirmation = false;
        private void FormConfirmation_UserForn_Load(object sender, EventArgs e)
        {
            request = UserForm.ConfirmUpdate;
            if (request == "UpdateUser")
            {
                UpdateUser.Visible = true;
                ChangePass.Visible = false;
            }
            else if(request == "UpdatePass")
            {
                UpdateUser.Visible = false;
                ChangePass.Visible = true;
            }
            UserForm.ConfirmUpdate = "";
        }

        private void YES_Click(object sender, EventArgs e)
        {
            SystemConfirmation = true;
            this.Close();
        }

        private void NO_Click(object sender, EventArgs e)
        {
            SystemConfirmation = false;
            this.Close();
        }
    }
}
