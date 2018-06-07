namespace cygl.UI
{
    partial class food_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(food_info));
            this.labelt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_foodkind = new System.Windows.Forms.Label();
            this.label_foodname = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnquery = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.BackColor = System.Drawing.Color.Transparent;
            this.labelt.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelt.Location = new System.Drawing.Point(248, 9);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(200, 35);
            this.labelt.TabIndex = 4;
            this.labelt.Text = "菜品信息表";
            this.labelt.Click += new System.EventHandler(this.labelt_Click);
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(103, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 5;
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
            this.Column2.DataPropertyName = "foodname";
            this.Column2.HeaderText = "菜品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "foodtype";
            this.Column3.HeaderText = "菜品类型";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "foodnum";
            this.Column4.HeaderText = "菜品数量";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "foodprice";
            this.Column5.HeaderText = "菜品价格";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(103, 280);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(124, 21);
            this.txtid.TabIndex = 0;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.Transparent;
            this.label_id.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_id.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_id.Location = new System.Drawing.Point(55, 280);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(42, 20);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "ID:";
            // 
            // label_foodkind
            // 
            this.label_foodkind.AutoSize = true;
            this.label_foodkind.BackColor = System.Drawing.Color.Transparent;
            this.label_foodkind.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_foodkind.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_foodkind.Location = new System.Drawing.Point(4, 335);
            this.label_foodkind.Name = "label_foodkind";
            this.label_foodkind.Size = new System.Drawing.Size(104, 20);
            this.label_foodkind.TabIndex = 9;
            this.label_foodkind.Text = "菜品类型:";
            // 
            // label_foodname
            // 
            this.label_foodname.AutoSize = true;
            this.label_foodname.BackColor = System.Drawing.Color.Transparent;
            this.label_foodname.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_foodname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_foodname.Location = new System.Drawing.Point(239, 280);
            this.label_foodname.Name = "label_foodname";
            this.label_foodname.Size = new System.Drawing.Size(104, 20);
            this.label_foodname.TabIndex = 9;
            this.label_foodname.Text = "菜品名称:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(338, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.Transparent;
            this.label_price.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_price.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_price.Location = new System.Drawing.Point(468, 335);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(104, 20);
            this.label_price.TabIndex = 9;
            this.label_price.Text = "菜品价格:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(573, 335);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 21);
            this.textBox3.TabIndex = 4;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnexit.Location = new System.Drawing.Point(552, 20);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 37);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.White;
            this.btnmodify.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmodify.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnmodify.Location = new System.Drawing.Point(285, 20);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(95, 37);
            this.btnmodify.TabIndex = 7;
            this.btnmodify.Text = "修改";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnexit);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnquery);
            this.groupBox1.Controls.Add(this.btnmodify);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Location = new System.Drawing.Point(21, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 72);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btndelete.Location = new System.Drawing.Point(421, 20);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 37);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnquery
            // 
            this.btnquery.BackColor = System.Drawing.Color.White;
            this.btnquery.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnquery.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnquery.Location = new System.Drawing.Point(17, 20);
            this.btnquery.Name = "btnquery";
            this.btnquery.Size = new System.Drawing.Size(95, 37);
            this.btnquery.TabIndex = 5;
            this.btnquery.Text = "查询";
            this.btnquery.UseVisualStyleBackColor = false;
            this.btnquery.Click += new System.EventHandler(this.btnquery_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnadd.Location = new System.Drawing.Point(145, 20);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 37);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(239, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "菜品数量:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(338, 280);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 21);
            this.textBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "新菜",
            "小炒",
            "火锅和汤类",
            "主食",
            "酒类",
            "香烟",
            "饮料"});
            this.comboBox1.Location = new System.Drawing.Point(103, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.White;
            this.btnreset.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnreset.Location = new System.Drawing.Point(573, 272);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(92, 37);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "重置";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // food_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.背景青;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 445);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_foodname);
            this.Controls.Add(this.label_foodkind);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "food_info";
            this.Text = "菜品信息";
            this.Load += new System.EventHandler(this.food_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_foodkind;
        private System.Windows.Forms.Label label_foodname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnquery;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnreset;
    }
}