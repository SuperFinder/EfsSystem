namespace EfsSystem
{
    partial class FormAddCustomer
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
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblResponsibleUserName = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxUnitName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxResponsibleUserName = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxFax = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblUnitName.Location = new System.Drawing.Point(66, 33);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(80, 16);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "单位名称:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 12F);
            this.lblAddress.Location = new System.Drawing.Point(66, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 16);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "单位地址:";
            // 
            // lblResponsibleUserName
            // 
            this.lblResponsibleUserName.AutoSize = true;
            this.lblResponsibleUserName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblResponsibleUserName.Location = new System.Drawing.Point(74, 87);
            this.lblResponsibleUserName.Name = "lblResponsibleUserName";
            this.lblResponsibleUserName.Size = new System.Drawing.Size(64, 16);
            this.lblResponsibleUserName.TabIndex = 0;
            this.lblResponsibleUserName.Text = "负责人:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTel.Location = new System.Drawing.Point(82, 114);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(48, 16);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "电话:";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Font = new System.Drawing.Font("宋体", 12F);
            this.lblFax.Location = new System.Drawing.Point(82, 141);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(48, 16);
            this.lblFax.TabIndex = 0;
            this.lblFax.Text = "传真:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("宋体", 12F);
            this.lblEmail.Location = new System.Drawing.Point(82, 168);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "邮箱:";
            // 
            // textBoxUnitName
            // 
            this.textBoxUnitName.Location = new System.Drawing.Point(149, 33);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(209, 21);
            this.textBoxUnitName.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(149, 60);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(209, 21);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxResponsibleUserName
            // 
            this.textBoxResponsibleUserName.Location = new System.Drawing.Point(149, 87);
            this.textBoxResponsibleUserName.Name = "textBoxResponsibleUserName";
            this.textBoxResponsibleUserName.Size = new System.Drawing.Size(209, 21);
            this.textBoxResponsibleUserName.TabIndex = 1;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(149, 114);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(209, 21);
            this.textBoxTel.TabIndex = 1;
            // 
            // textBoxFax
            // 
            this.textBoxFax.Location = new System.Drawing.Point(149, 141);
            this.textBoxFax.Name = "textBoxFax";
            this.textBoxFax.Size = new System.Drawing.Size(209, 21);
            this.textBoxFax.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(149, 168);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(209, 21);
            this.textBoxEmail.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(125, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 266);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxFax);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxResponsibleUserName);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxUnitName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblResponsibleUserName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblUnitName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FormAddCustomer";
            this.ShowIcon = false;
            this.Text = "添加客户信息";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblResponsibleUserName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxUnitName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxResponsibleUserName;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxFax;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}