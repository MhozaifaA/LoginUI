using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI
{
    public partial class fm_ForgetOne : Form
    {
        fm_Login fm_login = new fm_Login();
        public fm_ForgetOne()
        {
            InitializeComponent();
        }
        public fm_ForgetOne(fm_Login value)
        {
            InitializeComponent();
            fm_login = value;

        }

        private void fm_ForgotPassword_Load(object sender, EventArgs e)
        {       
            fm_login.Enabled = false;
        }
        public void MasterContainer(Object Oform)
        {
            if (panel_forget.Controls.Count > 0)
            {
                panel_forget.Controls.RemoveAt(0);
            }

            Form fm = new Form();
            fm = Oform as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.FormBorderStyle = FormBorderStyle.None;
            panel_forget.Controls.Add(fm);
            panel_forget.Tag = fm;
            fm.Show();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            panel_forget.Controls.Clear();
            fm_login.Enabled = true;
            fm_login.Opacity = 0.85D;
            this.Close();
        }

        int checkforget = 0;
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (checkforget == 0)
            {
                panel_forget.Controls.Clear();
                fm_ForgetTwo fm_forgettwo = new fm_ForgetTwo();
                MasterContainer(fm_forgettwo);
                checkforget = 1;
            }else if(checkforget==1)
            {
                fm_ForgetThree fm_forgetthree = new fm_ForgetThree();
                MasterContainer(fm_forgetthree);
                btn_next.Text = "إنهاء";
                checkforget = 2;
            }else if(checkforget==2)
            {
                panel_forget.Controls.Clear();
                fm_login.Enabled = true;
                fm_login.Opacity = 0.85D;

                this.Dispose();
            }

        }


    }
}
