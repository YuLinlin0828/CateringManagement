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
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = br.getlist("");
        }
        // 下载于www.mycodes.net
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedCells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                MessageBox.Show("请输入菜品ID！");
            }
            else
            {
                mr.id = txtid.Text;
                mr.foodname = textBox4.Text;
                mr.foodtype = comboBox1.Text;
                mr.foodnum = textBox2.Text;
                mr.foodprice = textBox3.Text;
                br.insert(mr);
                MessageBox.Show("添加成功！");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请选择菜品！");
            }
            else
            {
                mr.id = txtid.Text;
                mr.foodname = textBox4.Text;
                mr.foodtype = comboBox1.Text;
                mr.foodnum = textBox2.Text;
                mr.foodprice = textBox3.Text;
                br.update(mr);
                MessageBox.Show("修改成功！");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请选择菜品！");
            }
            else
            {
                br.delete(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}