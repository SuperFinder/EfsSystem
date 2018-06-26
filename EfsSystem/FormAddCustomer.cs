using EfsSystem.Entity;
using System;
using System.Data;
using System.Windows.Forms;
using EfsSystem.common;
using EfsSystem.Dao;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem
{
    public partial class FormAddCustomer : Form
    {
        private string customerId = string.Empty;
        public CustomerInfoDao customerInfoDao = new CustomerInfoDao();
        public FormAddCustomer()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAddCustomer(string id)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            customerId = id;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            customerInfoDao.addOrUpdateCustomer(customerId,textBoxUnitName.Text,textBoxAddress.Text,textBoxResponsibleUserName.Text,textBoxTel.Text,textBoxFax.Text,textBoxEmail.Text);
            if (customerId == String.Empty)
            {
                MessageBox.Show("添加成功","提示",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
            }
            Close();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != string.Empty)
            {
                CustomerInfo customerInfo = customerInfoDao.getCustomerInfo(customerId);
                textBoxUnitName.Text = customerInfo.unitName;
                textBoxAddress.Text = customerInfo.address;
                textBoxResponsibleUserName.Text = customerInfo.responsibleUserName;
                textBoxTel.Text = customerInfo.tel;
                textBoxFax.Text = customerInfo.fax;
                textBoxEmail.Text = customerInfo.email;
            }
        }
    }
}
