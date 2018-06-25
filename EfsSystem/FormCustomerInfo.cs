using System;
using System.Data;
using System.Windows.Forms;
using EfsSystem.common;
namespace EfsSystem
{
    public partial class FormCustomerInfo : Form
    {
        public FormCustomerInfo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormCustomerInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select id,unit_name,address,responsible_user_name,tel,fax,email,'修改' as modify from customer";
                DataSet dataSet = MySqlHelper.GetDataSet(MySqlHelper.conn, CommandType.Text, sql, null);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormCustomerInfo),exception.ToString());
            }
        }

        /// <summary>
        /// 新增客户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddCustomer().ShowDialog();
            FormCustomerInfo_Load(null,null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.ColumnCount - 1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                FormAddCustomer formAddCustomer = new FormAddCustomer(id);
                formAddCustomer.Text = "修改客户信息";
                formAddCustomer.ShowDialog();
                FormCustomerInfo_Load(null, null);
            }
        }
    }
}
