using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfsSystem.common;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem
{
    public partial class FormAddSparePart : Form
    {
        string sparePartId = String.Empty;
        public FormAddSparePart()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAddSparePart(string id)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            sparePartId = id;
        }

        private void FormAddSparePart_Load(object sender, EventArgs e)
        {
            try
            {
                if (sparePartId != String.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId",sparePartId);
                    string sql = "select spare_part_name,spare_part_version,spare_part_specification from spare_parts where id = @paraId";
                    MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraId);
                    if (mySqlDataReader.Read())
                    {
                        textBoxSparePartName.Text = (string)mySqlDataReader["spare_part_name"];
                        textBoxSparePartVersion.Text = (string)mySqlDataReader["spare_part_version"];
                        textBoxSparePartSpecification.Text = (string)mySqlDataReader["spare_part_specification"];
                    }
                    mySqlDataReader.Close();
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormAddSparePart),ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameter paraPartName = new MySqlParameter("@paraPartName",textBoxSparePartName.Text);
                MySqlParameter paraPartVersion = new MySqlParameter("@paraPartVesion",textBoxSparePartVersion.Text);
                MySqlParameter paraPartSpecification = new MySqlParameter("@paraPartSpecification", textBoxSparePartSpecification.Text);
                if (sparePartId != string.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId", sparePartId);
                    string sql = "update spare_parts set spare_part_name = @paraPartName, spare_part_version = @paraPartVesion, spare_part_specification = @paraPartSpecification where id = @paraId";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraPartName, paraPartVersion, paraPartSpecification, paraId);
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = "insert into spare_parts(spare_part_name,spare_part_version,spare_part_specification) values(@paraPartName,@paraPartVesion,@paraPartSpecification)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraPartName, paraPartVersion, paraPartSpecification);
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                Close();

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormAddSparePart),ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
