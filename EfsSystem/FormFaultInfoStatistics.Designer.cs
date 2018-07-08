namespace EfsSystem
{
    partial class FormFaultInfoStatistics
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
            this.cmbServiceStyle = new System.Windows.Forms.ComboBox();
            this.cmbResponsibleUserName = new System.Windows.Forms.ComboBox();
            this.cmbUnitName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.equip_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equip_version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.falut_info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maintenance_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spare_part_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spare_part_version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spare_part_specification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spare_part_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbServiceStyle
            // 
            this.cmbServiceStyle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbServiceStyle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbServiceStyle.FormattingEnabled = true;
            this.cmbServiceStyle.Items.AddRange(new object[] {
            "全部",
            "售后",
            "巡修"});
            this.cmbServiceStyle.Location = new System.Drawing.Point(779, 12);
            this.cmbServiceStyle.Name = "cmbServiceStyle";
            this.cmbServiceStyle.Size = new System.Drawing.Size(220, 20);
            this.cmbServiceStyle.TabIndex = 7;
            this.cmbServiceStyle.Text = "请选择服务类型";
            this.cmbServiceStyle.TextChanged += new System.EventHandler(this.cmbServiceStyle_TextChanged);
            // 
            // cmbResponsibleUserName
            // 
            this.cmbResponsibleUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResponsibleUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbResponsibleUserName.FormattingEnabled = true;
            this.cmbResponsibleUserName.Location = new System.Drawing.Point(553, 12);
            this.cmbResponsibleUserName.Name = "cmbResponsibleUserName";
            this.cmbResponsibleUserName.Size = new System.Drawing.Size(220, 20);
            this.cmbResponsibleUserName.TabIndex = 8;
            this.cmbResponsibleUserName.Text = "请选择带队人";
            this.cmbResponsibleUserName.TextChanged += new System.EventHandler(this.cmbResponsibleUserName_TextChanged);
            // 
            // cmbUnitName
            // 
            this.cmbUnitName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUnitName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbUnitName.FormattingEnabled = true;
            this.cmbUnitName.Location = new System.Drawing.Point(327, 12);
            this.cmbUnitName.Name = "cmbUnitName";
            this.cmbUnitName.Size = new System.Drawing.Size(220, 20);
            this.cmbUnitName.TabIndex = 9;
            this.cmbUnitName.Text = "请选择单位";
            this.cmbUnitName.TextChanged += new System.EventHandler(this.cmbUnitName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "至";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(173, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 21);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 21);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.equip_name,
            this.equip_version,
            this.falut_info,
            this.maintenance_mode,
            this.spare_part_name,
            this.spare_part_version,
            this.spare_part_specification,
            this.spare_part_count});
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1349, 653);
            this.dataGridView1.TabIndex = 11;
            // 
            // equip_name
            // 
            this.equip_name.DataPropertyName = "equip_name";
            this.equip_name.HeaderText = "装备名称";
            this.equip_name.Name = "equip_name";
            // 
            // equip_version
            // 
            this.equip_version.DataPropertyName = "equip_version";
            this.equip_version.HeaderText = "装备编号";
            this.equip_version.Name = "equip_version";
            // 
            // falut_info
            // 
            this.falut_info.DataPropertyName = "falut_info";
            this.falut_info.HeaderText = "故障现象";
            this.falut_info.Name = "falut_info";
            // 
            // maintenance_mode
            // 
            this.maintenance_mode.DataPropertyName = "maintenance_mode";
            this.maintenance_mode.HeaderText = "维修方式";
            this.maintenance_mode.Name = "maintenance_mode";
            // 
            // spare_part_name
            // 
            this.spare_part_name.DataPropertyName = "spare_part_name";
            this.spare_part_name.HeaderText = "备件名称";
            this.spare_part_name.Name = "spare_part_name";
            // 
            // spare_part_version
            // 
            this.spare_part_version.DataPropertyName = "spare_part_version";
            this.spare_part_version.HeaderText = "备件型号";
            this.spare_part_version.Name = "spare_part_version";
            // 
            // spare_part_specification
            // 
            this.spare_part_specification.DataPropertyName = "spare_part_specification";
            this.spare_part_specification.HeaderText = "备件规格";
            this.spare_part_specification.Name = "spare_part_specification";
            // 
            // spare_part_count
            // 
            this.spare_part_count.DataPropertyName = "spare_part_count";
            this.spare_part_count.HeaderText = "备件数量";
            this.spare_part_count.Name = "spare_part_count";
            // 
            // FormFaultInfoStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbServiceStyle);
            this.Controls.Add(this.cmbResponsibleUserName);
            this.Controls.Add(this.cmbUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormFaultInfoStatistics";
            this.ShowIcon = false;
            this.Text = "故障信息统计";
            this.Load += new System.EventHandler(this.FormFaultInfoStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbServiceStyle;
        private System.Windows.Forms.ComboBox cmbResponsibleUserName;
        private System.Windows.Forms.ComboBox cmbUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equip_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn equip_version;
        private System.Windows.Forms.DataGridViewTextBoxColumn falut_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintenance_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn spare_part_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn spare_part_version;
        private System.Windows.Forms.DataGridViewTextBoxColumn spare_part_specification;
        private System.Windows.Forms.DataGridViewTextBoxColumn spare_part_count;
    }
}