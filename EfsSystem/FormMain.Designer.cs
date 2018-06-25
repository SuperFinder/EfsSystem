namespace EfsSystem
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparePartsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceInfoSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceInfoStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faultInfoStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveOverInfoStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemConfigToolStripMenuItem,
            this.serviceInfoSearchToolStripMenuItem,
            this.serviceInfoStatisticsToolStripMenuItem,
            this.faultInfoStatisticsToolStripMenuItem,
            this.leaveOverInfoStatisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemConfigToolStripMenuItem
            // 
            this.systemConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInfoToolStripMenuItem,
            this.userInfoToolStripMenuItem,
            this.equipsInfoToolStripMenuItem,
            this.sparePartsInfoToolStripMenuItem});
            this.systemConfigToolStripMenuItem.Name = "systemConfigToolStripMenuItem";
            this.systemConfigToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.systemConfigToolStripMenuItem.Text = "系统配置";
            // 
            // customerInfoToolStripMenuItem
            // 
            this.customerInfoToolStripMenuItem.Name = "customerInfoToolStripMenuItem";
            this.customerInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerInfoToolStripMenuItem.Text = "客户信息";
            this.customerInfoToolStripMenuItem.Click += new System.EventHandler(this.customerInfoToolStripMenuItem_Click);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userInfoToolStripMenuItem.Text = "内部人员信息";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // equipsInfoToolStripMenuItem
            // 
            this.equipsInfoToolStripMenuItem.Name = "equipsInfoToolStripMenuItem";
            this.equipsInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equipsInfoToolStripMenuItem.Text = "装备信息";
            this.equipsInfoToolStripMenuItem.Click += new System.EventHandler(this.equipsInfoToolStripMenuItem_Click);
            // 
            // sparePartsInfoToolStripMenuItem
            // 
            this.sparePartsInfoToolStripMenuItem.Name = "sparePartsInfoToolStripMenuItem";
            this.sparePartsInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sparePartsInfoToolStripMenuItem.Text = "备件信息";
            this.sparePartsInfoToolStripMenuItem.Click += new System.EventHandler(this.sparePartsInfoToolStripMenuItem_Click);
            // 
            // serviceInfoSearchToolStripMenuItem
            // 
            this.serviceInfoSearchToolStripMenuItem.Name = "serviceInfoSearchToolStripMenuItem";
            this.serviceInfoSearchToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.serviceInfoSearchToolStripMenuItem.Text = "服务信息查询";
            this.serviceInfoSearchToolStripMenuItem.Click += new System.EventHandler(this.serviceInfoSearchToolStripMenuItem_Click);
            // 
            // serviceInfoStatisticsToolStripMenuItem
            // 
            this.serviceInfoStatisticsToolStripMenuItem.Name = "serviceInfoStatisticsToolStripMenuItem";
            this.serviceInfoStatisticsToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.serviceInfoStatisticsToolStripMenuItem.Text = "服务信息统计";
            this.serviceInfoStatisticsToolStripMenuItem.Click += new System.EventHandler(this.serviceInfoStatisticsToolStripMenuItem_Click);
            // 
            // faultInfoStatisticsToolStripMenuItem
            // 
            this.faultInfoStatisticsToolStripMenuItem.Name = "faultInfoStatisticsToolStripMenuItem";
            this.faultInfoStatisticsToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.faultInfoStatisticsToolStripMenuItem.Text = "故障信息统计";
            this.faultInfoStatisticsToolStripMenuItem.Click += new System.EventHandler(this.faultInfoStatisticsToolStripMenuItem_Click);
            // 
            // leaveOverInfoStatisticsToolStripMenuItem
            // 
            this.leaveOverInfoStatisticsToolStripMenuItem.Name = "leaveOverInfoStatisticsToolStripMenuItem";
            this.leaveOverInfoStatisticsToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.leaveOverInfoStatisticsToolStripMenuItem.Text = "遗留问题统计";
            this.leaveOverInfoStatisticsToolStripMenuItem.Click += new System.EventHandler(this.leaveOverInfoStatisticsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "装备故障统计系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparePartsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceInfoSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceInfoStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faultInfoStatisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveOverInfoStatisticsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

