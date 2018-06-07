namespace cygl.UI
{
    partial class table_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(table_info));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnquery = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labeltablename = new System.Windows.Forms.Label();
            this.labeltableshort = new System.Windows.Forms.Label();
            this.labelroom = new System.Windows.Forms.Label();
            this.labeltableloc = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtabb = new System.Windows.Forms.TextBox();
            this.txtfee = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnquery);
            this.groupBox1.Controls.Add(this.btnmodify);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(19, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(552, 20);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 37);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
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
            this.btnquery.Location = new System.Drawing.Point(17, 20);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(95, 37);
            this.btnquery.TabIndex = 6;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = true;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmodify.Location = new System.Drawing.Point(283, 20);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(129, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(504, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id";
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "roomname";
            this.Column1.HeaderText = "桌台名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "roomabb";
            this.Column2.HeaderText = "桌台简称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "roomfee";
            this.Column3.HeaderText = "包间费";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "roomlocation";
            this.Column4.HeaderText = "桌台位置";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.Color.Transparent;
            this.labeltitle.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.Location = new System.Drawing.Point(256, 16);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(200, 35);
            this.labeltitle.TabIndex = 2;
            this.labeltitle.Text = "桌台信息表";
            // 
            // labeltablename
            // 
            this.labeltablename.AutoSize = true;
            this.labeltablename.BackColor = System.Drawing.Color.Transparent;
            this.labeltablename.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltablename.Location = new System.Drawing.Point(246, 340);
            this.labeltablename.Name = "labeltablename";
            this.labeltablename.Size = new System.Drawing.Size(99, 20);
            this.labeltablename.TabIndex = 3;
            this.labeltablename.Text = "桌台名称:";
            // 
            // labeltableshort
            // 
            this.labeltableshort.AutoSize = true;
            this.labeltableshort.BackColor = System.Drawing.Color.Transparent;
            this.labeltableshort.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltableshort.Location = new System.Drawing.Point(15, 385);
            this.labeltableshort.Name = "labeltableshort";
            this.labeltableshort.Size = new System.Drawing.Size(109, 20);
            this.labeltableshort.TabIndex = 3;
            this.labeltableshort.Text = "桌台简称：";
            // 
            // labelroom
            // 
            this.labelroom.AutoSize = true;
            this.labelroom.BackColor = System.Drawing.Color.Transparent;
            this.labelroom.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelroom.Location = new System.Drawing.Point(245, 385);
            this.labelroom.Name = "labelroom";
            this.labelroom.Size = new System.Drawing.Size(109, 20);
            this.labelroom.TabIndex = 3;
            this.labelroom.Text = "包 间 费：";
            // 
            // labeltableloc
            // 
            this.labeltableloc.AutoSize = true;
            this.labeltableloc.BackColor = System.Drawing.Color.Transparent;
            this.labeltableloc.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltableloc.Location = new System.Drawing.Point(472, 340);
            this.labeltableloc.Name = "labeltableloc";
            this.labeltableloc.Size = new System.Drawing.Size(99, 20);
            this.labeltableloc.TabIndex = 3;
            this.labeltableloc.Text = "桌台位置:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(348, 340);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(124, 21);
            this.txtname.TabIndex = 2;
            // 
            // txtabb
            // 
            this.txtabb.Location = new System.Drawing.Point(115, 385);
            this.txtabb.Name = "txtabb";
            this.txtabb.Size = new System.Drawing.Size(124, 21);
            this.txtabb.TabIndex = 3;
            // 
            // txtfee
            // 
            this.txtfee.Location = new System.Drawing.Point(348, 385);
            this.txtfee.Name = "txtfee";
            this.txtfee.Size = new System.Drawing.Size(124, 21);
            this.txtfee.TabIndex = 4;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(570, 340);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(110, 21);
            this.txtlocation.TabIndex = 5;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelid.Location = new System.Drawing.Point(70, 341);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(39, 20);
            this.labelid.TabIndex = 3;
            this.labelid.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(115, 340);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(124, 21);
            this.txtid.TabIndex = 1;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnreset.Location = new System.Drawing.Point(570, 373);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(82, 36);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "重置";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // table_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.背景青;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 494);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtfee);
            this.Controls.Add(this.txtabb);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labeltableloc);
            this.Controls.Add(this.labelroom);
            this.Controls.Add(this.labeltableshort);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labeltablename);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "table_info";
            this.Text = "桌台信息";
            this.Load += new System.EventHandler(this.table_inform_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labeltablename;
        private System.Windows.Forms.Label labeltableshort;
        private System.Windows.Forms.Label labelroom;
        private System.Windows.Forms.Label labeltableloc;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtabb;
        private System.Windows.Forms.TextBox txtfee;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnreset;
    }
}