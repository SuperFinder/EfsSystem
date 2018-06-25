using System;
using System.Data;
using System.Windows.Forms;
using EfsSystem.common;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem
{
    public partial class FormAddEquip : Form
    {
        private string equipId = string.Empty;
        public FormAddEquip()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAddEquip(string id)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            equipId = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameter paraName = new MySqlParameter("@paraName", textBoxName.Text);
                MySqlParameter paraNumber = new MySqlParameter("@paraNumber", textBoxNumber.Text);
                MySqlParameter paraVersion = new MySqlParameter("@paraVersion", textBoxVersion.Text);
                MySqlParameter paraSpecification = new MySqlParameter("@paraSpecification", textBoxSpecification.Text);
                if (equipId != String.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId", equipId);
                    string sql = "update equips set name = @paraName, number = @paraNumber, version = @paraVersion, specification = @paraSpecification where id = @paraId";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraName, paraNumber, paraVersion, paraSpecification, paraId);
                    MessageBox.Show("修改成功");
                }
                else
                {
                    string sql = "insert into equips(name,number,version,specification) values(@paraName,@paraNumber,@paraVersion,@paraSpecification)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraName, paraNumber, paraVersion, paraSpecification);
                    MessageBox.Show("添加成功");
                }
                Close();
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(typeof(FormAddEquip), ex.ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAddEquip_Load(object sender, EventArgs e)
        {
            if (equipId != String.Empty)
            {
                MySqlParameter paraId = new MySqlParameter("@paraId", equipId);
                string sql = "select name,number,version,specification from equips where id = @paraId";
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraId);
                if (mySqlDataReader.Read())
                {
                    textBoxName.Text = (string)mySqlDataReader["name"];
                    textBoxNumber.Text = (string)mySqlDataReader["number"];
                    textBoxVersion.Text = (string)mySqlDataReader["version"];
                    textBoxSpecification.Text = (string)mySqlDataReader["specification"];
                }
                mySqlDataReader.Close();
            }
        }
    }
}
