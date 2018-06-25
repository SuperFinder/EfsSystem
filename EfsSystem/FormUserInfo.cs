using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfsSystem.common;

namespace EfsSystem
{
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select id,user_name,department,position,tel,'修改' as modify from user";
                DataSet dataSet = MySqlHelper.GetDataSet(MySqlHelper.conn, CommandType.Text, sql, null);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormUserInfo),exception.ToString());
            }
        }

        /// <summary>
        /// 添加人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddUser().ShowDialog();
            FormUserInfo_Load(null,null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.ColumnCount - 1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                FormAddUser formAddUser = new FormAddUser(id);
                formAddUser.Text = "修改员工信息";
                formAddUser.ShowDialog();
                FormUserInfo_Load(null,null);
            }
        }
    }
}
