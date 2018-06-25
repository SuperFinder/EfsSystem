namespace EfsSystem
{
    partial class FormSparePartInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddSparePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sparePartSpecification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSparePartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddSparePartToolStripMenuItem
            // 
            this.AddSparePartToolStripMenuItem.Name = "AddSparePartToolStripMenuItem";
            this.AddSparePartToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.AddSparePartToolStripMenuItem.Text = "添加备件";
            this.AddSparePartToolStripMenuItem.Click += new System.EventHandler(this.AddSparePartToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sparePartName,
            this.sparePartVersion,
            this.sparePartSpecification,
            this.modify});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 423);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // sparePartName
            // 
            this.sparePartName.DataPropertyName = "spare_part_name";
            this.sparePartName.HeaderText = "备件名称";
            this.sparePartName.Name = "sparePartName";
            // 
            // sparePartVersion
            // 
            this.sparePartVersion.DataPropertyName = "spare_part_version";
            this.sparePartVersion.HeaderText = "备件型号";
            this.sparePartVersion.Name = "sparePartVersion";
            // 
            // sparePartSpecification
            // 
            this.sparePartSpecification.DataPropertyName = "spare_part_specification";
            this.sparePartSpecification.HeaderText = "备件规格";
            this.sparePartSpecification.Name = "sparePartSpecification";
            // 
            // modify
            // 
            this.modify.DataPropertyName = "modify";
            this.modify.HeaderText = "修改";
            this.modify.Name = "modify";
            this.modify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormSparePartInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSparePartInfo";
            this.ShowIcon = false;
            this.Text = "备件信息维护";
            this.Load += new System.EventHandler(this.FormSparePartInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddSparePartToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sparePartSpecification;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
    }
}