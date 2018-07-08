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
    public partial class FormFaultInfoStatistics : Form
    {
        public List<CustomerInfo> customerInfos = new List<CustomerInfo>();
        public List<UserInfo> userInfos = new List<UserInfo>();
        readonly CustomerInfoDao customerInfoDao = new CustomerInfoDao();
        readonly UserDao userDao = new UserDao();
        FalutInfoDao falutInfoDao = new FalutInfoDao();
        public FormFaultInfoStatistics()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormFaultInfoStatistics_Load(object sender, EventArgs e)
        {
            cmbUnitName.Items.Add("全部");
            cmbServiceStyle.Items.Add("全部");
            cmbResponsibleUserName.Items.Add("全部");
            customerInfos = customerInfoDao.getAllCustomerInfo();
            userInfos = userDao.getAllUserInfo();
            foreach (CustomerInfo customerInfo in customerInfos)
            {
                cmbUnitName.AutoCompleteCustomSource.Add(customerInfo.unitName);
                cmbUnitName.Items.Add(customerInfo.unitName);
            }
            foreach (UserInfo userInfo in userInfos)
            {
                cmbResponsibleUserName.Items.Add(userInfo.userName);
            }
            dataGridView1.DataSource = falutInfoDao.getFaultInfos(dateTimePicker1.Value, dateTimePicker2.Value, cmbUnitName.Text, cmbResponsibleUserName.Text, cmbServiceStyle.Text).Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = falutInfoDao.getFaultInfos(dateTimePicker1.Value, dateTimePicker2.Value, cmbUnitName.Text, cmbResponsibleUserName.Text, cmbServiceStyle.Text).Tables[0];
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = falutInfoDao.getFaultInfos(dateTimePicker1.Value, dateTimePicker2.Value, cmbUnitName.Text, cmbResponsibleUserName.Text, cmbServiceStyle.Text).Tables[0];
        }

        private void cmbUnitName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = falutInfoDao.getFaultInfos(dateTimePicker1.Value, dateTimePicker2.Value, cmbUnitName.Text, cmbResponsibleUserName.Text, cmbServiceStyle.Text).Tables[0];
        }

        private void cmbResponsibleUserName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = falutInfoDao.getFaultInfos(dateTimePicker1.Value, dateTimePicker2.Value, cmbUnitName.Text, cmbResponsibleUserName.Text, cmbServiceStyle.Text).Tables[0];
        }

        private void cmbServiceStyle_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = falutInfoDao.getFaultInfos(dateTimePicker1.Value, dateTimePicker2.Value, cmbUnitName.Text, cmbResponsibleUserName.Text, cmbServiceStyle.Text).Tables[0];
        }
    }
}
