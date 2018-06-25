using System;
using System.Data;
using System.Windows.Forms;
using EfsSystem.common;

namespace EfsSystem
{
    public partial class FormSparePartInfo : Form
    {
        public FormSparePartInfo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FormSparePartInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "select id,spare_part_name,spare_part_version,spare_part_specification, '修改' as modify from spare_parts";
                DataSet dataSet = MySqlHelper.GetDataSet(MySqlHelper.conn, CommandType.Text, sql, null);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormSparePartInfo),ex.ToString());
            }
        }

        private void AddSparePartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAddSparePart().ShowDialog();
            FormSparePartInfo_Load(null,null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.ColumnCount - 1)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                FormAddSparePart formAddSparePart = new FormAddSparePart(id);
                formAddSparePart.Text = "修改备件信息";
                formAddSparePart.ShowDialog();
                FormSparePartInfo_Load(null,null);
            }
        }
    }
}
