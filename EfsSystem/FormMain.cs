using System;
using System.Windows.Forms;

namespace EfsSystem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 客户信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCustomerInfo().ShowDialog();
        }

        /// <summary>
        /// 内部人员信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUserInfo().ShowDialog();
        }

        /// <summary>
        /// 装备信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equipsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEquipsInfo().ShowDialog();
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
