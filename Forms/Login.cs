using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI
{
    public partial class fm_Login : Form
    {
        public fm_Login()
        {
            InitializeComponent();
           
        }

        int x = 0;
        int y = 0;
        private void Login_Load(object sender, EventArgs e)
        {
            x = Location.X;
            y = Location.Y;
        }
        public void MasterContainer(Object Oform)
        {
            if (panel_create.Controls.Count > 0)
            {
                panel_create.Controls.RemoveAt(0);
            }

            Form fm = new Form();
            fm = Oform as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            fm.FormBorderStyle = FormBorderStyle.None;
            panel_create.Controls.Add(fm);
            panel_create.Tag = fm;
            fm.Show();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // تمكين تحريك الواجها
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void panel_login_MouseDown(object sender, MouseEventArgs e)
        {            
                this.Opacity = 1D;
            //ReleaseCapture();
            //    SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                panel_login.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
            if (!iscreate)
                this.Opacity = 0.85D;

        }
    
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "اسم المستخدم")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
            if (panel_manual.Height == 50)
            {
                this.timer_manual.Enabled = true;
                isopen = true;

            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "اسم المستخدم";
                txt_username.ForeColor = Color.Silver;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "كلمة المرور")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.UseSystemPasswordChar = true;
            }
            if (panel_manual.Height == 50)
            {
                this.timer_manual.Enabled = true;
                isopen = true;

            }

        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "كلمة المرور";
                txt_password.ForeColor = Color.Silver;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            Form fm = new Form();
            fm.StartPosition = FormStartPosition.CenterScreen;
            fm.FormClosed += (s,ev) => {
                btn_close_Click(s,ev);
            };
            fm.Controls.Add(new Label() {Text="Wellcome"});
            fm.Show();
            this.Hide();
        }
        bool isopen = true;
        private void btn_create_MouseHover(object sender, EventArgs e)
        {

            if (panel_manual.Height == 50)
            {
                this.timer_manual.Enabled = true;
                isopen = true;

            }
            else if (panel_manual.Height == 25)
            {
                this.timer_manual.Enabled = true;
                isopen = false;
            }
        }

        private void timer_manual_Tick(object sender, EventArgs e)
        {
            if (isclick)
            {
                if (!isOpenCreate)
                {
                    if (panel_manual.Height >= 25)
                        panel_manual.Height = panel_manual.Height + 25;

                    if (panel_manual.Height == 450)
                    {
                        this.timer_manual.Enabled = false;
                        isclick = false;
                        btn_up.Visible = true;
                    }

                }
                else
                {
                    if (panel_manual.Height <= 450)
                        panel_manual.Height = panel_manual.Height - 50;

                    if (panel_manual.Height == 50)
                    {
                        this.timer_manual.Enabled = false;
                        panel_manual.Height = 25;
                        isclick = false;
                        this.Opacity = 0.85D;
                    }
                }

            }
            else if (isopen)
            {

                if (panel_manual.Height <= 50)
                    panel_manual.Height = panel_manual.Height - 5;

                if (panel_manual.Height == 25)
                    this.timer_manual.Enabled = false;
            }
            else
            {

                if (panel_manual.Height >= 25)
                    panel_manual.Height = panel_manual.Height + 5;

                if (panel_manual.Height == 50)
                    this.timer_manual.Enabled = false;
            }

        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar == true)
            {
                
                txt_password.UseSystemPasswordChar = false;
                this.btn_eye.BackgroundImage = global::LoginUI.Properties.Resources.eye;
            }
            else if (txt_password.ForeColor != Color.Silver)
            {
                txt_password.UseSystemPasswordChar = true;
                this.btn_eye.BackgroundImage = global::LoginUI.Properties.Resources.mascara;
            }
        }

        bool isclick = false;
        bool isOpenCreate = true;
        private void btn_create_Click(object sender, EventArgs e)
        {

            isclick = true;
            if (panel_manual.Height <= 50 && panel_manual.Height >= 25)
            {
                fm_CreateAccount fm = new fm_CreateAccount();
                MasterContainer(fm);
                iscreate = true;

                panel_manual.Height = 50;
                this.timer_manual.Enabled = true;
                isOpenCreate = false;
                this.Opacity = 1D;
                label_create.Text = "\"لتأكيد الحساب اضفط على \"إنشاء حساب";

            }
            else if (panel_manual.Height == 450)
            {
                this.timer_manual.Enabled = true;
                isOpenCreate = true;

                panel_create.Controls.RemoveAt(0);
                iscreate = false;
                btn_up.Visible = false;
                label_create.Text = "اذ لا تملك حساب سابق قم بإنشاء حسابك الخاص";
                //this.Opacity = 0.85D;
            }
        }

        // تمكين تحريك الواجها                  
        bool iscreate = false;
        
        private void panel_border_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (iscreate)
            {
                //ReleaseCapture();
                //SendMessage(this.Handle, 0x112, 0xf012, 0);
                if (e.Button == MouseButtons.Left)
                {
                    // Release the mouse capture started by the mouse down.
                    panel_border.Capture = false;

                    // Create and send a WM_NCLBUTTONDOWN message.
                    const int WM_NCLBUTTONDOWN = 0x00A1;
                    const int HTCAPTION = 2;
                    Message msg =
                        Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                            new IntPtr(HTCAPTION), IntPtr.Zero);
                    this.DefWndProc(ref msg);
                }
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            isclick = true;
            if (panel_manual.Height == 450)
            {
                this.timer_manual.Enabled = true;
                isOpenCreate = true;

                panel_create.Controls.RemoveAt(0);
                iscreate = false;
                btn_up.Visible = false;
                label_create.Text = "اذ لا تملك حساب سابق قم بإنشاء حسابك الخاص";
            }
        }
        private void label_forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity = 0.4D;
            this.Location = new Point(x, y);
            fm_ForgetOne fm = new fm_ForgetOne(this);
            fm.ShowDialog();
        }

    }
}
