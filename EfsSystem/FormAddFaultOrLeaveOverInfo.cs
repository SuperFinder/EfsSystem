using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfsSystem.Entity;

namespace EfsSystem
{
    public partial class FormAddFaultOrLeaveOverInfo : Form
    {
        List<LeaveOverInfo> leaveOverInfos = new List<LeaveOverInfo>();
        List<FalutInfo> falutInfos = new List<FalutInfo>();
        public FormAddFaultOrLeaveOverInfo()
        {
            InitializeComponent();
        }

        private void FormAddFaultOrLeaveOverInfo_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            comboBoxIsProcessed.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxEquipName.Text.Trim() != String.Empty)
            {
                MessageBox.Show("请输入装备名称");
                textBoxEquipName.Focus();
                return;
            }
            if (textBoxEquipVersion.Text.Trim() != String.Empty)
            {
                MessageBox.Show("请输入装备编号");
                textBoxEquipVersion.Focus();
                return;
            }
            if (textBoxFalutInfo.Text.Trim() != String.Empty)
            {
                MessageBox.Show("请输入故障现象");
                textBoxFalutInfo.Focus();
                return;
            }
            if (textBoxMaintenanceMode.Text.Trim() != String.Empty)
            {
                MessageBox.Show("请选择维修方式");
                textBoxMaintenanceMode.Focus();
                return;
            }
            if (textBoxSparePartName.Text.Trim() != String.Empty)
            {

            }
            if (textBoxSparePartVersion.Text.Trim() != String.Empty)
            {

            }
            if (textBoxSparePartSpecification.Text.Trim() != String.Empty)
            {

            }
            if (textBoxSparePartCount.Text.Trim() != String.Empty)
            {

            }
            if (comboBoxIsProcessed.Text == "已解决")
            {
                
            }
            else if (comboBoxIsProcessed.Text == "未解决")
            {

            }
        }
    }
}
