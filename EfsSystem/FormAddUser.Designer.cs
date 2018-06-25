namespace EfsSystem
{
    partial class FormAddUser
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPostion = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxPostion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblUserName.Location = new System.Drawing.Point(72, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(48, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "姓名:";
            // 
            // lblPostion
            // 
            this.lblPostion.AutoSize = true;
            this.lblPostion.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPostion.Location = new System.Drawing.Point(72, 62);
            this.lblPostion.Name = "lblPostion";
            this.lblPostion.Size = new System.Drawing.Size(48, 16);
            this.lblPostion.TabIndex = 0;
            this.lblPostion.Text = "部门:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTel.Location = new System.Drawing.Point(72, 116);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(48, 16);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "电话:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(133, 35);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(143, 21);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(133, 62);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(143, 21);
            this.textBoxDepartment.TabIndex = 1;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(133, 116);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(143, 21);
            this.textBoxTel.TabIndex = 1;
            // 
            // textBoxPostion
            // 
            this.textBoxPostion.Location = new System.Drawing.Point(133, 89);
            this.textBoxPostion.Name = "textBoxPostion";
            this.textBoxPostion.Size = new System.Drawing.Size(143, 21);
            this.textBoxPostion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(71, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "职位:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(201, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxPostion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblPostion);
            this.Controls.Add(this.lblUserName);
            this.Name = "FormAddUser";
            this.ShowIcon = false;
            this.Text = "添加员工信息";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPostion;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxPostion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}