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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        public string Rname;
        public string price;
        public string bjf;

        private void jz_Load(object sender, EventArgs e)
        {
            this.Text = Rname + "结账";
            groupBox1.Text = "当前桌台-" + Rname;
            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            SqlDataAdapter sda = new SqlDataAdapter("select foodname,foodsum,foodallprice,waitername,beizhu,roomname,datatime from guestfood where roomname='" + Rname + "'order by id desc", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvRecord.DataSource = ds.Tables[0];
            conn.Open();
            SqlCommand cmd = new SqlCommand("select sum(foodallprice) from guestfood where roomname='" + Rname + "'", conn);
            price = Convert.ToString(cmd.ExecuteScalar());
            if (price == "")
            {
                tprice.Text = "0";
                btnpay.Enabled = false;
            }
            else
            {
                cmd = new SqlCommand("select roomfee from room where roomname='" + Rname + "'", conn);
                bjf = cmd.ExecuteScalar().ToString();
                if (bjf == "0")
                {
                    btnpay.Enabled = true;
                    tprice.Text = (Convert.ToDecimal(Convert.ToDouble(price))).ToString("C");
                }
                else
                {
                    btnpay.Enabled = true;
                    tprice.Text = (Convert.ToDecimal(Convert.ToDouble(price))).ToString("C");
                }
                conn.Close();
            }
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }

        }

        private void txtmoney_TextChanged(object sender, EventArgs e)
        {
            if (price == "")
            {
                rest0.Text = "0";
            }
            else
            {
                if (txtmoney.Text == "")
                {
                    txtmoney.Text = "0";
                    rest0.Text = "0";
                }
                else
                {
                    rest0.Text = Convert.ToDecimal(Convert.ToDouble(txtmoney.Text.Trim()) - Convert.ToDouble(price)).ToString("C");
                }
            }
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if (txtmoney.Text == "" || rest0.Text == "0")
            {
                MessageBox.Show("请先结账");
                return;
            }
            else
            {
                if (rest0.Text.Substring(1, 1) == "-")
                {
                    MessageBox.Show("金额不足");
                    return;
                }
                else
                {
                    SqlConnection conn = cygl.Helper.DBHelper.getconn();
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(" insert bill select guestfood.id,guestfood.roomname,foodname, foodnum,foodallprice,room.id , guestfood.waitername from room ,guestfood where room.roomname=guestfood.roomname", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from guestfood where roomname='" + Rname + "'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update room set roomstate='待用' where roomname='" + Rname + "'", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    this.Close();

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}