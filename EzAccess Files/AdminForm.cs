using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class AdminForm : Form
    {
        EzAccess connect = new EzAccess();
        private string PicPath;
        private Image DefaultPic;
        PrintPreviewDialog PreviewDialog = new PrintPreviewDialog();
        

        public AdminForm()
        {
            
            connect.connString();
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
            UpdatedPanel.Hide();
            PicPath_TextBox.Hide();
            IDPicPath_TextBox.Hide();
            Disable();

            TimeSmall_Label.Visible = false;
            Logs_Panel.Visible = false;
            Users_Panel.Visible = false;
            PrintID_Panel.Visible = false;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSmall_Label.Text = DateTime.Now.ToLongTimeString();
            TimeLarge_Label.Text = DateTime.Now.ToLongTimeString();
        }

        private void Users_Button_Click(object sender, EventArgs e)
        {
            if (Users_Panel.Visible == false)
            {
                TimeSmall_Label.Visible = true;
                Logs_Panel.Visible = false;
                Users_Panel.Visible = true;
                PrintID_Panel.Visible = false;
            }
            else
            {
                TimeSmall_Label.Visible = false;
                Logs_Panel.Visible = false;
                Users_Panel.Visible = false;
                PrintID_Panel.Visible = false;
            }
            
        }
        private void PrintID_Click(object sender, EventArgs e)
        {
            if (PrintID_Panel.Visible == false)
            {
                TimeSmall_Label.Visible = true;
                Logs_Panel.Visible = false;
                Users_Panel.Visible = false;
                PrintID_Panel.Visible = true;
            }
            else
            {
                TimeSmall_Label.Visible = false;
                Logs_Panel.Visible = false;
                Users_Panel.Visible = false;
                PrintID_Panel.Visible = false;
            }
        }

        private void Logs_Button_Click(object sender, EventArgs e)
        {
            if (Logs_Panel.Visible == false)
            {
                TimeSmall_Label.Visible = true;
                Logs_Panel.Visible = true;
                Users_Panel.Visible = false;
                PrintID_Panel.Visible = false;
            }
            else
            {
                TimeSmall_Label.Visible = false;
                Logs_Panel.Visible = false;
                Users_Panel.Visible = false;
                PrintID_Panel.Visible = false;
            }
        }
        private void DataGridUpdate()
        {
            connect.UserSelect();
            connect.cmd();
            connect.sqladapterSelect();
            connect.sqlDataSetSelect_UserTable();
            dataGridView3.DataSource = connect.sql_dataset.Tables[0];

            connect.LogsSelect();
            connect.cmd();
            connect.sqladapterSelect();
            connect.sqlDataSetSelect_LogsTable();
            dataGridView2.DataSource = connect.sql_dataset.Tables[0];
        }
        private void Clear()
        {
            // change loc file if using different pc
            DefaultPic = Image.FromFile("C:\\Users\\Emil Calilung\\Documents\\GitHub\\EzAccess\\EzAccess Files\\Resources\\default 1x1.png");
            PictureBox.Image = DefaultPic;

            UserID_TextBox.Clear();
            GivenName_TextBox.Clear();
            MiddleName_TextBox.Clear();
            Surname_TextBox.Clear();
            Suffix_Textbox.Clear();
            Age_TextBox.Clear();
            Sex_ComboBox.Text = "";
            Address_TextBox.Clear();
            Email_TextBox.Clear();
            Occupation_ComboBox.Text = "";
            Status_ComboBox.Text = "";

            DataGridUpdate();
        }
        private void Disable()
        {
            GivenName_TextBox.Enabled = false;
            MiddleName_TextBox.Enabled = false;
            Surname_TextBox.Enabled = false;
            Suffix_Textbox.Enabled = false;
            Age_TextBox.Enabled = false;
            Sex_ComboBox.Enabled = false;
            Address_TextBox.Enabled = false;
            Email_TextBox.Enabled = false;
            Occupation_ComboBox.Enabled = false;
            Status_ComboBox.Enabled = false;
            PictureBox.Enabled = false;

            UpdateUser_Button.Enabled = false;
            DeleteUser_Button.Enabled = false;
            ResetPass_Button.Enabled = false;
        }
        private void Enable()
        {
            GivenName_TextBox.Enabled = true;
            MiddleName_TextBox.Enabled = true;
            Surname_TextBox.Enabled = true;
            Suffix_Textbox.Enabled = true;
            Age_TextBox.Enabled = true;
            Sex_ComboBox.Enabled = true;
            Address_TextBox.Enabled = true;
            Email_TextBox.Enabled = true;
            Occupation_ComboBox.Enabled = true;
            Status_ComboBox.Enabled = true;
            PictureBox.Enabled = true;

            UpdateUser_Button.Enabled = true;
            DeleteUser_Button.Enabled = true;
            ResetPass_Button.Enabled = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LogInForm loginform = new LogInForm();
            loginform.Show();
            this.Hide();
        }

        //USER Panel
        private void ResetPass_Button_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.Show();
            this.Hide();
        }
        private void UpdateUser_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this user?", "Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connect.sql = "UPDATE UserTable SET " +
                    "FirstName = '" + GivenName_TextBox.Text + "', " +
                    "MiddleName = '" + MiddleName_TextBox.Text + "', " +
                    "LastName = '" + Surname_TextBox.Text + "', " +
                    "Suffix = '" + Suffix_Textbox.Text + "', " +
                    "Age = '" + Age_TextBox.Text + "', " +
                    "Sex = '" + Sex_ComboBox.Text + "', " +
                    "Address = '" + Address_TextBox.Text + "', " +
                    "Email = '" + Email_TextBox.Text + "', " +
                    "Occupation = '" + Occupation_ComboBox.Text + "', " +
                    "Status = '" + Status_ComboBox.Text + "', " +
                    "PicturePath = '" + PicPath_TextBox.Text + "' " +
                    "WHERE ID = '" + UserID_TextBox.Text + "'";
                connect.cmd();
                connect.sqladapterUpdate();

                DataGridUpdate();
                UpdatedPanel.Show();
                Disable();
            }
        }
        private void DeleteUser_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connect.sql = "DELETE FROM UserTable WHERE UserTable.ID = '" + UserID_TextBox.Text + "'";
                connect.cmd();
                connect.sqladapterDelete();

                Disable();
                Clear();
            }
        }
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            UpdatedPanel.Hide();
            Disable();
            Clear();
        }
        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                connect.sql = "SELECT * FROM UserTable WHERE UserTable.ID = '" + UserID_TextBox.Text + "'";
                connect.cmd();
                connect.sqladapterSelect();
                connect.sqlDataSetSelect_UserTable();

                UserID_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][0].ToString();
                GivenName_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][1].ToString();
                MiddleName_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][2].ToString();
                Surname_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][3].ToString();
                Suffix_Textbox.Text = connect.sql_dataset.Tables[0].Rows[0][4].ToString();
                Age_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][5].ToString();
                Sex_ComboBox.Text = connect.sql_dataset.Tables[0].Rows[0][6].ToString();
                Address_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][7].ToString();
                Email_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][8].ToString();
                Occupation_ComboBox.Text = connect.sql_dataset.Tables[0].Rows[0][9].ToString();
                Status_ComboBox.Text = connect.sql_dataset.Tables[0].Rows[0][10].ToString();
                PicPath_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][11].ToString();
                if (PicPath_TextBox.Text == "")
                {
                    PictureBox.Image = DefaultPic;
                }
                else
                {
                    PictureBox.Image = Image.FromFile(PicPath_TextBox.Text);
                }
                UpdatedPanel.Hide();
                Enable();
            }
            catch
            {
                MessageBox.Show("ID not found");
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File | *.gif; *.jpg; *.png; *.jfif; *.bmp";
            openFileDialog1.ShowDialog();

            PictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            PicPath = openFileDialog1.FileName;
            PicPath_TextBox.Text = PicPath;
        }

        //PRINT ID Panel
        private void PrintSearch_Button_Click(object sender, EventArgs e)
        {
            connect.sql = "SELECT * FROM UserTable WHERE UserTable.ID = '" + UserIDPrev_TextBox.Text + "'";
            connect.cmd();
            connect.sqladapterSelect();
            connect.sqlDataSetSelect_UserTable();

            ID_Number.Text = connect.sql_dataset.Tables[0].Rows[0][0].ToString();

            ID_FullName.Text =
               connect.sql_dataset.Tables[0].Rows[0][1].ToString() + " " +
               connect.sql_dataset.Tables[0].Rows[0][2].ToString() + " " +
               connect.sql_dataset.Tables[0].Rows[0][3].ToString() + " " +
               connect.sql_dataset.Tables[0].Rows[0][4].ToString();

            ID_Age.Text = connect.sql_dataset.Tables[0].Rows[0][5].ToString();
            ID_Sex.Text = connect.sql_dataset.Tables[0].Rows[0][6].ToString();
            ID_Address.Text = connect.sql_dataset.Tables[0].Rows[0][7].ToString();
            ID_Occupation.Text = connect.sql_dataset.Tables[0].Rows[0][9].ToString();
            IDPicPath_TextBox.Text = connect.sql_dataset.Tables[0].Rows[0][11].ToString();

            if (IDPicPath_TextBox.Text == "")
            {
                IDpicBox.Image = DefaultPic;
            }
            else
            {
                IDpicBox.Image = Image.FromFile(IDPicPath_TextBox.Text);
            }
            //bar code
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            BarCode_PicBox.Image = barcode.Draw(ID_Number.Text, 50);

        }
        
        private void PRINT_Button_Click(object sender, EventArgs e)
        {
            // save pic command
            /*
            using (var bmp = new Bitmap(IdPanel.Width, IdPanel.Height))
            {
                IdPanel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"IDS/" + ID_Number.Text + ".bmp");
            }
            */

            Print(this.ID_Panel);

        }


        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        Panel Panel = null;
        Bitmap memorying;
        public void Print(Panel pn1)
        {
            PrinterSettings ps = new PrinterSettings();
            Panel = pn1;
            getptrinarea(pn1);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();
        }
        public void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
                
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 4) - (this.ID_Panel.Width / 4), 0);
            
        }
        public void getptrinarea(Panel pn1)
        {
            memorying = new Bitmap(pn1.Width, pn1.Height);
            pn1.DrawToBitmap(memorying, new Rectangle(0, 0, pn1.Width, pn1.Height));
        }
        
        //LOGS Panel
        private void Cleaner_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to clear logs?", "Logs Cleaner", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connect.sql = "DELETE FROM LogsTable";
                connect.cmd();
                connect.sqladapterDelete();

                DataGridUpdate();
            }
        }

        private void KeywordSearch_Button_Click(object sender, EventArgs e)
        {

        }

        private void Keyword_TextBox_Enter(object sender, EventArgs e)
        {
            Keyword_TextBox.Text = "";
        }

        private void Keyword_TextBox_Leave(object sender, EventArgs e)
        {
            if (Keyword_TextBox.Text == "")
            {
                Keyword_TextBox.Text = "Keyword";
            }
        }
    }
}
