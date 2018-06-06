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
    public partial class bill_history : Form
    {
        public bill_history()
        {
            InitializeComponent();
        }

        private void lszd_Load(object sender, EventArgs e)
        {

            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select roomname,datatime,price,waitername from bill  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}