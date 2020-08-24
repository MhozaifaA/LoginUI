namespace LoginUI
{
    partial class fm_ForgetOne
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
            this.btn_next = new System.Windows.Forms.Button();
            this.panel_forget = new System.Windows.Forms.Panel();
            this.label_check = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label_enteruser = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_form.SuspendLayout();
            this.panel_forget.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel_form.Controls.Add(this.btn_next);
            this.panel_form.Controls.Add(this.panel_forget);
            this.panel_form.Controls.Add(this.btn_close);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(0, 0);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(425, 200);
            this.panel_form.TabIndex = 0;
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(175, 160);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 30);
            this.btn_next.TabIndex = 7;
            this.btn_next.Text = "التالي<<";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel_forget
            // 
            this.panel_forget.Controls.Add(this.label_check);
            this.panel_forget.Controls.Add(this.txt_username);
            this.panel_forget.Controls.Add(this.label_enteruser);
            this.panel_forget.Location = new System.Drawing.Point(12, 25);
            this.panel_forget.Name = "panel_forget";
            this.panel_forget.Size = new System.Drawing.Size(400, 130);
            this.panel_forget.TabIndex = 5;
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.ForeColor = System.Drawing.Color.Red;
            this.label_check.Location = new System.Drawing.Point(183, 60);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(34, 13);
            this.label_check.TabIndex = 7;
            this.label_check.Text = "check";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(76, 87);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(249, 20);
            this.txt_username.TabIndex = 5;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_enteruser
            // 
            this.label_enteruser.AutoSize = true;
            this.label_enteruser.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enteruser.ForeColor = System.Drawing.Color.DarkGray;
            this.label_enteruser.Location = new System.Drawing.Point(100, 16);
            this.label_enteruser.Name = "label_enteruser";
            this.label_enteruser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_enteruser.Size = new System.Drawing.Size(200, 25);
            this.label_enteruser.TabIndex = 4;
            this.label_enteruser.Text = "أدخل اسم المستخدم";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Location = new System.Drawing.Point(402, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "btn_close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // fm_ForgetOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 200);
            this.Controls.Add(this.panel_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_ForgetOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgotPassword";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fm_ForgotPassword_Load);
            this.panel_form.ResumeLayout(false);
            this.panel_forget.ResumeLayout(false);
            this.panel_forget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label_enteruser;
        private System.Windows.Forms.Label label_check;
        public System.Windows.Forms.Panel panel_forget;
        private System.Windows.Forms.Button btn_next;
    }
}