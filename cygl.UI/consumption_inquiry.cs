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
    public partial class consumption_inquiry : Form
    {
        public consumption_inquiry()
        {
            InitializeComponent();
        }
        public string RName;

        private void xfcx_Load(object sender, EventArgs e)
        {
            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            SqlDataAdapter sda = new SqlDataAdapter("select foodname,foodsum,foodallprice,waitername,beizhu,roomname,datatime from guestfood where roomname='" + RName + "'order by id desc", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}