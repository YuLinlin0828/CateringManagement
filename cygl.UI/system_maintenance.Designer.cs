namespace cygl.UI
{
    partial class system_maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(system_maintenance));
            this.labeltitle = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.labelpw = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtuserpw = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labeltitle
            // 
            this.labeltitle.BackColor = System.Drawing.Color.Transparent;
            this.labeltitle.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labeltitle.Location = new System.Drawing.Point(144, 35);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(133, 33);
            this.labeltitle.TabIndex = 4;
            this.labeltitle.Text = "管理员";
            this.labeltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.BackColor = System.Drawing.Color.Transparent;
            this.labeluser.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeluser.Location = new System.Drawing.Point(117, 102);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(68, 16);
            this.labeluser.TabIndex = 0;
            this.labeluser.Text = "用户名:";
            // 
            // labelpw
            // 
            this.labelpw.AutoSize = true;
            this.labelpw.BackColor = System.Drawing.Color.Transparent;
            this.labelpw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelpw.Location = new System.Drawing.Point(117, 173);
            this.labelpw.Name = "labelpw";
            this.labelpw.Size = new System.Drawing.Size(69, 16);
            this.labelpw.TabIndex = 0;
            this.labelpw.Text = "密  码:";
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlogin.Location = new System.Drawing.Point(170, 265);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(80, 30);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtuserpw
            // 
            this.txtuserpw.Location = new System.Drawing.Point(183, 170);
            this.txtuserpw.Name = "txtuserpw";
            this.txtuserpw.PasswordChar = '*';
            this.txtuserpw.Size = new System.Drawing.Size(130, 21);
            this.txtuserpw.TabIndex = 2;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(183, 100);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(130, 21);
            this.txtusername.TabIndex = 1;
            // 
            // system_maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.背景青;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(407, 330);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtuserpw);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.labelpw);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.labeltitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "system_maintenance";
            this.Text = "系统维护";
            this.Load += new System.EventHandler(this.sysmaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label labelpw;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtuserpw;
        private System.Windows.Forms.TextBox txtusername;
    }
}