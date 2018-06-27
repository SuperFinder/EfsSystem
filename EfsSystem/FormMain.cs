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
    }
}
