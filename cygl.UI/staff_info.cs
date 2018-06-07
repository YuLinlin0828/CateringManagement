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

        private void btnquery_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = br.getlist("");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("������ְԱID��");
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
                MessageBox.Show("��ӳɹ���");
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("��ѡ��ְԱ��");
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
                MessageBox.Show("�޸ĳɹ���");
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("��ѡ��ְԱ��");
            }
            else
            {
                br.delete(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                dataGridView1.DataSource = br.getlist("");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            comsex.Text = "";
            txtage.Text = "";
            txtidcard.Text = "";
            txttel.Text = "";
        }

        private void staff_info_Load(object sender, EventArgs e)
        {

        }

        private void lgender_Click(object sender, EventArgs e)
        {

        }
    }
}