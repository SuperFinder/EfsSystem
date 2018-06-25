using EfsSystem.Entity;
using System;
using System.Data;
using System.Windows.Forms;
using EfsSystem.common;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem
{
    public partial class FormAddCustomer : Form
    {
        private string customerId = string.Empty;
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
            CustomerInfo customerInfo = new CustomerInfo {
                unitName = textBoxUnitName.Text,
                address = textBoxAddress.Text,
                responsibleUserName = textBoxResponsibleUserName.Text,
                tel = textBoxTel.Text,
                fax = textBoxFax.Text,
                email = textBoxEmail.Text
            };
            try
            {
                MySqlParameter paraUnitName = new MySqlParameter("@paraUnitName",customerInfo.unitName);
                MySqlParameter paraAddress = new MySqlParameter("@paraAddress",customerInfo.address);
                MySqlParameter paraResponsibleUserName = new MySqlParameter("@paraResponsibleUserName", customerInfo.responsibleUserName);
                MySqlParameter paraTel = new MySqlParameter("@paraTel",customerInfo.tel);
                MySqlParameter paraFax = new MySqlParameter("@paraFax",customerInfo.fax);
                MySqlParameter paraEmail = new MySqlParameter("@paraEmail",customerInfo.email);
                if (customerId != string.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId",customerId);
                    string sql = "update customer set unit_name = @paraUnitName,address = @paraAddress,responsible_user_name = @paraResponsibleUserName,tel = @paraTel,fax = @paraFax, email = @paraEmail where id = @paraId";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraUnitName, paraAddress, paraResponsibleUserName, paraTel, paraFax, paraEmail,paraId);
                    MessageBox.Show(@"修改客户成功!", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    string sql = "insert into customer(unit_name,address,responsible_user_name,tel,fax,email) values(@paraUnitName,@paraAddress,@paraResponsibleUserName,@paraTel,@paraFax,@paraEmail)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraUnitName, paraAddress, paraResponsibleUserName, paraTel, paraFax, paraEmail);
                    MessageBox.Show(@"新增客户成功!", "提示", MessageBoxButtons.OK);
                }
                Close();
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormAddCustomer),exception.ToString());
            }
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
                MySqlParameter paraId = new MySqlParameter("@paraId",customerId);
                string sql = "select unit_name,address,responsible_user_name,tel,fax,email from customer where id = @paraId";
                MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraId);
                if (mySqlDataReader.Read())
                {
                    textBoxUnitName.Text = (string)mySqlDataReader["unit_name"];
                    textBoxAddress.Text = (string) mySqlDataReader["address"];
                    textBoxResponsibleUserName.Text = (string) mySqlDataReader["responsible_user_name"];
                    textBoxTel.Text = (string) mySqlDataReader["tel"];
                    textBoxFax.Text = (string) mySqlDataReader["fax"];
                    textBoxEmail.Text = (string) mySqlDataReader["email"];
                }
                mySqlDataReader.Close();
            }
        }
    }
}
