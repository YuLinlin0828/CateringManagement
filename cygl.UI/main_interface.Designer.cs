namespace cygl.UI
{
    partial class main_interface
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>calendar_tool
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_interface));
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.table_infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staff_infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.food_infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.calendar_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.calculator_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.notepad_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.totalsystem_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_register = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_change = new System.Windows.Forms.ToolStripMenuItem();
            this.admin_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.bill_record = new System.Windows.Forms.ToolStripMenuItem();
            this.about_info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.rightclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_table = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel_table = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.add_food = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.check_bill = new System.Windows.Forms.ToolStripMenuItem();
            this.pay_bill = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDesk = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_tool1 = new System.Windows.Forms.ToolStripMenuItem();
            this.main_menu.SuspendLayout();
            this.rightclick_menu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.Linen;
            this.main_menu.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.table_infoToolStripMenuItem,
            this.staff_infoToolStripMenuItem,
            this.food_infoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.totalsystem_tool,
            this.bill_record,
            this.about_info,
            this.toolStripMenuItem1,
            this.exit_tool});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(886, 27);
            this.main_menu.TabIndex = 0;
            this.main_menu.Text = "menuStrip1";
            this.main_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Main_menu_ItemClicked);
            // 
            // table_infoToolStripMenuItem
            // 
            this.table_infoToolStripMenuItem.Name = "table_infoToolStripMenuItem";
            this.table_infoToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.table_infoToolStripMenuItem.Text = "桌台信息";
            this.table_infoToolStripMenuItem.Click += new System.EventHandler(this.Table_infoToolStripMenuItem_Click);
            // 
            // staff_infoToolStripMenuItem
            // 
            this.staff_infoToolStripMenuItem.Name = "staff_infoToolStripMenuItem";
            this.staff_infoToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.staff_infoToolStripMenuItem.Text = "职员信息";
            this.staff_infoToolStripMenuItem.Click += new System.EventHandler(this.Staff_infoToolStripMenuItem_Click);
            // 
            // food_infoToolStripMenuItem
            // 
            this.food_infoToolStripMenuItem.Name = "food_infoToolStripMenuItem";
            this.food_infoToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.food_infoToolStripMenuItem.Text = "菜品信息";
            this.food_infoToolStripMenuItem.Click += new System.EventHandler(this.Food_infoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calendar_tool,
            this.calculator_tool,
            this.notepad_tool});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(105, 23);
            this.toolStripMenuItem2.Text = "辅助工具";
            // 
            // calendar_tool
            // 
            this.calendar_tool.Name = "calendar_tool";
            this.calendar_tool.Size = new System.Drawing.Size(141, 24);
            this.calendar_tool.Text = "日历";
            this.calendar_tool.Click += new System.EventHandler(this.Calendar_tool_Click);
            // 
            // calculator_tool
            // 
            this.calculator_tool.Name = "calculator_tool";
            this.calculator_tool.Size = new System.Drawing.Size(141, 24);
            this.calculator_tool.Text = "计算器";
            this.calculator_tool.Click += new System.EventHandler(this.Calculator_tool_Click);
            // 
            // notepad_tool
            // 
            this.notepad_tool.Name = "notepad_tool";
            this.notepad_tool.Size = new System.Drawing.Size(141, 24);
            this.notepad_tool.Text = "记事本";
            this.notepad_tool.Click += new System.EventHandler(this.Notepad_tool_Click);
            // 
            // totalsystem_tool
            // 
            this.totalsystem_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admin_register,
            this.admin_change,
            this.admin_cancel});
            this.totalsystem_tool.Name = "totalsystem_tool";
            this.totalsystem_tool.Size = new System.Drawing.Size(105, 23);
            this.totalsystem_tool.Text = "系统维护";
            // 
            // admin_register
            // 
            this.admin_register.Name = "admin_register";
            this.admin_register.Size = new System.Drawing.Size(183, 24);
            this.admin_register.Text = "注册管理员";
            this.admin_register.Click += new System.EventHandler(this.Admin_register_Click);
            // 
            // admin_change
            // 
            this.admin_change.Name = "admin_change";
            this.admin_change.Size = new System.Drawing.Size(183, 24);
            this.admin_change.Text = "修改管理员";
            this.admin_change.Click += new System.EventHandler(this.Admin_change_Click);
            // 
            // admin_cancel
            // 
            this.admin_cancel.Name = "admin_cancel";
            this.admin_cancel.Size = new System.Drawing.Size(183, 24);
            this.admin_cancel.Text = "注销管理员";
            this.admin_cancel.Click += new System.EventHandler(this.Admin_cancel_Click);
            // 
            // bill_record
            // 
            this.bill_record.Name = "bill_record";
            this.bill_record.Size = new System.Drawing.Size(105, 23);
            this.bill_record.Text = "历史账单";
            this.bill_record.Click += new System.EventHandler(this.Bill_record_Click);
            // 
            // about_info
            // 
            this.about_info.Name = "about_info";
            this.about_info.Size = new System.Drawing.Size(63, 23);
            this.about_info.Text = "关于";
            this.about_info.Click += new System.EventHandler(this.About_info_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 23);
            this.toolStripMenuItem1.Text = "最小化";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // exit_tool
            // 
            this.exit_tool.Name = "exit_tool";
            this.exit_tool.Size = new System.Drawing.Size(63, 23);
            this.exit_tool.Text = "退出";
            this.exit_tool.Click += new System.EventHandler(this.Exit_tool_Click);
            // 
            // rightclick_menu
            // 
            this.rightclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_table,
            this.cancel_table,
            this.toolStripSeparator3,
            this.add_food,
            this.toolStripSeparator1,
            this.check_bill,
            this.pay_bill});
            this.rightclick_menu.Name = "rightclick_menu";
            this.rightclick_menu.Size = new System.Drawing.Size(125, 126);
            // 
            // open_table
            // 
            this.open_table.Name = "open_table";
            this.open_table.Size = new System.Drawing.Size(124, 22);
            this.open_table.Text = "开台";
            this.open_table.Click += new System.EventHandler(this.Open_table_Click);
            // 
            // cancel_table
            // 
            this.cancel_table.Name = "cancel_table";
            this.cancel_table.Size = new System.Drawing.Size(124, 22);
            this.cancel_table.Text = "取消开台";
            this.cancel_table.Click += new System.EventHandler(this.Cancel_table_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // add_food
            // 
            this.add_food.Name = "add_food";
            this.add_food.Size = new System.Drawing.Size(124, 22);
            this.add_food.Text = "点\\加菜";
            this.add_food.Click += new System.EventHandler(this.Add_food_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // check_bill
            // 
            this.check_bill.Name = "check_bill";
            this.check_bill.Size = new System.Drawing.Size(124, 22);
            this.check_bill.Text = "消费查询";
            this.check_bill.Click += new System.EventHandler(this.Check_bill_Click);
            // 
            // pay_bill
            // 
            this.pay_bill.Name = "pay_bill";
            this.pay_bill.Size = new System.Drawing.Size(124, 22);
            this.pay_bill.Text = "结账";
            this.pay_bill.Click += new System.EventHandler(this.Pay_bill_Click);
            // 
            // lvDesk
            // 
            this.lvDesk.BackgroundImage = global::cygl.UI.Properties.Resources.餐具背景;
            this.lvDesk.BackgroundImageTiled = true;
            this.lvDesk.ContextMenuStrip = this.rightclick_menu;
            this.lvDesk.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvDesk.Font = new System.Drawing.Font("楷体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvDesk.HideSelection = false;
            this.lvDesk.LargeImageList = this.imageList1;
            this.lvDesk.Location = new System.Drawing.Point(0, 30);
            this.lvDesk.MultiSelect = false;
            this.lvDesk.Name = "lvDesk";
            this.lvDesk.Size = new System.Drawing.Size(886, 453);
            this.lvDesk.TabIndex = 5;
            this.lvDesk.UseCompatibleStateImageBehavior = false;
            this.lvDesk.SelectedIndexChanged += new System.EventHandler(this.LvDesk_SelectedIndexChanged);
            this.lvDesk.Click += new System.EventHandler(this.LvDesk_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "空桌.jpg");
            this.imageList1.Images.SetKeyName(1, "餐馆进餐.jpg");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "餐饮管理系统";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_tool,
            this.exit_tool1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // open_tool
            // 
            this.open_tool.Name = "open_tool";
            this.open_tool.Size = new System.Drawing.Size(100, 22);
            this.open_tool.Text = "打开";
            this.open_tool.Click += new System.EventHandler(this.Open_tool_Click);
            // 
            // exit_tool1
            // 
            this.exit_tool1.Name = "exit_tool1";
            this.exit_tool1.Size = new System.Drawing.Size(100, 22);
            this.exit_tool1.Text = "退出";
            this.exit_tool1.Click += new System.EventHandler(this.Exit_tool1_Click);
            // 
            // main_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.蔬菜;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 483);
            this.Controls.Add(this.lvDesk);
            this.Controls.Add(this.main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.main_menu;
            this.MaximizeBox = false;
            this.Name = "main_interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐饮管理系统";
            this.Activated += new System.EventHandler(this.Mainscreen_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainscreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainscreen_FormClosed);
            this.Load += new System.EventHandler(this.Mainscreen_Load);
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            this.rightclick_menu.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem table_infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staff_infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem food_infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalsystem_tool;
        private System.Windows.Forms.ToolStripMenuItem admin_register;
        private System.Windows.Forms.ToolStripMenuItem admin_change;
        private System.Windows.Forms.ToolStripMenuItem admin_cancel;
        private System.Windows.Forms.ToolStripMenuItem bill_record;
        private System.Windows.Forms.ToolStripMenuItem about_info;
        private System.Windows.Forms.ToolStripMenuItem exit_tool;
        private System.Windows.Forms.ContextMenuStrip rightclick_menu;
        private System.Windows.Forms.ToolStripMenuItem open_table;
        private System.Windows.Forms.ToolStripMenuItem cancel_table;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem add_food;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem check_bill;
        private System.Windows.Forms.ToolStripMenuItem pay_bill;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem open_tool;
        private System.Windows.Forms.ToolStripMenuItem exit_tool1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem calendar_tool;
        private System.Windows.Forms.ToolStripMenuItem calculator_tool;
        private System.Windows.Forms.ToolStripMenuItem notepad_tool;
        private System.Windows.Forms.ListView lvDesk;
    }
}