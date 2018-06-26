using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EfsSystem.common;
using EfsSystem.Dao;
using EfsSystem.Entity;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem
{
    public partial class FormAddUser : Form
    {
        public string userId = string.Empty;
        UserDao userdao = new UserDao();
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
            UserInfo userInfo = userdao.getUserInfo(userId);
            textBoxUserName.Text = userInfo.userName;
            textBoxDepartment.Text = userInfo.department;
            textBoxPostion.Text = userInfo.position;
            textBoxTel.Text = userInfo.tel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userdao.addOrUpdateUser(userId,textBoxUserName.Text,textBoxDepartment.Text,textBoxPostion.Text,textBoxTel.Text);
            if (userId == String.Empty)
            {
                MessageBox.Show("添加成功","提示",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
