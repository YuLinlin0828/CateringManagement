namespace cygl.UI
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnpay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rest0 = new System.Windows.Forms.Label();
            this.changecoin = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.cashier = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.Label();
            this.labelsum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvRecord.Location = new System.Drawing.Point(28, 43);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.RowTemplate.Height = 23;
            this.dgvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecord.Size = new System.Drawing.Size(281, 209);
            this.dgvRecord.TabIndex = 2;
            this.dgvRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecord_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "foodname";
            this.Column1.HeaderText = "菜名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "foodsum";
            this.Column2.HeaderText = "数量";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "foodallprice";
            this.Column3.HeaderText = "总价";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "waitername";
            this.Column4.HeaderText = "服务员";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "roomname";
            this.Column5.HeaderText = "桌台";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "beizhu";
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "datatime";
            this.Column7.HeaderText = "日期";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(92, 186);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnpay
            // 
            this.btnpay.Location = new System.Drawing.Point(6, 186);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(75, 23);
            this.btnpay.TabIndex = 6;
            this.btnpay.Text = "结账";
            this.btnpay.UseVisualStyleBackColor = true;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnpay);
            this.groupBox2.Controls.Add(this.rest0);
            this.groupBox2.Controls.Add(this.changecoin);
            this.groupBox2.Controls.Add(this.txtmoney);
            this.groupBox2.Controls.Add(this.cashier);
            this.groupBox2.Controls.Add(this.tprice);
            this.groupBox2.Controls.Add(this.labelsum);
            this.groupBox2.Location = new System.Drawing.Point(328, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 232);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rest0
            // 
            this.rest0.AutoSize = true;
            this.rest0.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rest0.Location = new System.Drawing.Point(67, 102);
            this.rest0.Name = "rest0";
            this.rest0.Size = new System.Drawing.Size(20, 20);
            this.rest0.TabIndex = 5;
            this.rest0.Text = "0";
            // 
            // changecoin
            // 
            this.changecoin.AutoSize = true;
            this.changecoin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changecoin.Location = new System.Drawing.Point(18, 102);
            this.changecoin.Name = "changecoin";
            this.changecoin.Size = new System.Drawing.Size(49, 14);
            this.changecoin.TabIndex = 4;
            this.changecoin.Text = "找零：";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(67, 59);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(100, 21);
            this.txtmoney.TabIndex = 3;
            this.txtmoney.TextChanged += new System.EventHandler(this.txtmoney_TextChanged);
            this.txtmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmoney_KeyPress);
            // 
            // cashier
            // 
            this.cashier.AutoSize = true;
            this.cashier.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cashier.Location = new System.Drawing.Point(18, 63);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(49, 14);
            this.cashier.TabIndex = 2;
            this.cashier.Text = "收银：";
            // 
            // tprice
            // 
            this.tprice.AutoSize = true;
            this.tprice.Location = new System.Drawing.Point(65, 36);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(0, 12);
            this.tprice.TabIndex = 1;
            // 
            // labelsum
            // 
            this.labelsum.AutoSize = true;
            this.labelsum.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelsum.Location = new System.Drawing.Point(-1, 25);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(89, 19);
            this.labelsum.TabIndex = 0;
            this.labelsum.Text = "总金额：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvRecord);
            this.groupBox1.Location = new System.Drawing.Point(13, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.背景青;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Payment";
            this.Text = "结账";
            this.Load += new System.EventHandler(this.jz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label rest0;
        private System.Windows.Forms.Label changecoin;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label cashier;
        private System.Windows.Forms.Label tprice;
        private System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}