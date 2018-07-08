namespace EfsSystem
{
    partial class FormServiceInfoStatistics
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUnitName = new System.Windows.Forms.ComboBox();
            this.cmbResponsibleUserName = new System.Windows.Forms.ComboBox();
            this.cmbServiceStyle = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.info_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiver_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_order_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible_customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible_customer_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible_user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 21);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(173, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(126, 21);
            this.dateTimePicker2.TabIndex = 1;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "至";
            // 
            // cmbUnitName
            // 
            this.cmbUnitName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUnitName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbUnitName.FormattingEnabled = true;
            this.cmbUnitName.Location = new System.Drawing.Point(327, 12);
            this.cmbUnitName.Name = "cmbUnitName";
            this.cmbUnitName.Size = new System.Drawing.Size(220, 20);
            this.cmbUnitName.TabIndex = 3;
            this.cmbUnitName.Text = "请选择单位";
            this.cmbUnitName.SelectedIndexChanged += new System.EventHandler(this.cmbUnitName_SelectedIndexChanged);
            // 
            // cmbResponsibleUserName
            // 
            this.cmbResponsibleUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResponsibleUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbResponsibleUserName.FormattingEnabled = true;
            this.cmbResponsibleUserName.Location = new System.Drawing.Point(553, 12);
            this.cmbResponsibleUserName.Name = "cmbResponsibleUserName";
            this.cmbResponsibleUserName.Size = new System.Drawing.Size(220, 20);
            this.cmbResponsibleUserName.TabIndex = 3;
            this.cmbResponsibleUserName.Text = "请选择带队人";
            this.cmbResponsibleUserName.SelectedIndexChanged += new System.EventHandler(this.cmbResponsibleUserName_SelectedIndexChanged);
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
            this.cmbServiceStyle.TabIndex = 3;
            this.cmbServiceStyle.Text = "请选择服务类型";
            this.cmbServiceStyle.SelectedIndexChanged += new System.EventHandler(this.cmbServiceStyle_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.info_name,
            this.receiver_name,
            this.work_order_number,
            this.unit_name,
            this.responsible_customer_name,
            this.responsible_customer_tel,
            this.responsible_user_name,
            this.start_date,
            this.end_date,
            this.user_names,
            this.service_style,
            this.return_money});
            this.dataGridView1.Location = new System.Drawing.Point(1, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1346, 649);
            this.dataGridView1.TabIndex = 4;
            // 
            // info_name
            // 
            this.info_name.DataPropertyName = "info_name";
            this.info_name.HeaderText = "工单名称";
            this.info_name.Name = "info_name";
            // 
            // receiver_name
            // 
            this.receiver_name.DataPropertyName = "receiver_name";
            this.receiver_name.HeaderText = "信息接收人";
            this.receiver_name.Name = "receiver_name";
            // 
            // work_order_number
            // 
            this.work_order_number.DataPropertyName = "work_order_number";
            this.work_order_number.HeaderText = "工作令号";
            this.work_order_number.Name = "work_order_number";
            // 
            // unit_name
            // 
            this.unit_name.DataPropertyName = "unit_name";
            this.unit_name.HeaderText = "单位名称";
            this.unit_name.Name = "unit_name";
            // 
            // responsible_customer_name
            // 
            this.responsible_customer_name.DataPropertyName = "responsible_customer_name";
            this.responsible_customer_name.HeaderText = "客户负责人";
            this.responsible_customer_name.Name = "responsible_customer_name";
            // 
            // responsible_customer_tel
            // 
            this.responsible_customer_tel.DataPropertyName = "responsible_customer_tel";
            this.responsible_customer_tel.HeaderText = "客户负责人电话";
            this.responsible_customer_tel.Name = "responsible_customer_tel";
            // 
            // responsible_user_name
            // 
            this.responsible_user_name.DataPropertyName = "responsible_user_name";
            this.responsible_user_name.HeaderText = "带队人";
            this.responsible_user_name.Name = "responsible_user_name";
            // 
            // start_date
            // 
            this.start_date.DataPropertyName = "start_date";
            this.start_date.HeaderText = "开始日期";
            this.start_date.Name = "start_date";
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "结束日期";
            this.end_date.Name = "end_date";
            // 
            // user_names
            // 
            this.user_names.DataPropertyName = "user_names";
            this.user_names.HeaderText = "人员";
            this.user_names.Name = "user_names";
            // 
            // service_style
            // 
            this.service_style.DataPropertyName = "service_style";
            this.service_style.HeaderText = "服务类型";
            this.service_style.Name = "service_style";
            // 
            // return_money
            // 
            this.return_money.DataPropertyName = "return_money";
            this.return_money.HeaderText = "回款";
            this.return_money.Name = "return_money";
            // 
            // FormServiceInfoStatistics
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
            this.Name = "FormServiceInfoStatistics";
            this.ShowIcon = false;
            this.Text = "服务信息统计";
            this.Load += new System.EventHandler(this.FormServiceInfoStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUnitName;
        private System.Windows.Forms.ComboBox cmbResponsibleUserName;
        private System.Windows.Forms.ComboBox cmbServiceStyle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn info_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiver_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_order_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible_customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible_customer_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible_user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_names;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_style;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_money;
    }
}