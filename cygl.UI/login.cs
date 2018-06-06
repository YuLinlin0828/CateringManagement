using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cygl.Model;
using cygl.BLL;

namespace cygl.UI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public string Names;
        public bool IfInput(string name, string pwd)
        {
            if (name == "")
            {
                MessageBox.Show("请输入用户名");
                txtname.Focus();
            }
            else if (pwd == "")
            {
                Names = txtname.Text;
                MessageBox.Show("请输入密码:");
                txtpwd.Focus();
            }
            else
                return true;
            return false;
        }
        cygl.BLL.user um = new cygl.BLL.user();

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                Model.user u = new Model.user();
                u.Name = this.txtname.Text.Trim();
                u.Pwd = this.txtpwd.Text.Trim();
                if (IfInput(u.Name, u.Pwd))
                {
                    bool b = um.ExistsUsers(u);
                    if (b)
                    {
                        main_interface admin = new main_interface();
                        admin.Show();
                        this.Visible = false;
                    }
                    else
                        MessageBox.Show("登陆失败");
                }
            }
            catch
            {

            }
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}