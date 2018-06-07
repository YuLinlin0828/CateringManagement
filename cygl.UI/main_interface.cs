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
        private void Table_infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table_info fm = new table_info();
            fm.Show();
        }
        //ְԱ��Ϣ
        private void Staff_infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff_info fm = new staff_info();
            fm.Show();
        }
        //��Ʒ��Ϣ
        private void Food_infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            food_info fm = new food_info();
            fm.Show();
        }
        //ע�����Ա
        private void Admin_register_Click(object sender, EventArgs e)
        {
            system_maintenance fm = new system_maintenance();
            fm.bt = "ע��";
            fm.la = "ע��";
            fm.Show();
        }
        //�޸Ĺ���Ա
        private void Admin_change_Click(object sender, EventArgs e)
        {
            system_maintenance fm = new system_maintenance();
            fm.bt = "�޸�";
            fm.la = "�޸�";
            fm.Show();
        }
        //ע������Ա
        private void Admin_cancel_Click(object sender, EventArgs e)
        {
            system_maintenance fm = new system_maintenance();
            fm.bt = "ע��";
            fm.la = "ע��";
            fm.Show();
        }
        //�˳�ϵͳ
        private void Exit_tool_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("ȷ���˳���ϵͳ��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //�����Ŀ
        private void AddItems(string rstatus)
        {
            if (rstatus == "ʹ��")
            {
                lvDesk.Items.Add(sdr["roomname"].ToString(), 1);
            }
            else
            {
                lvDesk.Items.Add(sdr["roomName"].ToString(), 0);
            }
        }
        //������
        private void Mainscreen_Activated(object sender, EventArgs e)
        {
            lvDesk.Items.Clear();
            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from room", conn);
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                string status = sdr["roomstate"].ToString().Trim();
                AddItems(status);
            }
            conn.Close();
        }
        //����̨
        private void Open_table_Click(object sender, EventArgs e)
        {
            if (lvDesk.SelectedItems.Count != 0)
            {

                string names = lvDesk.SelectedItems[0].SubItems[0].Text;
                start_table openroom = new start_table();
                openroom.name = names;
                openroom.ShowDialog();
            }
            else
            {
                MessageBox.Show("��ѡ����̨");
            }
        }
        //ȡ����̨
        private void Cancel_table_Click(object sender, EventArgs e)
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
                    Mainscreen_Activated(sender, e);
                }
            }
            else
            {
                MessageBox.Show("��ѡ����̨");

            }
        }
        //��/�Ӳ�
        private void Add_food_Click(object sender, EventArgs e)
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

        private void LvDesk_Click(object sender, EventArgs e)
        {
            string names = lvDesk.SelectedItems[0].SubItems[0].Text;
            SqlConnection conn = cygl.Helper.DBHelper.getconn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from room where roomname='" + names + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            string status = sdr["roomstate"].ToString().Trim();
            sdr.Close();
            if (status == "ʹ��")
            {
                this.rightclick_menu.Items[0].Enabled = false;
                this.rightclick_menu.Items[1].Enabled = true;
                this.rightclick_menu.Items[3].Enabled = true;
                this.rightclick_menu.Items[5].Enabled = true;
                this.rightclick_menu.Items[6].Enabled = true;
            }
            if (status == "����")
            {
                this.rightclick_menu.Items[0].Enabled = true;
                this.rightclick_menu.Items[1].Enabled = false;
                this.rightclick_menu.Items[3].Enabled = false;
                this.rightclick_menu.Items[5].Enabled = false;
                this.rightclick_menu.Items[6].Enabled = false;
            }
            conn.Close();
        }

        private void Pay_bill_Click(object sender, EventArgs e)
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

        private void Check_bill_Click(object sender, EventArgs e)
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

        private void Bill_record_Click(object sender, EventArgs e)
        {
            bill_history fm = new bill_history();
            fm.Show();
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void Open_tool_Click(object sender, EventArgs e)
        {
            this.Show();

        }

        private void Exit_tool1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainscreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Mainscreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void About_info_Click(object sender, EventArgs e)
        {
            designer_info fm = new designer_info();
            fm.Show();
        }

        private void Calendar_tool_Click(object sender, EventArgs e)
        {
            calender fm = new calender();
            fm.Show();
        }

        private void Calculator_tool_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void Notepad_tool_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void Mainscreen_Load(object sender, EventArgs e)
        {

        }

        private void Main_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void LvDesk_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}