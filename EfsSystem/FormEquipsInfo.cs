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
    public partial class FormEquipsInfo : Form
    {
        public FormEquipsInfo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormEquipsInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select id,name,number,version,specification, '修改' as modify from equips";
                DataSet dataSet = MySqlHelper.GetDataSet(MySqlHelper.conn, CommandType.Text, sql, null);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormEquipsInfo),exception.ToString());
            }
        }

        private void addEquipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddEquip().ShowDialog();
            FormEquipsInfo_Load(null,null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.ColumnCount - 1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                FormAddEquip formAddEquip = new FormAddEquip(id);
                formAddEquip.Text = "修改装备信息";
                formAddEquip.ShowDialog();
                FormEquipsInfo_Load(null,null);
            }
        }
    }
}
