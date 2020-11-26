using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace librepad_demo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private  void Pad_OnShowMessage(string smsg, string stitle = "")
        {
            if(txtProp.Text.Length>(txtProp.MaxLength/2))
            {
                txtProp.Text = txtProp.Text.Substring(txtProp.Text.Length / 2);
            }
        
            txtProp.Text = txtProp.Text + "\r\n" + smsg;

            txtProp.SelectionStart = txtProp.Text.Length;
            txtProp.ScrollToCaret();
        }
        private librepad.LibrePad m_pad = new librepad.LibrePad();



        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_pad.ctlDestroy();

        }

       

        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void chkAreaInput_CheckedChanged(object sender, EventArgs e)
        {
            m_pad.EditMode = (true == chkUserInputMode.Checked ? librepad.euEditMode.USER : librepad.euEditMode.TEMPLATE);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.saveFile(null);
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.loadFile("");
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.ctlInit(panelMain);
            m_pad.OnShowMessage += Pad_OnShowMessage;
        }

        private void 当前选中文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = m_pad.getCurrentSelTxt();
            MessageBox.Show(s);
        }

        private void 测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.test();
        }

        private void 插入元素单选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.insertElementSingleSel();
        }

        private void 当前页号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m_pad.currentPageNum());
        }

        private void 插入文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.insertFile("");
        }

        private void 插入段落换行符ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.insertParaBreak();
        }

        private void 插入元素自由文本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.insertElementText();
        }

        private void 赋值取值测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAreaTest fat = new frmAreaTest();
            fat.PAD = m_pad;
            fat.ShowDialog();
        }

        private void 使只读结构化区域可写ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            librepad.AreaData area = m_pad.findArea("1", "1");
            if (null == area)
                return;

            area.Editable = "W";
            string sparam = area.saveBase64();

            if (null == sparam || sparam.Length <= 0)
                return;

            if (m_pad.setAreaParam("1", "1", sparam) == false)
                return;

            MessageBox.Show("设置只读区域可写成功!");
        }

        private void 转文档尾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.goDocEnd();
        }

        private void 转文档首ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.goDocStart();
        }

        private void 开始修订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.startRevise("");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            Close();
        }

        private void 结束修订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.stopRevise();
        }

        private void chkEleDontDel_CheckedChanged(object sender, EventArgs e)
        {
            m_pad.StructCanRemove = !chkEleDontDel.Checked;

        }

        private void 插入表格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_pad.insertTable();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            m_pad.ctlDestroy();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            m_pad.insertElementMultiSel();
        }
    }

       
    }
