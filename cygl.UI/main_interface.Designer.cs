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

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_interface));
            this.zcd = new System.Windows.Forms.MenuStrip();
            this.桌台信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜品信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.日历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yjcd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.点加菜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.消费查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDesk = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zcd.SuspendLayout();
            this.yjcd.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zcd
            // 
            this.zcd.BackColor = System.Drawing.Color.Transparent;
            this.zcd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zcd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.桌台信息ToolStripMenuItem,
            this.职员信息ToolStripMenuItem,
            this.菜品信息ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.系统ToolStripMenuItem,
            this.历史账单ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出ToolStripMenuItem});
            this.zcd.Location = new System.Drawing.Point(0, 0);
            this.zcd.Name = "zcd";
            this.zcd.Size = new System.Drawing.Size(886, 27);
            this.zcd.TabIndex = 0;
            this.zcd.Text = "menuStrip1";
            this.zcd.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.zcd_ItemClicked);
            // 
            // 桌台信息ToolStripMenuItem
            // 
            this.桌台信息ToolStripMenuItem.Name = "桌台信息ToolStripMenuItem";
            this.桌台信息ToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.桌台信息ToolStripMenuItem.Text = "桌台信息";
            this.桌台信息ToolStripMenuItem.Click += new System.EventHandler(this.桌台信息ToolStripMenuItem_Click);
            // 
            // 职员信息ToolStripMenuItem
            // 
            this.职员信息ToolStripMenuItem.Name = "职员信息ToolStripMenuItem";
            this.职员信息ToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.职员信息ToolStripMenuItem.Text = "职员信息";
            this.职员信息ToolStripMenuItem.Click += new System.EventHandler(this.职员信息ToolStripMenuItem_Click);
            // 
            // 菜品信息ToolStripMenuItem
            // 
            this.菜品信息ToolStripMenuItem.Name = "菜品信息ToolStripMenuItem";
            this.菜品信息ToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.菜品信息ToolStripMenuItem.Text = "菜品信息";
            this.菜品信息ToolStripMenuItem.Click += new System.EventHandler(this.菜品信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日历ToolStripMenuItem,
            this.计算器ToolStripMenuItem,
            this.记事本ToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(105, 23);
            this.toolStripMenuItem2.Text = "辅助工具";
            // 
            // 日历ToolStripMenuItem
            // 
            this.日历ToolStripMenuItem.Name = "日历ToolStripMenuItem";
            this.日历ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.日历ToolStripMenuItem.Text = "日历";
            this.日历ToolStripMenuItem.Click += new System.EventHandler(this.日历ToolStripMenuItem_Click);
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 记事本ToolStripMenuItem
            // 
            this.记事本ToolStripMenuItem.Name = "记事本ToolStripMenuItem";
            this.记事本ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.记事本ToolStripMenuItem.Text = "记事本";
            this.记事本ToolStripMenuItem.Click += new System.EventHandler(this.记事本ToolStripMenuItem_Click);
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册管理员ToolStripMenuItem,
            this.修改管理员ToolStripMenuItem,
            this.注销管理员ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.系统ToolStripMenuItem.Text = "系统维护";
            // 
            // 注册管理员ToolStripMenuItem
            // 
            this.注册管理员ToolStripMenuItem.Name = "注册管理员ToolStripMenuItem";
            this.注册管理员ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.注册管理员ToolStripMenuItem.Text = "注册管理员";
            this.注册管理员ToolStripMenuItem.Click += new System.EventHandler(this.注册管理员ToolStripMenuItem_Click);
            // 
            // 修改管理员ToolStripMenuItem
            // 
            this.修改管理员ToolStripMenuItem.Name = "修改管理员ToolStripMenuItem";
            this.修改管理员ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.修改管理员ToolStripMenuItem.Text = "修改管理员";
            this.修改管理员ToolStripMenuItem.Click += new System.EventHandler(this.修改管理员ToolStripMenuItem_Click);
            // 
            // 注销管理员ToolStripMenuItem
            // 
            this.注销管理员ToolStripMenuItem.Name = "注销管理员ToolStripMenuItem";
            this.注销管理员ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.注销管理员ToolStripMenuItem.Text = "注销管理员";
            this.注销管理员ToolStripMenuItem.Click += new System.EventHandler(this.注销管理员ToolStripMenuItem_Click);
            // 
            // 历史账单ToolStripMenuItem
            // 
            this.历史账单ToolStripMenuItem.Name = "历史账单ToolStripMenuItem";
            this.历史账单ToolStripMenuItem.Size = new System.Drawing.Size(105, 23);
            this.历史账单ToolStripMenuItem.Text = "历史账单";
            this.历史账单ToolStripMenuItem.Click += new System.EventHandler(this.历史账单ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 23);
            this.toolStripMenuItem1.Text = "最小化";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // yjcd
            // 
            this.yjcd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开台ToolStripMenuItem,
            this.取消开台ToolStripMenuItem,
            this.toolStripSeparator3,
            this.点加菜ToolStripMenuItem,
            this.toolStripSeparator1,
            this.消费查询ToolStripMenuItem,
            this.结账ToolStripMenuItem});
            this.yjcd.Name = "yjcd";
            this.yjcd.Size = new System.Drawing.Size(125, 126);
            // 
            // 开台ToolStripMenuItem
            // 
            this.开台ToolStripMenuItem.Name = "开台ToolStripMenuItem";
            this.开台ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开台ToolStripMenuItem.Text = "开台";
            this.开台ToolStripMenuItem.Click += new System.EventHandler(this.开台ToolStripMenuItem_Click);
            // 
            // 取消开台ToolStripMenuItem
            // 
            this.取消开台ToolStripMenuItem.Name = "取消开台ToolStripMenuItem";
            this.取消开台ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.取消开台ToolStripMenuItem.Text = "取消开台";
            this.取消开台ToolStripMenuItem.Click += new System.EventHandler(this.取消开台ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(121, 6);
            // 
            // 点加菜ToolStripMenuItem
            // 
            this.点加菜ToolStripMenuItem.Name = "点加菜ToolStripMenuItem";
            this.点加菜ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.点加菜ToolStripMenuItem.Text = "点\\加菜";
            this.点加菜ToolStripMenuItem.Click += new System.EventHandler(this.点加菜ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 消费查询ToolStripMenuItem
            // 
            this.消费查询ToolStripMenuItem.Name = "消费查询ToolStripMenuItem";
            this.消费查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.消费查询ToolStripMenuItem.Text = "消费查询";
            this.消费查询ToolStripMenuItem.Click += new System.EventHandler(this.消费查询ToolStripMenuItem_Click);
            // 
            // 结账ToolStripMenuItem
            // 
            this.结账ToolStripMenuItem.Name = "结账ToolStripMenuItem";
            this.结账ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.结账ToolStripMenuItem.Text = "结账";
            this.结账ToolStripMenuItem.Click += new System.EventHandler(this.结账ToolStripMenuItem_Click);
            // 
            // lvDesk
            // 
            this.lvDesk.BackgroundImage = global::cygl.UI.Properties.Resources.背景;
            this.lvDesk.BackgroundImageTiled = true;
            this.lvDesk.ContextMenuStrip = this.yjcd;
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
            this.lvDesk.Click += new System.EventHandler(this.lvDesk_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a_1.gif");
            this.imageList1.Images.SetKeyName(1, "a_2.gif");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "餐饮管理系统";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // main_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.背景;
            this.ClientSize = new System.Drawing.Size(886, 483);
            this.Controls.Add(this.lvDesk);
            this.Controls.Add(this.zcd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.zcd;
            this.MaximizeBox = false;
            this.Name = "main_interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "餐饮管理系统";
            this.Activated += new System.EventHandler(this.zjm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.zjm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.zjm_FormClosed);
            this.Load += new System.EventHandler(this.zjm_Load);
            this.zcd.ResumeLayout(false);
            this.zcd.PerformLayout();
            this.yjcd.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip zcd;
        private System.Windows.Forms.ToolStripMenuItem 桌台信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜品信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip yjcd;
        private System.Windows.Forms.ToolStripMenuItem 开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 点加菜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 消费查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结账ToolStripMenuItem;
        public System.Windows.Forms.ListView lvDesk;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 日历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记事本ToolStripMenuItem;

    }
}