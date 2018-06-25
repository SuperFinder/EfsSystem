using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfsSystem.common;
using EfsSystem.Entity;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem
{
    public partial class FormAddUser : Form
    {
        public string userId = string.Empty;
        public FormAddUser()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public FormAddUser(string id)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            userId = id;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            try
            {
                if (userId != string.Empty)
                {
                    MySqlParameter paraUserId = new MySqlParameter("paraUserId", userId);
                    string sql = "select user_name,department,position,tel from user where id = @paraUserId";
                    MySqlDataReader mySqlDataReader = MySqlHelper.ExecuteReader(MySqlHelper.conn, CommandType.Text, sql, paraUserId);
                    if (mySqlDataReader.Read())
                    {
                        textBoxUserName.Text = (string)mySqlDataReader["user_name"];
                        textBoxDepartment.Text = (string)mySqlDataReader["department"];
                        textBoxPostion.Text = (string)mySqlDataReader["position"];
                        textBoxTel.Text = (string)mySqlDataReader["tel"];
                    }
                    mySqlDataReader.Close();
                }
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormAddUser), exception.ToString());
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameter paraUserName = new MySqlParameter("@paraUserName", textBoxUserName.Text);
                MySqlParameter paraDepartment = new MySqlParameter("@paraDepartment", textBoxDepartment.Text);
                MySqlParameter paraPostion = new MySqlParameter("@paraPosition", textBoxPostion.Text);
                MySqlParameter paraTel = new MySqlParameter("@paraTel", textBoxTel.Text);
                string sql;
                if (userId != string.Empty)
                {
                    MySqlParameter paraId = new MySqlParameter("@paraId", userId);
                    sql = "update user set user_name = @paraUserName, department = @paraDepartment, position = @paraPosition, tel = @paratel where id = @paraId";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraUserName, paraDepartment, paraPostion, paraTel,paraId);
                    MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    sql = "insert into user(user_name,department,position,tel) values(@paraUserName,@paraDepartment,@paraPosition,@paraTel)";
                    MySqlHelper.ExecuteNonQuery(MySqlHelper.conn, CommandType.Text, sql, paraUserName, paraDepartment, paraPostion, paraTel);
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                Close();
            }
            catch (Exception exception)
            {
                LogHelper.WriteLog(typeof(FormAddUser),exception.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
