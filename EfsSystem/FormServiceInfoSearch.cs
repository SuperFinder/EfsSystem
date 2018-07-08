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
    public partial class FormServiceInfoSearch : Form
    {
        ServiceInfoDao serviceInfoDao = new ServiceInfoDao();
        public FormServiceInfoSearch()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormServiceInfoSearch_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceInfo serviceInfo = serviceInfoDao.getServiceInfoByOrderNumber(textBox1.Text);
            if (serviceInfo == null)
            {
                MessageBox.Show("未找到工作令号为" + textBox1.Text + "的记录");
                return;
            }
            else
            {
                textBoxReceiverName.Text = serviceInfo.receiverName;
                richTextBoxBrief.Text = serviceInfo.brief;
                textBoxWorkOrderNumber.Text = serviceInfo.workOderNumber;
                cmbUnitName.Text = serviceInfo.unitName;
                textBoxAddress.Text = serviceInfo.address;
                textBoxResponsibleCustomerName.Text = serviceInfo.responsibleCustomerName;
                textBoxResponsibleCustomerTel.Text = serviceInfo.responsibleCustomerTel;
                textBoxResponsibleCustomerFax.Text = serviceInfo.responsibleCustomerFax;
                cmbResponsibleUserName.Text = serviceInfo.responsibleUserName;
                dateTimePickerStartDate.Value = serviceInfo.startDate;
                dateTimePickerEndDate.Value = serviceInfo.endDate;
                textBoxUserNames.Text = serviceInfo.userNames;
                textBoxUserCount.Text = serviceInfo.userCount;
                cmbServiceStyle.Text = serviceInfo.serviceStyle;
                textBoxEquipsCount.Text = serviceInfo.equipsCount;
                textBoxReturnMoney.Text = serviceInfo.returnMoney;
                textBoxExplain.Text = serviceInfo.explain;
                cmbSatisfiedQuality.Text = serviceInfo.satisfiedQuality;
                cmbSatisfiedService.Text = serviceInfo.satisfiedService;
                cmbSatisfiedDeliver.Text = serviceInfo.satisfiedDeliver;
                cmbSatisfiedPrice.Text = serviceInfo.satisfiedPrice;
                richTextBoxSuggestAppearance.Text = serviceInfo.suggestAppearance;
                richTextBoxSuggestAttitude.Text = serviceInfo.suggestAttitude;
                richTextBoxSuggestPrice.Text = serviceInfo.suggestPrice;
            }
        }
    }
}
