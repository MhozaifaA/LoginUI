namespace LoginUI
{
    partial class fm_Login
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
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel_login = new System.Windows.Forms.Panel();
            this.panel_manual = new System.Windows.Forms.Panel();
            this.panel_create = new System.Windows.Forms.Panel();
            this.panel_CreateLabel = new System.Windows.Forms.Panel();
            this.label_create = new System.Windows.Forms.Label();
            this.panel_bottonCreate = new System.Windows.Forms.Panel();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_eye = new System.Windows.Forms.Button();
            this.label_powred = new System.Windows.Forms.Label();
            this.label_aboutas = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_form = new System.Windows.Forms.Label();
            this.label_forget = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_border = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer_manual = new System.Windows.Forms.Timer(this.components);
            this.panel_form.SuspendLayout();
            this.panel_login.SuspendLayout();
            this.panel_manual.SuspendLayout();
            this.panel_CreateLabel.SuspendLayout();
            this.panel_bottonCreate.SuspendLayout();
            this.panel_border.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_form
            // 
            this.panel_form.Controls.Add(this.panel_login);
            this.panel_form.Controls.Add(this.panel_bottom);
            this.panel_form.Controls.Add(this.panel_border);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(0, 0);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(425, 550);
            this.panel_form.TabIndex = 0;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.panel_manual);
            this.panel_login.Controls.Add(this.btn_eye);
            this.panel_login.Controls.Add(this.label_powred);
            this.panel_login.Controls.Add(this.label_aboutas);
            this.panel_login.Controls.Add(this.checkBox1);
            this.panel_login.Controls.Add(this.label_form);
            this.panel_login.Controls.Add(this.label_forget);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.txt_password);
            this.panel_login.Controls.Add(this.txt_username);
            this.panel_login.Controls.Add(this.shapeContainer1);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Location = new System.Drawing.Point(0, 25);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(425, 515);
            this.panel_login.TabIndex = 7;
            this.panel_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_login_MouseDown);
            // 
            // panel_manual
            // 
            this.panel_manual.Controls.Add(this.panel_create);
            this.panel_manual.Controls.Add(this.panel_CreateLabel);
            this.panel_manual.Controls.Add(this.panel_bottonCreate);
            this.panel_manual.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_manual.Location = new System.Drawing.Point(0, 0);
            this.panel_manual.Name = "panel_manual";
            this.panel_manual.Size = new System.Drawing.Size(425, 25);
            this.panel_manual.TabIndex = 10;
            // 
            // panel_create
            // 
            this.panel_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel_create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_create.Location = new System.Drawing.Point(0, 0);
            this.panel_create.Name = "panel_create";
            this.panel_create.Size = new System.Drawing.Size(425, 0);
            this.panel_create.TabIndex = 12;
            // 
            // panel_CreateLabel
            // 
            this.panel_CreateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel_CreateLabel.Controls.Add(this.label_create);
            this.panel_CreateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_CreateLabel.Location = new System.Drawing.Point(0, -28);
            this.panel_CreateLabel.Name = "panel_CreateLabel";
            this.panel_CreateLabel.Size = new System.Drawing.Size(425, 28);
            this.panel_CreateLabel.TabIndex = 11;
            // 
            // label_create
            // 
            this.label_create.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_create.AutoSize = true;
            this.label_create.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_create.ForeColor = System.Drawing.Color.DarkGray;
            this.label_create.Location = new System.Drawing.Point(72, 7);
            this.label_create.Name = "label_create";
            this.label_create.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_create.Size = new System.Drawing.Size(280, 16);
            this.label_create.TabIndex = 0;
            this.label_create.Text = "اذ لا تملك حساب سابق قم بإنشاء حسابك الخاص";
            // 
            // panel_bottonCreate
            // 
            this.panel_bottonCreate.Controls.Add(this.btn_up);
            this.panel_bottonCreate.Controls.Add(this.btn_create);
            this.panel_bottonCreate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottonCreate.Location = new System.Drawing.Point(0, 0);
            this.panel_bottonCreate.Name = "panel_bottonCreate";
            this.panel_bottonCreate.Size = new System.Drawing.Size(425, 25);
            this.panel_bottonCreate.TabIndex = 10;
            // 
            // btn_up
            // 
            this.btn_up.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btn_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_up.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btn_up.FlatAppearance.BorderSize = 0;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.Location = new System.Drawing.Point(400, 0);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(25, 25);
            this.btn_up.TabIndex = 12;
            this.btn_up.Text = "^";
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Visible = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btn_create.FlatAppearance.BorderSize = 0;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(175, 0);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 25);
            this.btn_create.TabIndex = 9;
            this.btn_create.Text = "إنشاء حساب";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            this.btn_create.MouseHover += new System.EventHandler(this.btn_create_MouseHover);
            // 
            // btn_eye
            // 
            this.btn_eye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eye.BackgroundImage = global::LoginUI.Properties.Resources.mascara;
            this.btn_eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eye.FlatAppearance.BorderSize = 0;
            this.btn_eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eye.Location = new System.Drawing.Point(194, 296);
            this.btn_eye.Name = "btn_eye";
            this.btn_eye.Size = new System.Drawing.Size(37, 25);
            this.btn_eye.TabIndex = 11;
            this.btn_eye.UseVisualStyleBackColor = true;
            this.btn_eye.Click += new System.EventHandler(this.btn_eye_Click);
            // 
            // label_powred
            // 
            this.label_powred.AutoSize = true;
            this.label_powred.Font = new System.Drawing.Font("PT Bold Stars", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_powred.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_powred.Location = new System.Drawing.Point(3, 497);
            this.label_powred.Name = "label_powred";
            this.label_powred.Size = new System.Drawing.Size(88, 19);
            this.label_powred.TabIndex = 8;
            this.label_powred.Text = "Powered by: ";
            // 
            // label_aboutas
            // 
            this.label_aboutas.AutoSize = true;
            this.label_aboutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_aboutas.Location = new System.Drawing.Point(346, 461);
            this.label_aboutas.Name = "label_aboutas";
            this.label_aboutas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_aboutas.Size = new System.Drawing.Size(70, 13);
            this.label_aboutas.TabIndex = 7;
            this.label_aboutas.Text = "عن البرنامج : ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(239, 425);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(174, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "تذكر تسجيل الدخول لهذا الحساب";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_form
            // 
            this.label_form.AutoSize = true;
            this.label_form.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form.Location = new System.Drawing.Point(104, 85);
            this.label_form.Name = "label_form";
            this.label_form.Size = new System.Drawing.Size(216, 39);
            this.label_form.TabIndex = 5;
            this.label_form.Text = "تسجيل الدخول";
            // 
            // label_forget
            // 
            this.label_forget.AutoSize = true;
            this.label_forget.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.label_forget.Location = new System.Drawing.Point(167, 397);
            this.label_forget.Name = "label_forget";
            this.label_forget.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_forget.Size = new System.Drawing.Size(91, 13);
            this.label_forget.TabIndex = 3;
            this.label_forget.TabStop = true;
            this.label_forget.Text = "نسيت كلمة المرور";
            this.label_forget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_forget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_forget_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Silver;
            this.btn_login.Location = new System.Drawing.Point(116, 345);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(193, 39);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "تسجيل الدخول";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.Control;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Silver;
            this.txt_password.Location = new System.Drawing.Point(90, 261);
            this.txt_password.Name = "txt_password";
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.Size = new System.Drawing.Size(245, 26);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "كلمة المرور";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Control;
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Silver;
            this.txt_username.Location = new System.Drawing.Point(90, 179);
            this.txt_username.Name = "txt_username";
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_username.Size = new System.Drawing.Size(245, 26);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "اسم المستخدم";
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(425, 515);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 25;
            this.lineShape3.X2 = 400;
            this.lineShape3.Y1 = 450;
            this.lineShape3.Y2 = 450;
            // 
            // lineShape2
            // 
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 83;
            this.lineShape2.X2 = 341;
            this.lineShape2.Y1 = 294;
            this.lineShape2.Y2 = 294;
            // 
            // lineShape1
            // 
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 83;
            this.lineShape1.X2 = 341;
            this.lineShape1.Y1 = 212;
            this.lineShape1.Y2 = 212;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 540);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(425, 10);
            this.panel_bottom.TabIndex = 6;
            // 
            // panel_border
            // 
            this.panel_border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.panel_border.Controls.Add(this.btn_close);
            this.panel_border.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_border.Location = new System.Drawing.Point(0, 0);
            this.panel_border.Name = "panel_border";
            this.panel_border.Size = new System.Drawing.Size(425, 25);
            this.panel_border.TabIndex = 4;
            this.panel_border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_border_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(396, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "×";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // timer_manual
            // 
            this.timer_manual.Interval = 50;
            this.timer_manual.Tick += new System.EventHandler(this.timer_manual_Tick);
            // 
            // fm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 550);
            this.Controls.Add(this.panel_form);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fm_Login";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_form.ResumeLayout(false);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_manual.ResumeLayout(false);
            this.panel_CreateLabel.ResumeLayout(false);
            this.panel_CreateLabel.PerformLayout();
            this.panel_bottonCreate.ResumeLayout(false);
            this.panel_border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Panel panel_border;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label_form;
        private System.Windows.Forms.LinkLabel label_forget;
        private System.Windows.Forms.Button btn_login;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_powred;
        private System.Windows.Forms.Label label_aboutas;
        private System.Windows.Forms.Panel panel_manual;
        private System.Windows.Forms.Panel panel_CreateLabel;
        private System.Windows.Forms.Label label_create;
        private System.Windows.Forms.Panel panel_bottonCreate;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Timer timer_manual;
        private System.Windows.Forms.Button btn_eye;
        private System.Windows.Forms.Panel panel_create;
        private System.Windows.Forms.Button btn_up;
    }
}