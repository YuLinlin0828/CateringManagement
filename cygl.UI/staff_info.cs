using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cygl.UI
{
    public partial class staff_info : Form
    {
        public staff_info()
        {
            InitializeComponent();
        }
        BLL.waiter br = new cygl.BLL.waiter();
        Model.waiter mr = new cygl.Model.waiter();
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = br.getlist("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请输入职员ID！");
            }
            else
            {
                mr.id = txtid.Text;
                mr.waitername = txtname.Text;
                mr.sex = comsex.Text;
                mr.age= txtage.Text;
                mr.idcard = txtidcard.Text;
                mr.tel = txttel.Text;
                br.insert(mr);
                MessageBox.Show("添加成功！");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请选择职员！");
            }
            else
            {
                mr.id = txtid.Text;
                mr.waitername = txtname.Text;
                mr.sex = comsex.Text;
                mr.age = txtage.Text;
                mr.idcard = txtidcard.Text;
                mr.tel = txttel.Text;
                br.update(mr);
                MessageBox.Show("修改成功！");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtid.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedCells[1].Value.ToString();
            comsex.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtage.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtidcard.Text = dataGridView1.SelectedCells[4].Value.ToString();
            txttel.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请选择职员！");
            }
            else
            {
                br.delete(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            comsex.Text = "";
            txtage.Text = "";
            txtidcard.Text = "";
            txttel.Text = "";
        }
    }
}