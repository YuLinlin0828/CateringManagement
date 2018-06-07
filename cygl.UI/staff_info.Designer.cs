namespace cygl.UI
{
    partial class staff_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff_info));
            this.labeltitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnquery = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lgender = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.labelnum = new System.Windows.Forms.Label();
            this.txtidcard = new System.Windows.Forms.TextBox();
            this.phonenum = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comsex = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.Color.Transparent;
            this.labeltitle.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.Location = new System.Drawing.Point(194, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(200, 35);
            this.labeltitle.TabIndex = 3;
            this.labeltitle.Text = "职员信息表";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(552, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 37);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndelete.Location = new System.Drawing.Point(421, 20);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 37);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnquery
            // 
            this.btnquery.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnquery.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquery.Location = new System.Drawing.Point(17, 20);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(95, 37);
            this.btnquery.TabIndex = 6;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnquery);
            this.groupBox1.Controls.Add(this.btnmodify);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(14, 415);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnmodify
            // 
            this.btnmodify.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmodify.Location = new System.Drawing.Point(285, 20);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(95, 37);
            this.btnmodify.TabIndex = 8;
            this.btnmodify.Text = "修改";
            this.btnmodify.UseVisualStyleBackColor = true;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnadd.Location = new System.Drawing.Point(145, 20);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 37);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(200, 260);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(124, 21);
            this.txtid.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(155, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelname.Location = new System.Drawing.Point(361, 260);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(99, 20);
            this.labelname.TabIndex = 7;
            this.labelname.Text = "职员姓名:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(466, 260);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(124, 21);
            this.txtname.TabIndex = 1;
            // 
            // lgender
            // 
            this.lgender.AutoSize = true;
            this.lgender.BackColor = System.Drawing.Color.Transparent;
            this.lgender.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lgender.Location = new System.Drawing.Point(95, 315);
            this.lgender.Name = "lgender";
            this.lgender.Size = new System.Drawing.Size(99, 20);
            this.lgender.TabIndex = 7;
            this.lgender.Text = "职员性别:";
            this.lgender.Click += new System.EventHandler(this.lgender_Click);
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.BackColor = System.Drawing.Color.Transparent;
            this.labelage.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelage.Location = new System.Drawing.Point(361, 315);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(99, 20);
            this.labelage.TabIndex = 7;
            this.labelage.Text = "职员年龄:";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(466, 315);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(124, 21);
            this.txtage.TabIndex = 3;
            // 
            // labelnum
            // 
            this.labelnum.AutoSize = true;
            this.labelnum.BackColor = System.Drawing.Color.Transparent;
            this.labelnum.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelnum.Location = new System.Drawing.Point(95, 370);
            this.labelnum.Name = "labelnum";
            this.labelnum.Size = new System.Drawing.Size(99, 20);
            this.labelnum.TabIndex = 7;
            this.labelnum.Text = "身份证号:";
            // 
            // txtidcard
            // 
            this.txtidcard.Location = new System.Drawing.Point(200, 370);
            this.txtidcard.Name = "txtidcard";
            this.txtidcard.Size = new System.Drawing.Size(124, 21);
            this.txtidcard.TabIndex = 4;
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.BackColor = System.Drawing.Color.Transparent;
            this.phonenum.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phonenum.Location = new System.Drawing.Point(361, 370);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(99, 20);
            this.phonenum.TabIndex = 7;
            this.phonenum.Text = "手机号码:";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(466, 370);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(124, 21);
            this.txttel.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(40, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(603, 161);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "waitername";
            this.Column2.HeaderText = "职员姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sex";
            this.Column3.HeaderText = "职员性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "age";
            this.Column4.HeaderText = "职员年龄";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idcard";
            this.Column5.HeaderText = "身份证号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tel";
            this.Column6.HeaderText = "手机号码";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // comsex
            // 
            this.comsex.FormattingEnabled = true;
            this.comsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comsex.Location = new System.Drawing.Point(200, 315);
            this.comsex.Name = "comsex";
            this.comsex.Size = new System.Drawing.Size(124, 20);
            this.comsex.TabIndex = 9;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnreset.Location = new System.Drawing.Point(617, 358);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(65, 32);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "重置";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // staff_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.背景白;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 498);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.comsex);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtidcard);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.labelnum);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.lgender);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labeltitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "staff_info";
            this.Text = "职员信息";
            this.Load += new System.EventHandler(this.staff_info_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lgender;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label labelnum;
        private System.Windows.Forms.TextBox txtidcard;
        private System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox comsex;
        private System.Windows.Forms.Button btnreset;
    }
}