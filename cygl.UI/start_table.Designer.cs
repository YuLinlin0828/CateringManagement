namespace cygl.UI
{
    partial class start_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start_table));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.remark = new System.Windows.Forms.TextBox();
            this.labelremark = new System.Windows.Forms.Label();
            this.theWaiter = new System.Windows.Forms.ComboBox();
            this.lwaiter = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lusernum = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lusernname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_billdate = new System.Windows.Forms.Label();
            this.tableno = new System.Windows.Forms.ComboBox();
            this.label_tableno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Location = new System.Drawing.Point(265, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 34);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Location = new System.Drawing.Point(120, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 34);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // remark
            // 
            this.remark.Location = new System.Drawing.Point(310, 130);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(135, 21);
            this.remark.TabIndex = 25;
            // 
            // labelremark
            // 
            this.labelremark.AutoSize = true;
            this.labelremark.BackColor = System.Drawing.Color.Transparent;
            this.labelremark.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelremark.Location = new System.Drawing.Point(263, 133);
            this.labelremark.Name = "labelremark";
            this.labelremark.Size = new System.Drawing.Size(49, 14);
            this.labelremark.TabIndex = 24;
            this.labelremark.Text = "备注：";
            // 
            // theWaiter
            // 
            this.theWaiter.FormattingEnabled = true;
            this.theWaiter.Location = new System.Drawing.Point(97, 130);
            this.theWaiter.Name = "theWaiter";
            this.theWaiter.Size = new System.Drawing.Size(121, 20);
            this.theWaiter.TabIndex = 23;
            // 
            // lwaiter
            // 
            this.lwaiter.AutoSize = true;
            this.lwaiter.BackColor = System.Drawing.Color.Transparent;
            this.lwaiter.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lwaiter.Location = new System.Drawing.Point(39, 133);
            this.lwaiter.Name = "lwaiter";
            this.lwaiter.Size = new System.Drawing.Size(63, 14);
            this.lwaiter.TabIndex = 22;
            this.lwaiter.Text = "服务员：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(310, 85);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(135, 21);
            this.txtNum.TabIndex = 21;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // lusernum
            // 
            this.lusernum.AutoSize = true;
            this.lusernum.BackColor = System.Drawing.Color.Transparent;
            this.lusernum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lusernum.Location = new System.Drawing.Point(237, 88);
            this.lusernum.Name = "lusernum";
            this.lusernum.Size = new System.Drawing.Size(77, 14);
            this.lusernum.TabIndex = 20;
            this.lusernum.Text = "用餐人数：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 21);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "Guest";
            // 
            // lusernname
            // 
            this.lusernname.AutoSize = true;
            this.lusernname.BackColor = System.Drawing.Color.Transparent;
            this.lusernname.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lusernname.Location = new System.Drawing.Point(27, 88);
            this.lusernname.Name = "lusernname";
            this.lusernname.Size = new System.Drawing.Size(77, 14);
            this.lusernname.TabIndex = 18;
            this.lusernname.Text = "顾客名称：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label_billdate
            // 
            this.label_billdate.AutoSize = true;
            this.label_billdate.BackColor = System.Drawing.Color.Transparent;
            this.label_billdate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_billdate.Location = new System.Drawing.Point(237, 44);
            this.label_billdate.Name = "label_billdate";
            this.label_billdate.Size = new System.Drawing.Size(77, 14);
            this.label_billdate.TabIndex = 16;
            this.label_billdate.Text = "账单日期：";
            // 
            // tableno
            // 
            this.tableno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableno.FormattingEnabled = true;
            this.tableno.Location = new System.Drawing.Point(97, 40);
            this.tableno.Name = "tableno";
            this.tableno.Size = new System.Drawing.Size(121, 20);
            this.tableno.TabIndex = 15;
            // 
            // label_tableno
            // 
            this.label_tableno.AutoSize = true;
            this.label_tableno.BackColor = System.Drawing.Color.Transparent;
            this.label_tableno.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_tableno.Location = new System.Drawing.Point(27, 43);
            this.label_tableno.Name = "label_tableno";
            this.label_tableno.Size = new System.Drawing.Size(77, 14);
            this.label_tableno.TabIndex = 14;
            this.label_tableno.Text = "桌台编号：";
            // 
            // start_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.蔬菜;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 283);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.labelremark);
            this.Controls.Add(this.theWaiter);
            this.Controls.Add(this.lwaiter);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lusernum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lusernname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_billdate);
            this.Controls.Add(this.tableno);
            this.Controls.Add(this.label_tableno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "start_table";
            this.Text = "开台";
            this.Load += new System.EventHandler(this.start_table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.Label labelremark;
        private System.Windows.Forms.ComboBox theWaiter;
        private System.Windows.Forms.Label lwaiter;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lusernum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lusernname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_billdate;
        private System.Windows.Forms.ComboBox tableno;
        private System.Windows.Forms.Label label_tableno;
    }
}