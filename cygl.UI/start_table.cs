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
    public partial class start_table : Form
    {
        public start_table()
        {
            InitializeComponent();
        }
        public string name;
        public SqlConnection conn;

        private void start_table_Load(object sender, EventArgs e)
        {
            conn = cygl.Helper.DBHelper.getconn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from room", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                tableno.Items.Add(sdr["roomname"].ToString().Trim());
            }
            tableno.SelectedItem = name.Trim();
            sdr.Close();
            cmd = new SqlCommand("select * from waiter", conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                theWaiter.Items.Add(sdr["waitername"].ToString().Trim());
            }
            theWaiter.SelectedIndex = 0;
            sdr.Close();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "" || Convert.ToInt32(txtNum.Text) <= 0)
            {
                MessageBox.Show("请输入用餐人数");
            }
            else
            {
                string roomname = tableno.SelectedItem.ToString();
                SqlCommand cmd1 = new SqlCommand("update room set roomstate='使用' where roomname='" + name + "'", conn);
                cmd1.ExecuteNonQuery();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}