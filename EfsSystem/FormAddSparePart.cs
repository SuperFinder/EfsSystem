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
    public partial class FormAddSparePart : Form
    {
        string sparePartId = String.Empty;
        SparePartDao sparePartDao = new SparePartDao();
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
            SparePart sparePart = sparePartDao.getSparePart(sparePartId);
            textBoxSparePartName.Text = sparePart.sparePartName;
            textBoxSparePartVersion.Text = sparePart.sparePartVersion;
            textBoxSparePartSpecification.Text = sparePart.sparePartSpecification;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sparePartDao.addOrUpdateSparePart(sparePartId,textBoxSparePartName.Text,textBoxSparePartVersion.Text,textBoxSparePartSpecification.Text);
            if (sparePartId == String.Empty)
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
