namespace LoginUI
{
    partial class fm_ForgetThree
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
            this.panel_form = new System.Windows.Forms.Panel();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel_form.Controls.Add(this.label_pass);
            this.panel_form.Controls.Add(this.label_password);
            this.panel_form.Controls.Add(this.label_username);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(0, 0);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(400, 130);
            this.panel_form.TabIndex = 1;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.ForeColor = System.Drawing.Color.DarkGray;
            this.label_pass.Location = new System.Drawing.Point(149, 84);
            this.label_pass.Name = "label_pass";
            this.label_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_pass.Size = new System.Drawing.Size(103, 25);
            this.label_pass.TabIndex = 2;
            this.label_pass.Text = "1df8c4m6";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.DarkGray;
            this.label_password.Location = new System.Drawing.Point(145, 41);
            this.label_password.Name = "label_password";
            this.label_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_password.Size = new System.Drawing.Size(111, 25);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "كلمة المرور";
            this.label_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.ForeColor = System.Drawing.Color.DarkGray;
            this.label_username.Location = new System.Drawing.Point(235, 19);
            this.label_username.Name = "label_username";
            this.label_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_username.Size = new System.Drawing.Size(109, 13);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "إسم المستخدم: فوفة";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fm_ForgetThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 130);
            this.Controls.Add(this.panel_form);
            this.Name = "fm_ForgetThree";
            this.Text = "ForgetThree";
            this.Load += new System.EventHandler(this.fm_ForgetThree_Load);
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
    }
}