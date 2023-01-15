namespace GUI
{
    partial class FormConfirmation_UserForm
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
            this.UpdateUser = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.Label();
            this.NO = new System.Windows.Forms.Button();
            this.YES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateUser
            // 
            this.UpdateUser.AutoSize = true;
            this.UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUser.ForeColor = System.Drawing.Color.White;
            this.UpdateUser.Location = new System.Drawing.Point(35, 38);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(363, 24);
            this.UpdateUser.TabIndex = 1;
            this.UpdateUser.Text = "Are you sure you want to update info?";
            // 
            // ChangePass
            // 
            this.ChangePass.AutoSize = true;
            this.ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass.ForeColor = System.Drawing.Color.White;
            this.ChangePass.Location = new System.Drawing.Point(49, 38);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(337, 24);
            this.ChangePass.TabIndex = 1;
            this.ChangePass.Text = "Are you want to change password?";
            // 
            // NO
            // 
            this.NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.NO.FlatAppearance.BorderSize = 0;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO.ForeColor = System.Drawing.Color.White;
            this.NO.Location = new System.Drawing.Point(213, 91);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(198, 34);
            this.NO.TabIndex = 21;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // YES
            // 
            this.YES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.YES.FlatAppearance.BorderSize = 0;
            this.YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YES.ForeColor = System.Drawing.Color.White;
            this.YES.Location = new System.Drawing.Point(9, 91);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(198, 34);
            this.YES.TabIndex = 21;
            this.YES.Text = "YES";
            this.YES.UseVisualStyleBackColor = false;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // FormConfirmation_UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(423, 136);
            this.Controls.Add(this.YES);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.UpdateUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfirmation_UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfirmation_UserForn";
            this.Load += new System.EventHandler(this.FormConfirmation_UserForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateUser;
        private System.Windows.Forms.Label ChangePass;
        private System.Windows.Forms.Button NO;
        private System.Windows.Forms.Button YES;
    }
}