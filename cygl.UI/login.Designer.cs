namespace cygl.UI
{
    partial class login
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
        /// 初始化控件——登录login界面
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelpw = new System.Windows.Forms.Label();
            this.labelt = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtpwd.Location = new System.Drawing.Point(432, 274);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(166, 26);
            this.txtpwd.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.Location = new System.Drawing.Point(432, 239);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(166, 26);
            this.txtname.TabIndex = 1;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelname.Location = new System.Drawing.Point(338, 244);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(79, 21);
            this.labelname.TabIndex = 3;
            this.labelname.Text = "用户名";
            // 
            // labelpw
            // 
            this.labelpw.AutoSize = true;
            this.labelpw.BackColor = System.Drawing.Color.Transparent;
            this.labelpw.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelpw.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelpw.Location = new System.Drawing.Point(361, 279);
            this.labelpw.Name = "labelpw";
            this.labelpw.Size = new System.Drawing.Size(56, 21);
            this.labelpw.TabIndex = 3;
            this.labelpw.Text = "密码";
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.BackColor = System.Drawing.Color.Transparent;
            this.labelt.Font = new System.Drawing.Font("幼圆", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelt.Location = new System.Drawing.Point(290, 136);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(418, 64);
            this.labelt.TabIndex = 8;
            this.labelt.Text = "餐饮管理系统";
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSize = true;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnlogin.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(428, 329);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(66, 31);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnquit
            // 
            this.btnquit.AutoSize = true;
            this.btnquit.BackColor = System.Drawing.Color.Transparent;
            this.btnquit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnquit.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnquit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnquit.Location = new System.Drawing.Point(513, 329);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(66, 31);
            this.btnquit.TabIndex = 4;
            this.btnquit.Text = "退出";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cygl.UI.Properties.Resources.背景白;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 533);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labelt);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelpw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "餐饮管理系统";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelpw;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnquit;
        // private System.Windows.Forms.Label label2;
        // private System.Windows.Forms.Label label3;
    }
}

