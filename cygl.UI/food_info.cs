using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cygl.UI
{
    public partial class food_info : Form
    {
        public food_info()
        {
            InitializeComponent();
        }
        BLL.food br = new cygl.BLL.food();
        Model.food mr = new cygl.Model.food();
        private void btnquery_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = br.getlist("");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedCells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("�������ƷID��");
            }
            else
            {
                mr.id = txtid.Text;
                mr.foodname = textBox4.Text;
                mr.foodtype = comboBox1.Text;
                mr.foodnum = textBox2.Text;
                mr.foodprice = textBox3.Text;
                br.insert(mr);
                MessageBox.Show("��ӳɹ���");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("��ѡ���Ʒ��");
            }
            else
            {
                mr.id = txtid.Text;
                mr.foodname = textBox4.Text;
                mr.foodtype = comboBox1.Text;
                mr.foodnum = textBox2.Text;
                mr.foodprice = textBox3.Text;
                br.update(mr);
                MessageBox.Show("�޸ĳɹ���");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("��ѡ���Ʒ��");
            }
            else
            {
                br.delete(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";

        }

        private void labelt_Click(object sender, EventArgs e)
        {

        }

        private void food_info_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}