using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cygl.UI
{
    public partial class system_maintenance : Form
    {
        public system_maintenance()
        {
            InitializeComponent();
        }
        BLL.user us = new cygl.BLL.user();
        Model.user ur = new cygl.Model.user();
        public string bt;
        public string la;
        public string sUser;
        private void sysmaintenance_Load(object sender, EventArgs e)
        {
            btnlogin.Text = bt;
            labeltitle.Text = la;
                     
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("用户名不能为空");
            }
            else if (txtuserpw.Text == "")
            {
                MessageBox.Show("密码不能为空");

            }
            else if (btnlogin.Text == "注册")
            {
                SqlConnection conn = cygl.Helper.DBHelper.getconn();
                conn.Open();
                sUser = txtusername.Text.Trim();
                string sPwd = txtuserpw.Text.Trim();
                string str = "select name from users where name='" + sUser + "'";
                SqlCommand comm = new SqlCommand(str, conn);
                int i = Convert.ToInt32(comm.ExecuteScalar());
                if (i > 0)
                {
                    MessageBox.Show("用户已经存在");                 
                }

                else 
                {
                    ur.name = txtusername.Text;
                    ur.pwd = txtuserpw.Text;
                    us.insert(ur);
                    MessageBox.Show("注册成功");
                }
            }
            if (btnlogin.Text == "修改")
            {
               

                    ur.name = txtusername.Text;
                    ur.pwd = txtuserpw.Text;
                    us.update(ur);
                    MessageBox.Show("修改成功");
                
                
            }
            if (btnlogin.Text == "注销")
            {
                    ur.name = txtusername.Text;
                    ur.pwd = txtuserpw.Text;
                    us.delete(ur);
                    MessageBox.Show("注销成功");
                
            }
        }
       
        
    }
}

       