namespace LoginUI
{
    partial class fm_ForgetTwo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any 
        /// being used.
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
            this.label_check = new System.Windows.Forms.Label();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.label_answer = new System.Windows.Forms.Label();
            this.label_question = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.panel_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_form
            // 
            this.panel_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.panel_form.Controls.Add(this.label_check);
            this.panel_form.Controls.Add(this.txt_answer);
            this.panel_form.Controls.Add(this.label_answer);
            this.panel_form.Controls.Add(this.label_question);
            this.panel_form.Controls.Add(this.label_username);
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Location = new System.Drawing.Point(0, 0);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(400, 130);
            this.panel_form.TabIndex = 0;
            // 
            // label_check
            // 
            this.label_check.AutoSize = true;
            this.label_check.ForeColor = System.Drawing.Color.Red;
            this.label_check.Location = new System.Drawing.Point(184, 71);
            this.label_check.Name = "label_check";
            this.label_check.Size = new System.Drawing.Size(34, 13);
            this.label_check.TabIndex = 8;
            this.label_check.Text = "check";
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(110, 93);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(196, 20);
            this.txt_answer.TabIndex = 4;
            this.txt_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.ForeColor = System.Drawing.Color.DarkGray;
            this.label_answer.Location = new System.Drawing.Point(312, 100);
            this.label_answer.Name = "label_answer";
            this.label_answer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_answer.Size = new System.Drawing.Size(64, 13);
            this.label_answer.TabIndex = 2;
            this.label_answer.Text = "جواب الامان:";
            this.label_answer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.ForeColor = System.Drawing.Color.DarkGray;
            this.label_question.Location = new System.Drawing.Point(239, 43);
            this.label_question.Name = "label_question";
            this.label_question.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_question.Size = new System.Drawing.Size(137, 13);
            this.label_question.TabIndex = 1;
            this.label_question.Text = "سؤال الأمان: ماذا يعني قوقة";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // fm_ForgetTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 130);
            this.Controls.Add(this.panel_form);
            this.Name = "fm_ForgetTwo";
            this.Text = "ForgetTwo";
            this.Load += new System.EventHandler(this.fm_ForgetTwo_Load);
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_check;
    }
}