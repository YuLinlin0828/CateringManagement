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
                MessageBox.Show("�û�������Ϊ��");
            }
            else if (txtuserpw.Text == "")
            {
                MessageBox.Show("���벻��Ϊ��");

            }
            else if (btnlogin.Text == "ע��")
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
                    MessageBox.Show("�û��Ѿ�����");                 
                }

                else 
                {
                    ur.name = txtusername.Text;
                    ur.pwd = txtuserpw.Text;
                    us.insert(ur);
                    MessageBox.Show("ע��ɹ�");
                }
            }
            if (btnlogin.Text == "�޸�")
            {
               

                    ur.name = txtusername.Text;
                    ur.pwd = txtuserpw.Text;
                    us.update(ur);
                    MessageBox.Show("�޸ĳɹ�");
                
                
            }
            if (btnlogin.Text == "ע��")
            {
                    ur.name = txtusername.Text;
                    ur.pwd = txtuserpw.Text;
                    us.delete(ur);
                    MessageBox.Show("ע���ɹ�");
                
            }
        }
       
        
    }
}

       