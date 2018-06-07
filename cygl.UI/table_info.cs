using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cygl.UI
{
    public partial class table_info : Form
    {
        public table_info()
        {
            InitializeComponent();
        }
        BLL.room br = new cygl.BLL.room();
        Model.room mr = new cygl.Model.room();

        private void btnquery_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = br.getlist("");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请输入桌台ID！");
            }
            else
            {
                mr.id = txtid.Text;
                mr.roomname = txtname.Text;
                mr.roomabb = txtabb.Text;
                mr.roomfee = txtfee.Text;
                mr.roomlocation = txtlocation.Text;
                br.insert(mr);
                MessageBox.Show("添加成功！");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtname.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtabb.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtfee.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtlocation.Text = dataGridView1.SelectedCells[4].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请选择桌台！");
            }
            else
            {
                br.delete(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("请选择桌台！");
            }
            else
            {
                mr.id = txtid.Text;
                mr.roomname = txtname.Text;
                mr.roomabb = txtabb.Text;
                mr.roomfee = txtfee.Text;
                mr.roomlocation = txtlocation.Text;
                br.update(mr);             
                MessageBox.Show("修改成功！");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void table_inform_Load(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtabb.Text = "";
            txtfee.Text = "";
            txtlocation.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}