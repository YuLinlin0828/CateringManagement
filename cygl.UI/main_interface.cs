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
    public partial class main_interface : Form
    {
        public main_interface()
        {
            InitializeComponent();
        }
        public SqlDataReader sdr;
        public string Times;
        public string Names;
        Model.user us = new cygl.Model.user();
        //��̨��Ϣ
        private void table_infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table_info fm = new table_info();
            fm.Show();
        }
        //ְԱ��Ϣ
        private void staff_infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_info fm = new staff_info();
            fm.Show();
        }
        //��Ʒ��Ϣ
        private void food_infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            food_info fm = new food_info();
            fm.Show();
        }
        //ע�����Ա
        private void admin_register_Click(object sender, EventArgs e)
        {
            system_maintenance fm = new system_maintenance();
            fm.bt = "ע��";
            fm.la = "ע��";
            fm.Show();
        }
        //�޸Ĺ���Ա
        private void admin_change_Click(object sender, EventArgs e)
        {
            system_maintenance fm = new system_maintenance();
            fm.bt = "�޸�";
            fm.la = "�޸�";
            fm.Show();
        }
        //ע������Ա
        private void admin_cancel_Click(object sender, EventArgs e)
        {
            system_maintenance fm = new system_maintenance();
            fm.bt = "ע��";
            fm.la = "ע��";
            fm.Show();
        }

        private void exit_tool_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("ȷ���˳���ϵͳ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void AddItems(string rzt)
        {
            if (rzt == "ʹ��")
            {
                lvDesk.Items.Add(sdr["roomname"].ToString(), 1);
            }
            else
            {
                lvDesk.Items.Add(sdr["roomName"].ToString(), 0);
            }
        }

        private void zjm_Activated(object sender, EventArgs e)
        {
            lvDesk.Items.Clear();
            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from room", conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string zt = sdr["roomstate"].ToString().Trim();
                AddItems(zt);
            }
            conn.Close();
        }

        private void open_table_Click(object sender, EventArgs e)
        {
            if (lvDesk.SelectedItems.Count != 0)
            {

                string names = lvDesk.SelectedItems[0].SubItems[0].Text;
                kt openroom = new kt();
                openroom.name = names;
                openroom.ShowDialog();
            }
            else
            {
                MessageBox.Show("��ѡ����̨");
            }
        }

        private void cancel_table_Click(object sender, EventArgs e)
        {
            if (lvDesk.SelectedItems.Count != 0)
            {
                SqlConnection conn = cygl.Helper.DBHelper.getconn();
                conn.Open();
                string names = lvDesk.SelectedItems[0].SubItems[0].Text;
                SqlCommand cmd = new SqlCommand("Select * from guestfood where roomname='" + names + "'", conn);
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                if (i > 0)
                {
                    MessageBox.Show("���Ƚ���!!");

                }
                else
                {
                    cmd = new SqlCommand("update room set roomstate='����' where roomname='" + names + "'", conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from guestfood where roomname='" + names + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    zjm_Activated(sender, e);
                }
            }
            else
            {
                MessageBox.Show("��ѡ����̨");

            }
        }

        private void add_food_Click(object sender, EventArgs e)
        {
            if (lvDesk.SelectedItems.Count != 0)
            {
                string names = lvDesk.SelectedItems[0].SubItems[0].Text;
                order_add_food dc = new order_add_food();
                dc.RName = names;
                dc.ShowDialog();
            }
            else
            {
                MessageBox.Show("��ѡ����̨");
            }
        }

        private void lvDesk_Click(object sender, EventArgs e)
        {
            string names = lvDesk.SelectedItems[0].SubItems[0].Text;
            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from room where roomname='" + names + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string zt = sdr["roomstate"].ToString().Trim();
            sdr.Close();
            if (zt == "ʹ��")
            {
                this.rightclick_menu.Items[0].Enabled = false;
                this.rightclick_menu.Items[1].Enabled = true;
                this.rightclick_menu.Items[3].Enabled = true;
                this.rightclick_menu.Items[5].Enabled = true;
                this.rightclick_menu.Items[6].Enabled = true;
            }
            if (zt == "����")
            {
                this.rightclick_menu.Items[0].Enabled = true;
                this.rightclick_menu.Items[1].Enabled = false;
                this.rightclick_menu.Items[3].Enabled = false;
                this.rightclick_menu.Items[5].Enabled = false;
                this.rightclick_menu.Items[6].Enabled = false;
            }
            conn.Close();
        }

        private void pay_bill_Click(object sender, EventArgs e)
        {
            if (lvDesk.SelectedItems.Count != 0)
            {
                string names = lvDesk.SelectedItems[0].SubItems[0].Text;
                Payment jza = new Payment();
                jza.Rname = names;
                jza.ShowDialog();
            }
            else
            {
                MessageBox.Show("��ѡ����̨");
            }
        }

        private void check_bill_Click(object sender, EventArgs e)
        {
            if (lvDesk.SelectedItems.Count != 0)
            {
                string names = lvDesk.SelectedItems[0].SubItems[0].Text;
                consumption_inquiry serch = new consumption_inquiry();
                serch.RName = names;
                serch.ShowDialog();
            }
            else
            {
                MessageBox.Show("��ѡ����̨");
            }
        }

        private void bill_record_Click(object sender, EventArgs e)
        {
            bill_history fm = new bill_history();
            fm.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void open_tool_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void exit_tool1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zjm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void zjm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void about_info_Click(object sender, EventArgs e)
        {
            designer_info fm = new designer_info();
            fm.Show();
        }

        private void calendar_tool_Click(object sender, EventArgs e)
        {
            calender fm = new calender();
            fm.Show();
        }

        private void calculator_tool_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void notepad_tool_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void zjm_Load(object sender, EventArgs e)
        {

        }

        private void main_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lvDesk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}