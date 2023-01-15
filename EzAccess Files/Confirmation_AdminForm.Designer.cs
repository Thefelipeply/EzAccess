namespace GUI
{
    partial class Confirmation_AdminForm
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
            this.ClearLogs = new System.Windows.Forms.Label();
            this.YES = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Label();
            this.ResetPass = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClearLogs
            // 
            this.ClearLogs.AutoSize = true;
            this.ClearLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLogs.ForeColor = System.Drawing.Color.White;
            this.ClearLogs.Location = new System.Drawing.Point(31, 31);
            this.ClearLogs.Name = "ClearLogs";
            this.ClearLogs.Size = new System.Drawing.Size(350, 24);
            this.ClearLogs.TabIndex = 3;
            this.ClearLogs.Text = "Are you sure you want to clear logs?";
            // 
            // YES
            // 
            this.YES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.YES.FlatAppearance.BorderSize = 0;
            this.YES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YES.ForeColor = System.Drawing.Color.White;
            this.YES.Location = new System.Drawing.Point(9, 90);
            this.YES.Name = "YES";
            this.YES.Size = new System.Drawing.Size(198, 34);
            this.YES.TabIndex = 22;
            this.YES.Text = "YES";
            this.YES.UseVisualStyleBackColor = false;
            this.YES.Click += new System.EventHandler(this.YES_Click);
            // 
            // NO
            // 
            this.NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.NO.FlatAppearance.BorderSize = 0;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO.ForeColor = System.Drawing.Color.White;
            this.NO.Location = new System.Drawing.Point(213, 90);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(198, 34);
            this.NO.TabIndex = 23;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.AutoSize = true;
            this.UpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUser.ForeColor = System.Drawing.Color.White;
            this.UpdateUser.Location = new System.Drawing.Point(9, 31);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(408, 24);
            this.UpdateUser.TabIndex = 3;
            this.UpdateUser.Text = "Are you sure you want to update this user?";
            // 
            // ResetPass
            // 
            this.ResetPass.AutoSize = true;
            this.ResetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPass.ForeColor = System.Drawing.Color.White;
            this.ResetPass.Location = new System.Drawing.Point(4, 33);
            this.ResetPass.Name = "ResetPass";
            this.ResetPass.Size = new System.Drawing.Size(416, 24);
            this.ResetPass.TabIndex = 3;
            this.ResetPass.Text = "Are you sure you want reset this user pass?";
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSize = true;
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser.ForeColor = System.Drawing.Color.White;
            this.DeleteUser.Location = new System.Drawing.Point(10, 34);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(402, 24);
            this.DeleteUser.TabIndex = 3;
            this.DeleteUser.Text = "Are you sure you want to delete this user?";
            // 
            // Confirmation_AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(192)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(423, 136);
            this.Controls.Add(this.YES);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.ResetPass);
            this.Controls.Add(this.UpdateUser);
            this.Controls.Add(this.ClearLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Confirmation_AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation_AdminForm";
            this.Load += new System.EventHandler(this.Confirmation_AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ClearLogs;
        private System.Windows.Forms.Button YES;
        private System.Windows.Forms.Button NO;
        private System.Windows.Forms.Label UpdateUser;
        private System.Windows.Forms.Label ResetPass;
        private System.Windows.Forms.Label DeleteUser;
    }
}