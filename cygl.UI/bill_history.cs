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

        private void billhistory_Load(object sender, EventArgs e)
        {

            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select roomname,datatime,price,waitername from bill  ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();

        }
        //ÍË³ö°´Å¥
        private void Btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}