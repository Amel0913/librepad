using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librepad_demo
{
    public partial class frmAreaTest : Form
    {
        public frmAreaTest()
        {
            InitializeComponent();
        }

        public librepad.LibrePad PAD { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGetAreaValue_Click(object sender, EventArgs e)
        {
            if (null == PAD)
                return;

            if (txtGroupID.Text.Trim().Length <= 0 || txtAreaID.Text.Trim().Length <= 0)
            {
                MessageBox.Show("分组ID 和 区域ID 不可为空!");
                return;
            }

            string[] sar = PAD.getAreaValue(txtGroupID.Text, txtAreaID.Text);
            if(null==sar)
            {
                txtValCode.Text = "";
                txtVal.Text = "取值错误";
                return;
            }

            txtVal.Text = sar[1];
            txtValCode.Text = sar[0];
        }

        private void btnSetAreaValue_Click(object sender, EventArgs e)
        {
            if (null == PAD)
                return;

            if (txtGroupID.Text.Trim().Length <= 0 || txtAreaID.Text.Trim().Length <= 0)
            {
                MessageBox.Show("分组ID 和 区域ID 不可为空!");
                return;
            }

            string sVal = txtVal.Text;
            if (sVal.Length <= 0)
                sVal = " ";

            PAD.setAreaValue(txtGroupID.Text, txtAreaID.Text, sVal,txtValCode.Text);
        }
    }
}
