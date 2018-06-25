namespace EfsSystem
{
    partial class FormAddSparePart
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSparePartName = new System.Windows.Forms.TextBox();
            this.textBoxSparePartVersion = new System.Windows.Forms.TextBox();
            this.textBoxSparePartSpecification = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "备件名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "型号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(47, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "规格:";
            // 
            // textBoxSparePartName
            // 
            this.textBoxSparePartName.Location = new System.Drawing.Point(116, 43);
            this.textBoxSparePartName.Name = "textBoxSparePartName";
            this.textBoxSparePartName.Size = new System.Drawing.Size(174, 21);
            this.textBoxSparePartName.TabIndex = 1;
            // 
            // textBoxSparePartVersion
            // 
            this.textBoxSparePartVersion.Location = new System.Drawing.Point(116, 77);
            this.textBoxSparePartVersion.Name = "textBoxSparePartVersion";
            this.textBoxSparePartVersion.Size = new System.Drawing.Size(174, 21);
            this.textBoxSparePartVersion.TabIndex = 1;
            // 
            // textBoxSparePartSpecification
            // 
            this.textBoxSparePartSpecification.Location = new System.Drawing.Point(116, 113);
            this.textBoxSparePartSpecification.Name = "textBoxSparePartSpecification";
            this.textBoxSparePartSpecification.Size = new System.Drawing.Size(174, 21);
            this.textBoxSparePartSpecification.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(209, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddSparePart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 219);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxSparePartSpecification);
            this.Controls.Add(this.textBoxSparePartVersion);
            this.Controls.Add(this.textBoxSparePartName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddSparePart";
            this.ShowIcon = false;
            this.Text = "添加备件";
            this.Load += new System.EventHandler(this.FormAddSparePart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSparePartName;
        private System.Windows.Forms.TextBox textBoxSparePartVersion;
        private System.Windows.Forms.TextBox textBoxSparePartSpecification;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}