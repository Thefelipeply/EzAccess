namespace GUI
{
    partial class MenuDefaultForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuDefaultForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ButtonToCloseTab = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BarNumTxtBox = new System.Windows.Forms.TextBox();
            this.RealTime_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GivenName_Label = new System.Windows.Forms.Label();
            this.SurName_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDNumber_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Occupation_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Status_Label = new System.Windows.Forms.Label();
            this.Alert_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Verified_Panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.noAccess_Panel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Identification_Panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResetTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.Menu_Panel.SuspendLayout();
            this.Alert_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Verified_Panel.SuspendLayout();
            this.noAccess_Panel.SuspendLayout();
            this.Identification_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(12, 9);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(400, 400);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(146)))), ((int)(((byte)(137)))));
            this.Menu_Panel.Controls.Add(this.label7);
            this.Menu_Panel.Controls.Add(this.RegisterButton);
            this.Menu_Panel.Controls.Add(this.ButtonToCloseTab);
            this.Menu_Panel.Controls.Add(this.LoginButton);
            this.Menu_Panel.Location = new System.Drawing.Point(1011, 97);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(706, 284);
            this.Menu_Panel.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(276, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 55);
            this.label7.TabIndex = 62;
            this.label7.Text = "MENU";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RegisterButton.FlatAppearance.BorderSize = 2;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(35, 179);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(0);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(631, 72);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ButtonToCloseTab
            // 
            this.ButtonToCloseTab.BackColor = System.Drawing.Color.DarkCyan;
            this.ButtonToCloseTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToCloseTab.Location = new System.Drawing.Point(665, 0);
            this.ButtonToCloseTab.Name = "ButtonToCloseTab";
            this.ButtonToCloseTab.Size = new System.Drawing.Size(41, 23);
            this.ButtonToCloseTab.TabIndex = 1;
            this.ButtonToCloseTab.Text = "X";
            this.ButtonToCloseTab.UseVisualStyleBackColor = false;
            this.ButtonToCloseTab.Click += new System.EventHandler(this.ButtonToCloseTab_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 2;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(35, 86);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(631, 73);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BarNumTxtBox
            // 
            this.BarNumTxtBox.BackColor = System.Drawing.Color.White;
            this.BarNumTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BarNumTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarNumTxtBox.ForeColor = System.Drawing.Color.Black;
            this.BarNumTxtBox.Location = new System.Drawing.Point(133, 635);
            this.BarNumTxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.BarNumTxtBox.Name = "BarNumTxtBox";
            this.BarNumTxtBox.Size = new System.Drawing.Size(142, 31);
            this.BarNumTxtBox.TabIndex = 56;
            // 
            // RealTime_Label
            // 
            this.RealTime_Label.AutoSize = true;
            this.RealTime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealTime_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.RealTime_Label.Location = new System.Drawing.Point(-14, 4);
            this.RealTime_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RealTime_Label.Name = "RealTime_Label";
            this.RealTime_Label.Size = new System.Drawing.Size(395, 73);
            this.RealTime_Label.TabIndex = 58;
            this.RealTime_Label.Text = "TIMELABEL";
            this.RealTime_Label.Click += new System.EventHandler(this.RealTime_Label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(500, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "ID NUMBER:";
            // 
            // GivenName_Label
            // 
            this.GivenName_Label.AutoSize = true;
            this.GivenName_Label.BackColor = System.Drawing.Color.Transparent;
            this.GivenName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GivenName_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.GivenName_Label.Location = new System.Drawing.Point(477, 73);
            this.GivenName_Label.Name = "GivenName_Label";
            this.GivenName_Label.Size = new System.Drawing.Size(335, 55);
            this.GivenName_Label.TabIndex = 59;
            this.GivenName_Label.Text = "GIVEN NAME";
            // 
            // SurName_Label
            // 
            this.SurName_Label.AutoSize = true;
            this.SurName_Label.BackColor = System.Drawing.Color.Transparent;
            this.SurName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurName_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.SurName_Label.Location = new System.Drawing.Point(477, 119);
            this.SurName_Label.Name = "SurName_Label";
            this.SurName_Label.Size = new System.Drawing.Size(415, 55);
            this.SurName_Label.TabIndex = 59;
            this.SurName_Label.Text = "SURNAME SUFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(458, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 39);
            this.label3.TabIndex = 59;
            this.label3.Text = "HELLO,";
            // 
            // IDNumber_Label
            // 
            this.IDNumber_Label.AutoSize = true;
            this.IDNumber_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNumber_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.IDNumber_Label.Location = new System.Drawing.Point(620, 184);
            this.IDNumber_Label.Name = "IDNumber_Label";
            this.IDNumber_Label.Size = new System.Drawing.Size(62, 20);
            this.IDNumber_Label.TabIndex = 59;
            this.IDNumber_Label.Text = "IDnum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(486, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "OCCUPATION:";
            // 
            // Occupation_Label
            // 
            this.Occupation_Label.AutoSize = true;
            this.Occupation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Occupation_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.Occupation_Label.Location = new System.Drawing.Point(620, 207);
            this.Occupation_Label.Name = "Occupation_Label";
            this.Occupation_Label.Size = new System.Drawing.Size(73, 20);
            this.Occupation_Label.TabIndex = 59;
            this.Occupation_Label.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.label5.Location = new System.Drawing.Point(530, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "STATUS:";
            // 
            // Status_Label
            // 
            this.Status_Label.AutoSize = true;
            this.Status_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_Label.ForeColor = System.Drawing.Color.Black;
            this.Status_Label.Location = new System.Drawing.Point(620, 230);
            this.Status_Label.Name = "Status_Label";
            this.Status_Label.Size = new System.Drawing.Size(263, 31);
            this.Status_Label.TabIndex = 59;
            this.Status_Label.Text = "ACTIVE/INACTIVE";
            // 
            // Alert_Panel
            // 
            this.Alert_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.Alert_Panel.Controls.Add(this.label4);
            this.Alert_Panel.Location = new System.Drawing.Point(442, 287);
            this.Alert_Panel.Name = "Alert_Panel";
            this.Alert_Panel.Size = new System.Drawing.Size(663, 100);
            this.Alert_Panel.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(605, 55);
            this.label4.TabIndex = 59;
            this.label4.Text = "USER DOES NOT EXIST!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.RealTime_Label);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 63);
            this.panel2.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.label6.Location = new System.Drawing.Point(1173, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Made by: EzAccess";
            // 
            // Verified_Panel
            // 
            this.Verified_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(93)))), ((int)(((byte)(121)))));
            this.Verified_Panel.Controls.Add(this.label8);
            this.Verified_Panel.Location = new System.Drawing.Point(445, 275);
            this.Verified_Panel.Name = "Verified_Panel";
            this.Verified_Panel.Size = new System.Drawing.Size(663, 100);
            this.Verified_Panel.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(52, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(573, 42);
            this.label8.TabIndex = 59;
            this.label8.Text = "VERIFIED, PLEASE PROCEED";
            // 
            // noAccess_Panel
            // 
            this.noAccess_Panel.BackColor = System.Drawing.Color.Khaki;
            this.noAccess_Panel.Controls.Add(this.label9);
            this.noAccess_Panel.Location = new System.Drawing.Point(439, 304);
            this.noAccess_Panel.Name = "noAccess_Panel";
            this.noAccess_Panel.Size = new System.Drawing.Size(663, 100);
            this.noAccess_Panel.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(536, 42);
            this.label9.TabIndex = 59;
            this.label9.Text = "VERIFIED, BUT NO ACCESS";
            // 
            // Identification_Panel
            // 
            this.Identification_Panel.Controls.Add(this.PictureBox);
            this.Identification_Panel.Controls.Add(this.noAccess_Panel);
            this.Identification_Panel.Controls.Add(this.label3);
            this.Identification_Panel.Controls.Add(this.Alert_Panel);
            this.Identification_Panel.Controls.Add(this.Verified_Panel);
            this.Identification_Panel.Controls.Add(this.label2);
            this.Identification_Panel.Controls.Add(this.IDNumber_Label);
            this.Identification_Panel.Controls.Add(this.SurName_Label);
            this.Identification_Panel.Controls.Add(this.label1);
            this.Identification_Panel.Controls.Add(this.GivenName_Label);
            this.Identification_Panel.Controls.Add(this.Occupation_Label);
            this.Identification_Panel.Controls.Add(this.Status_Label);
            this.Identification_Panel.Controls.Add(this.label5);
            this.Identification_Panel.Location = new System.Drawing.Point(146, 164);
            this.Identification_Panel.Name = "Identification_Panel";
            this.Identification_Panel.Size = new System.Drawing.Size(1116, 422);
            this.Identification_Panel.TabIndex = 62;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetTimer
            // 
            this.ResetTimer.Interval = 1000;
            this.ResetTimer.Tick += new System.EventHandler(this.ResetTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 647);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 63;
            // 
            // MenuDefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Identification_Panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BarNumTxtBox);
            this.Controls.Add(this.panel2);
            this.Name = "MenuDefaultForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuDefaultForm_Load);
            this.Click += new System.EventHandler(this.MenuDefaultForm_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MenuDefaultForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.Menu_Panel.ResumeLayout(false);
            this.Menu_Panel.PerformLayout();
            this.Alert_Panel.ResumeLayout(false);
            this.Alert_Panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Verified_Panel.ResumeLayout(false);
            this.Verified_Panel.PerformLayout();
            this.noAccess_Panel.ResumeLayout(false);
            this.noAccess_Panel.PerformLayout();
            this.Identification_Panel.ResumeLayout(false);
            this.Identification_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseTab_Button;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox BarNumTxtBox;
        private System.Windows.Forms.Label RealTime_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label GivenName_Label;
        private System.Windows.Forms.Label SurName_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDNumber_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Occupation_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Status_Label;
        private System.Windows.Forms.Panel Alert_Panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonToCloseTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Verified_Panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel noAccess_Panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel Identification_Panel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer ResetTimer;
        private System.Windows.Forms.TextBox textBox1;
    }
}