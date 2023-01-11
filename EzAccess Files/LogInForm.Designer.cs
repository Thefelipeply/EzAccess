namespace GUI
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.logInBtn = new System.Windows.Forms.Button();
            this.password_Txtbox = new System.Windows.Forms.TextBox();
            this.username_TxtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Warning_Panel = new System.Windows.Forms.Panel();
            this.CloseError_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Warning_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(11, 672);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(118, 46);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.Location = new System.Drawing.Point(93, 507);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(324, 32);
            this.logInBtn.TabIndex = 49;
            this.logInBtn.Text = "LOG IN";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // password_Txtbox
            // 
            this.password_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Txtbox.ForeColor = System.Drawing.Color.DimGray;
            this.password_Txtbox.Location = new System.Drawing.Point(93, 451);
            this.password_Txtbox.Name = "password_Txtbox";
            this.password_Txtbox.Size = new System.Drawing.Size(324, 31);
            this.password_Txtbox.TabIndex = 47;
            this.password_Txtbox.Text = "Password";
            this.password_Txtbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password_Txtbox_MouseClick);
            this.password_Txtbox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.password_Txtbox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // username_TxtBox
            // 
            this.username_TxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_TxtBox.ForeColor = System.Drawing.Color.DimGray;
            this.username_TxtBox.Location = new System.Drawing.Point(93, 392);
            this.username_TxtBox.Name = "username_TxtBox";
            this.username_TxtBox.Size = new System.Drawing.Size(324, 31);
            this.username_TxtBox.TabIndex = 45;
            this.username_TxtBox.Text = "Username";
            this.username_TxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_TxtBox_MouseClick);
            this.username_TxtBox.Enter += new System.EventHandler(this.username_TxtBox_Enter);
            this.username_TxtBox.Leave += new System.EventHandler(this.username_TxtBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Warning_Panel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.username_TxtBox);
            this.panel1.Controls.Add(this.password_Txtbox);
            this.panel1.Controls.Add(this.logInBtn);
            this.panel1.Location = new System.Drawing.Point(829, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 734);
            this.panel1.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "User";
            // 
            // Warning_Panel
            // 
            this.Warning_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.Warning_Panel.Controls.Add(this.CloseError_Button);
            this.Warning_Panel.Controls.Add(this.label1);
            this.Warning_Panel.Location = new System.Drawing.Point(75, 578);
            this.Warning_Panel.Name = "Warning_Panel";
            this.Warning_Panel.Size = new System.Drawing.Size(375, 34);
            this.Warning_Panel.TabIndex = 50;
            // 
            // CloseError_Button
            // 
            this.CloseError_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.CloseError_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseError_Button.ForeColor = System.Drawing.Color.Gray;
            this.CloseError_Button.Location = new System.Drawing.Point(339, 0);
            this.CloseError_Button.Name = "CloseError_Button";
            this.CloseError_Button.Size = new System.Drawing.Size(35, 34);
            this.CloseError_Button.TabIndex = 51;
            this.CloseError_Button.Text = "X";
            this.CloseError_Button.UseVisualStyleBackColor = false;
            this.CloseError_Button.Click += new System.EventHandler(this.CloseError_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You entered incorrect username or password!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 122);
            this.label3.TabIndex = 0;
            this.label3.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(151, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(547, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(317, 73);
            this.dataGridView1.TabIndex = 52;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Warning_Panel.ResumeLayout(false);
            this.Warning_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.TextBox password_Txtbox;
        private System.Windows.Forms.TextBox username_TxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Warning_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseError_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}