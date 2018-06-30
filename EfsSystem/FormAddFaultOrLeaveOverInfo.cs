using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfsSystem.Dao;
using EfsSystem.Entity;

namespace EfsSystem
{
    public partial class FormAddFaultOrLeaveOverInfo : Form
    {
        List<LeaveOverInfo> leaveOverInfos = new List<LeaveOverInfo>();
        List<FalutInfo> falutInfos = new List<FalutInfo>();
        FalutInfoDao falutInfoDao = new FalutInfoDao();
        LeaveOverInfoDao leaveOverInfoDao = new LeaveOverInfoDao();
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
            if (textBoxEquipName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入装备名称");
                textBoxEquipName.Focus();
                return;
            }
            if (textBoxEquipVersion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入装备编号");
                textBoxEquipVersion.Focus();
                return;
            }
            if (textBoxFalutInfo.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入故障现象");
                textBoxFalutInfo.Focus();
                return;
            }
            if (textBoxMaintenanceMode.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请选择维修方式");
                textBoxMaintenanceMode.Focus();
                return;
            }
            if (comboBoxIsProcessed.Text == "已解决" && textBoxSparePartName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入备件名称");
                textBoxSparePartName.Focus();
                return;
            }
            if (comboBoxIsProcessed.Text == "已解决" && textBoxSparePartVersion.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入备件型号");
                textBoxSparePartVersion.Focus();
                return;
            }
            if (comboBoxIsProcessed.Text == "已解决" && textBoxSparePartSpecification.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入备件规格");
                textBoxSparePartSpecification.Focus();
                return;
            }
            if (comboBoxIsProcessed.Text == "已解决" && textBoxSparePartCount.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入备件数量");
                textBoxSparePartCount.Focus();
                return;
            }
            if (comboBoxIsProcessed.Text == "已解决")
            {
                FalutInfo falutInfo = new FalutInfo()
                {
                    equipName = textBoxEquipName.Text,
                    equipVersion = textBoxEquipVersion.Text,
                    falutInfo = textBoxFalutInfo.Text,
                    maintenance = textBoxMaintenanceMode.Text,
                    sparePartName = textBoxSparePartName.Text,
                    sparePartVersion = textBoxSparePartVersion.Text,
                    sparePartSpecification = textBoxSparePartSpecification.Text,
                    sparePartCount = Convert.ToInt32(textBoxSparePartCount.Text)
                };
                falutInfos.Add(falutInfo);
                DialogResult dialogResult =  MessageBox.Show("添加成功，是否继续添加","提示",MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    textBoxSparePartName.Text = string.Empty;
                    textBoxSparePartVersion.Text = String.Empty;
                    textBoxSparePartSpecification.Text = String.Empty;
                    textBoxSparePartCount.Text = string.Empty;
                }
                else
                {
                    Close();
                }
            }
            else if (comboBoxIsProcessed.Text == "未解决")
            {
                LeaveOverInfo leaveOverInfo = new LeaveOverInfo()
                {
                    equipName = textBoxEquipName.Text,
                    equipVersion = textBoxEquipVersion.Text,
                    falutInfo = textBoxFalutInfo.Text,
                    maintenance = textBoxMaintenanceMode.Text,
                    sparePartName = textBoxSparePartName.Text,
                    sparePartVersion = textBoxSparePartVersion.Text,
                    sparePartSpecification = textBoxSparePartSpecification.Text,
                    sparePartCount = Convert.ToInt32(textBoxSparePartCount.Text)
                };
                leaveOverInfos.Add(leaveOverInfo);
                DialogResult dialogResult = MessageBox.Show("添加成功，是否继续添加", "提示", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    textBoxSparePartName.Text = string.Empty;
                    textBoxSparePartVersion.Text = String.Empty;
                    textBoxSparePartSpecification.Text = String.Empty;
                    textBoxSparePartCount.Text = "0";
                }
                else
                {
                    Close();
                }
            }
        }

        public List<FalutInfo> getFalutInfos()
        {
            return falutInfos;
        }

        public List<LeaveOverInfo> getLeaveOverInfos()
        {
            return leaveOverInfos;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
