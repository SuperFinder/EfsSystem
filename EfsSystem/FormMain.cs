using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EfsSystem.Dao;
using EfsSystem.Entity;

namespace EfsSystem
{
    public partial class FormMain : Form
    {
        public List<CustomerInfo> customerInfos = new List<CustomerInfo>();
        public List<UserInfo> userInfos = new List<UserInfo>();
        public List<Equip> equips = new List<Equip>();
        public List<SparePart> spareParts = new List<SparePart>();
        public List<FalutInfo> falutInfos = new List<FalutInfo>();
        public List<LeaveOverInfo> leaveOverInfos = new List<LeaveOverInfo>();

        readonly CustomerInfoDao customerInfoDao = new CustomerInfoDao();
        readonly EquipDao equipDao = new EquipDao();
        FalutInfoDao falutInfoDao = new FalutInfoDao();
        LeaveOverInfoDao leaveOverInfoDao = new LeaveOverInfoDao();
        ServiceInfoDao serviceInfoDao = new ServiceInfoDao();
        readonly SparePartDao sparePartDao = new SparePartDao();
        readonly UserDao userDao = new UserDao();
        public FormMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            customerInfos = customerInfoDao.getAllCustomerInfo();
            userInfos = userDao.getAllUserInfo();
            equips = equipDao.getAllEquip();
            spareParts = sparePartDao.getAllSparePart();
            foreach (CustomerInfo customerInfo in customerInfos)
            {
                cmbUnitName.AutoCompleteCustomSource.Add(customerInfo.unitName);
                cmbUnitName.Items.Add(customerInfo.unitName);
            }
            foreach (UserInfo userInfo in userInfos)
            {
                cmbResponsibleUserName.Items.Add(userInfo.userName);
            }
            cmbSatisfiedQuality.SelectedIndex = 0;
            cmbSatisfiedService.SelectedIndex = 0;
            cmbSatisfiedDeliver.SelectedIndex = 0;
            cmbSatisfiedPrice.SelectedIndex = 0;
            cmbServiceStyle.SelectedIndex = 0;
        }
        /// <summary>
        /// 客户信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCustomerInfo().ShowDialog();
            customerInfos.Clear();
            customerInfos = customerInfoDao.getAllCustomerInfo();
            cmbUnitName.Items.Clear();
            foreach (CustomerInfo customerInfo in customerInfos)
            {
                cmbUnitName.Items.Add(customerInfo.unitName);
                cmbUnitName.AutoCompleteCustomSource.Add(customerInfo.unitName);
            }
        }

        /// <summary>
        /// 内部人员信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUserInfo().ShowDialog();
            userInfos.Clear();
            userInfos = userDao.getAllUserInfo();
            cmbResponsibleUserName.Items.Clear();
            foreach (UserInfo userInfo in userInfos)
            {
                cmbResponsibleUserName.Items.Add(userInfo.userName);
            }
        }

        /// <summary>
        /// 装备信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equipsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEquipsInfo().ShowDialog();
            /*equips.Clear();
            equips = equipDao.getAllEquip();
            foreach (Equip equip in equips)
            {
                
            }*/
        }

        /// <summary>
        /// 备件信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sparePartsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSparePartInfo().ShowDialog();
        }

        /// <summary>
        /// 服务信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceInfoSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormServiceInfoSearch().ShowDialog();
        }

        /// <summary>
        /// 服务信息统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serviceInfoStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormServiceInfoStatistics().ShowDialog();
        }

        /// <summary>
        /// 故障信息统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void faultInfoStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFaultInfoStatistics().ShowDialog();
        }

        /// <summary>
        /// 遗留问题统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leaveOverInfoStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormLeaveOverInfoStatistics().ShowDialog();
        }

        private void cmbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = customerInfoDao.getCustomerInfoByUnitName(cmbUnitName.Text);
            textBoxResponsibleCustomerName.Text = customerInfo.responsibleUserName;
            textBoxAddress.Text = customerInfo.address;
            textBoxResponsibleCustomerTel.Text = customerInfo.tel;
            textBoxResponsibleCustomerFax.Text = customerInfo.fax;
        }

        private void cmbUnitName_TextChanged(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = customerInfoDao.getCustomerInfoByUnitName(cmbUnitName.Text);
            textBoxResponsibleCustomerName.Text = customerInfo.responsibleUserName;
            textBoxAddress.Text = customerInfo.address;
            textBoxResponsibleCustomerTel.Text = customerInfo.tel;
            textBoxResponsibleCustomerFax.Text = customerInfo.fax;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否删除？","提示",MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnAddFaultOrLeaveOverInfo_Click(object sender, EventArgs e)
        {
            FormAddFaultOrLeaveOverInfo formAddFaultOrLeaveOverInfo = new FormAddFaultOrLeaveOverInfo();
            formAddFaultOrLeaveOverInfo.ShowDialog();
            leaveOverInfos = formAddFaultOrLeaveOverInfo.getLeaveOverInfos();
            falutInfos = formAddFaultOrLeaveOverInfo.getFalutInfos();
            foreach (FalutInfo falutInfo in falutInfos)
            {
                listBox1.Items.Add(falutInfo.falutInfo);
            }
            foreach (LeaveOverInfo leaveOverInfo in leaveOverInfos)
            {
                listBox1.Items.Add(leaveOverInfo.falutInfo);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 输入框验证

            if (textBoxReceiverName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入接收人姓名", "提示", MessageBoxButtons.OK);
                textBoxReceiverName.Focus();
                return;
            }
            if (richTextBoxBrief.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入信息简要", "提示", MessageBoxButtons.OK);
                richTextBoxBrief.Focus();
                return;
            }
            if (textBoxWorkOrderNumber.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入工作令号", "提示", MessageBoxButtons.OK);
                textBoxWorkOrderNumber.Focus();
                return;
            }
            if (cmbUnitName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入单位", "提示", MessageBoxButtons.OK);
                cmbUnitName.Focus();
                return;
            }
            if (textBoxResponsibleCustomerName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入客户负责人", "提示", MessageBoxButtons.OK);
                textBoxResponsibleCustomerName.Focus();
                return;
            }
            if (textBoxAddress.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入通信地址", "提示", MessageBoxButtons.OK);
                textBoxAddress.Focus();
                return;
            }
            if (textBoxResponsibleCustomerTel.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入电话", "提示", MessageBoxButtons.OK);
                textBoxResponsibleCustomerTel.Focus();
                return;
            }
            if (textBoxResponsibleCustomerFax.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入传真", "提示", MessageBoxButtons.OK);
                textBoxResponsibleCustomerFax.Focus();
                return;
            }
            if (cmbResponsibleUserName.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入带队人", "提示", MessageBoxButtons.OK);
                cmbResponsibleUserName.Focus();
                return;
            }
            if (textBoxDayCount.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入天数", "提示", MessageBoxButtons.OK);
                textBoxDayCount.Focus();
                return;
            }
            if (textBoxUserNames.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入人员", "提示", MessageBoxButtons.OK);
                textBoxUserNames.Focus();
                return;
            }
            if (textBoxUserCount.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入人数", "提示", MessageBoxButtons.OK);
                textBoxUserCount.Focus();
                return;
            }
            if (textBoxEquipsCount.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入装备数量", "提示", MessageBoxButtons.OK);
                textBoxEquipsCount.Focus();
                return;
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请添加故障信息", "提示", MessageBoxButtons.OK);
                listBox1.Focus();
                return;
            }
            if (textBoxReturnMoney.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入回款", "提示", MessageBoxButtons.OK);
                textBoxReturnMoney.Focus();
                return;
            }
            if (textBoxExplain.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入说明", "提示", MessageBoxButtons.OK);
                textBoxExplain.Focus();
                return;
            }
            if (textBoxReturnMoney.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入装备数量", "提示", MessageBoxButtons.OK);
                textBoxReturnMoney.Focus();
                return;
            }
            if (richTextBoxSuggestAppearance.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入建议", "提示", MessageBoxButtons.OK);
                richTextBoxSuggestAppearance.Focus();
                return;
            }
            if (richTextBoxSuggestAttitude.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入建议", "提示", MessageBoxButtons.OK);
                richTextBoxSuggestAttitude.Focus();
                return;
            }
            if (richTextBoxSuggestPrice.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入建议", "提示", MessageBoxButtons.OK);
                richTextBoxSuggestPrice.Focus();
                return;
            }

            #endregion

            if (serviceInfoDao.getServiceInfoByOrderNumber(textBoxWorkOrderNumber.Text) != null)
            {
                MessageBox.Show("工作令号" + textBoxWorkOrderNumber.Text + "已存在，无法重新添加");
                return;
            }
            ServiceInfo serviceInfo = new ServiceInfo()
            {
                infoName = textBoxWorkOrderNumber.Text,
                receiverName = textBoxReceiverName.Text,
                brief = richTextBoxBrief.Text,
                basicInfo = "",
                workOderNumber = textBoxWorkOrderNumber.Text,
                unitName = cmbUnitName.Text,
                address = textBoxAddress.Text,
                responsibleCustomerName = textBoxResponsibleCustomerName.Text,
                responsibleCustomerTel = textBoxResponsibleCustomerTel.Text,
                responsibleCustomerFax = textBoxResponsibleCustomerFax.Text,
                responsibleUserName = cmbResponsibleUserName.Text,
                responsibleUserTel = "",
                startDate = dateTimePickerStartDate.Value,
                endDate = dateTimePickerEndDate.Value,
                userNames = textBoxUserNames.Text,
                userCount = textBoxUserCount.Text,
                serviceStyle = cmbServiceStyle.Text,
                equipsCount = textBoxEquipsCount.Text,
                faultInfo = "",
                returnMoney = textBoxReturnMoney.Text,
                explain = textBoxExplain.Text,
                satisfiedQuality = cmbSatisfiedQuality.Text,
                satisfiedService = cmbSatisfiedService.Text,
                satisfiedDeliver = cmbSatisfiedDeliver.Text,
                satisfiedPrice = cmbSatisfiedPrice.Text,
                suggestAppearance = richTextBoxSuggestAppearance.Text,
                suggestAttitude = richTextBoxSuggestAttitude.Text,
                suggestPrice = richTextBoxSuggestPrice.Text
            };
            if (serviceInfoDao.getServiceInfoByOrderNumber(textBoxWorkOrderNumber.Text) == null)
            {
                serviceInfoDao.addServiceInfo(serviceInfo);
                if (falutInfos.Count > 0)
                {
                    falutInfoDao.addFaultInfo(falutInfos);
                }
                if (leaveOverInfos.Count > 0)
                {
                    leaveOverInfoDao.addLeaveOverInfo(leaveOverInfos);
                }
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("改工作令号已存在");
                return;
            }
            
            #region 清空输入信息

            textBoxWorkOrderNumber.Text = "";
            textBoxReceiverName.Text = "";
            richTextBoxBrief.Text = "";
            textBoxWorkOrderNumber.Text = "";
            cmbUnitName.Text = "";
            textBoxAddress.Text = "";
            textBoxResponsibleCustomerName.Text = "";
            textBoxResponsibleCustomerTel.Text = "";
            textBoxResponsibleCustomerFax.Text = "";
            textBoxResponsibleCustomerFax.Text = "";
            cmbResponsibleUserName.Text = "";
            cmbServiceStyle.SelectedIndex = 0;
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now.AddDays(1);
            textBoxDayCount.Text = "";
            textBoxUserNames.Text = "";
            textBoxUserCount.Text = "";
            listBox1.Items.Clear();
            textBoxEquipsCount.Text = "";
            textBoxReturnMoney.Text = "";
            textBoxExplain.Text = "";
            cmbSatisfiedQuality.SelectedIndex = 0;
            cmbSatisfiedService.SelectedIndex = 0;
            cmbSatisfiedDeliver.SelectedIndex = 0;
            cmbSatisfiedPrice.SelectedIndex = 0;
            richTextBoxSuggestAppearance.Text = "";
            richTextBoxSuggestAttitude.Text = "";
            richTextBoxSuggestPrice.Text = "";

            #endregion

            leaveOverInfos.Clear();
            falutInfos.Clear();
        }
    }
}
