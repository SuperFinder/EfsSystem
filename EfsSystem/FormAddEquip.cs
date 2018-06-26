using System;
using System.Data;
using System.Windows.Forms;
using EfsSystem.common;
using EfsSystem.Dao;
using EfsSystem.Entity;
using MySql.Data.MySqlClient;
using MySqlHelper = EfsSystem.common.MySqlHelper;

namespace EfsSystem
{
    public partial class FormAddEquip : Form
    {
        private string equipId = string.Empty;
        public EquipDao equipDao = new EquipDao();
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
            equipDao.addOrUpdateEquip(equipId,textBoxName.Text,textBoxNumber.Text,textBoxVersion.Text,textBoxSpecification.Text);
            if (equipId == string.Empty)
            {
                MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
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

        private void FormAddEquip_Load(object sender, EventArgs e)
        {
            Equip equip = equipDao.getEquip(equipId);
            textBoxName.Text = equip.name;
            textBoxNumber.Text = equip.number;
            textBoxVersion.Text = equip.version;
            textBoxSpecification.Text = equip.specification;

        }
    }
}
