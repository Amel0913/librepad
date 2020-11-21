namespace librepad_demo
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabRight = new System.Windows.Forms.TabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkUserInputMode = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结构化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入字段自由文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入字段单选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.使只读结构化区域可写ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.赋值取值测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入段落换行符ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.当前选中文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.当前页号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转文档尾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转文档首ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.开始修订ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结束修订ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.panelMain = new System.Windows.Forms.Panel();
            this.chkEleDontDel = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabRight.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1176, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 959);
            this.panel1.TabIndex = 0;
            // 
            // tabRight
            // 
            this.tabRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRight.Controls.Add(this.tabPageLog);
            this.tabRight.Location = new System.Drawing.Point(0, 70);
            this.tabRight.Margin = new System.Windows.Forms.Padding(4);
            this.tabRight.Name = "tabRight";
            this.tabRight.SelectedIndex = 0;
            this.tabRight.Size = new System.Drawing.Size(449, 796);
            this.tabRight.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.txtProp);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Size = new System.Drawing.Size(441, 767);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.Text = "日志";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // txtProp
            // 
            this.txtProp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProp.Location = new System.Drawing.Point(4, 4);
            this.txtProp.Margin = new System.Windows.Forms.Padding(4);
            this.txtProp.Multiline = true;
            this.txtProp.Name = "txtProp";
            this.txtProp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProp.Size = new System.Drawing.Size(433, 759);
            this.txtProp.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 867);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1176, 92);
            this.panel3.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 70);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chkEleDontDel);
            this.panel4.Controls.Add(this.chkUserInputMode);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1176, 70);
            this.panel4.TabIndex = 3;
            // 
            // chkUserInputMode
            // 
            this.chkUserInputMode.AutoSize = true;
            this.chkUserInputMode.Checked = true;
            this.chkUserInputMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUserInputMode.Location = new System.Drawing.Point(9, 42);
            this.chkUserInputMode.Margin = new System.Windows.Forms.Padding(4);
            this.chkUserInputMode.Name = "chkUserInputMode";
            this.chkUserInputMode.Size = new System.Drawing.Size(119, 19);
            this.chkUserInputMode.TabIndex = 0;
            this.chkUserInputMode.Text = "用户输入模式";
            this.chkUserInputMode.UseVisualStyleBackColor = true;
            this.chkUserInputMode.CheckedChanged += new System.EventHandler(this.chkAreaInput_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.结构化ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.功能测试ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1470, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 结构化ToolStripMenuItem
            // 
            this.结构化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入字段自由文本ToolStripMenuItem,
            this.插入字段单选项ToolStripMenuItem,
            this.toolStripSeparator1,
            this.使只读结构化区域可写ToolStripMenuItem,
            this.赋值取值测试ToolStripMenuItem});
            this.结构化ToolStripMenuItem.Name = "结构化ToolStripMenuItem";
            this.结构化ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.结构化ToolStripMenuItem.Text = "结构化";
            // 
            // 插入字段自由文本ToolStripMenuItem
            // 
            this.插入字段自由文本ToolStripMenuItem.Name = "插入字段自由文本ToolStripMenuItem";
            this.插入字段自由文本ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.插入字段自由文本ToolStripMenuItem.Text = "插入元素（自由文本）";
            this.插入字段自由文本ToolStripMenuItem.Click += new System.EventHandler(this.插入元素自由文本ToolStripMenuItem_Click);
            // 
            // 插入字段单选项ToolStripMenuItem
            // 
            this.插入字段单选项ToolStripMenuItem.Name = "插入字段单选项ToolStripMenuItem";
            this.插入字段单选项ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.插入字段单选项ToolStripMenuItem.Text = "插入元素（单选项）";
            this.插入字段单选项ToolStripMenuItem.Click += new System.EventHandler(this.插入元素单选项ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // 使只读结构化区域可写ToolStripMenuItem
            // 
            this.使只读结构化区域可写ToolStripMenuItem.Name = "使只读结构化区域可写ToolStripMenuItem";
            this.使只读结构化区域可写ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.使只读结构化区域可写ToolStripMenuItem.Text = "使只读结构化区域可写";
            this.使只读结构化区域可写ToolStripMenuItem.Click += new System.EventHandler(this.使只读结构化区域可写ToolStripMenuItem_Click);
            // 
            // 赋值取值测试ToolStripMenuItem
            // 
            this.赋值取值测试ToolStripMenuItem.Name = "赋值取值测试ToolStripMenuItem";
            this.赋值取值测试ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.赋值取值测试ToolStripMenuItem.Text = "赋值取值测试";
            this.赋值取值测试ToolStripMenuItem.Click += new System.EventHandler(this.赋值取值测试ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入文件ToolStripMenuItem,
            this.插入段落换行符ToolStripMenuItem,
            this.toolStripSeparator2,
            this.当前选中文件ToolStripMenuItem,
            this.当前页号ToolStripMenuItem,
            this.转文档尾ToolStripMenuItem,
            this.转文档首ToolStripMenuItem,
            this.toolStripSeparator3,
            this.开始修订ToolStripMenuItem,
            this.结束修订ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 插入文件ToolStripMenuItem
            // 
            this.插入文件ToolStripMenuItem.Name = "插入文件ToolStripMenuItem";
            this.插入文件ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.插入文件ToolStripMenuItem.Text = "插入文件";
            this.插入文件ToolStripMenuItem.Click += new System.EventHandler(this.插入文件ToolStripMenuItem_Click);
            // 
            // 插入段落换行符ToolStripMenuItem
            // 
            this.插入段落换行符ToolStripMenuItem.Name = "插入段落换行符ToolStripMenuItem";
            this.插入段落换行符ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.插入段落换行符ToolStripMenuItem.Text = "插入段落换行符";
            this.插入段落换行符ToolStripMenuItem.Click += new System.EventHandler(this.插入段落换行符ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(194, 6);
            // 
            // 当前选中文件ToolStripMenuItem
            // 
            this.当前选中文件ToolStripMenuItem.Name = "当前选中文件ToolStripMenuItem";
            this.当前选中文件ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.当前选中文件ToolStripMenuItem.Text = "当前选中文本";
            this.当前选中文件ToolStripMenuItem.Click += new System.EventHandler(this.当前选中文本ToolStripMenuItem_Click);
            // 
            // 当前页号ToolStripMenuItem
            // 
            this.当前页号ToolStripMenuItem.Name = "当前页号ToolStripMenuItem";
            this.当前页号ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.当前页号ToolStripMenuItem.Text = "当前页号";
            this.当前页号ToolStripMenuItem.Click += new System.EventHandler(this.当前页号ToolStripMenuItem_Click);
            // 
            // 转文档尾ToolStripMenuItem
            // 
            this.转文档尾ToolStripMenuItem.Name = "转文档尾ToolStripMenuItem";
            this.转文档尾ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.转文档尾ToolStripMenuItem.Text = "转文档尾";
            this.转文档尾ToolStripMenuItem.Click += new System.EventHandler(this.转文档尾ToolStripMenuItem_Click);
            // 
            // 转文档首ToolStripMenuItem
            // 
            this.转文档首ToolStripMenuItem.Name = "转文档首ToolStripMenuItem";
            this.转文档首ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.转文档首ToolStripMenuItem.Text = "转文档首";
            this.转文档首ToolStripMenuItem.Click += new System.EventHandler(this.转文档首ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // 开始修订ToolStripMenuItem
            // 
            this.开始修订ToolStripMenuItem.Name = "开始修订ToolStripMenuItem";
            this.开始修订ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.开始修订ToolStripMenuItem.Text = "开始修订";
            this.开始修订ToolStripMenuItem.Click += new System.EventHandler(this.开始修订ToolStripMenuItem_Click);
            // 
            // 结束修订ToolStripMenuItem
            // 
            this.结束修订ToolStripMenuItem.Name = "结束修订ToolStripMenuItem";
            this.结束修订ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.结束修订ToolStripMenuItem.Text = "结束修订";
            this.结束修订ToolStripMenuItem.Click += new System.EventHandler(this.结束修订ToolStripMenuItem_Click);
            // 
            // 功能测试ToolStripMenuItem
            // 
            this.功能测试ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试ToolStripMenuItem});
            this.功能测试ToolStripMenuItem.Name = "功能测试ToolStripMenuItem";
            this.功能测试ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.功能测试ToolStripMenuItem.Text = "帮助";
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.测试ToolStripMenuItem.Text = "简单测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.测试ToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 70);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 797);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(1172, 70);
            this.splitter2.Margin = new System.Windows.Forms.Padding(4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 797);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(4, 863);
            this.splitter3.Margin = new System.Windows.Forms.Padding(4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1168, 4);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter4.Location = new System.Drawing.Point(4, 70);
            this.splitter4.Margin = new System.Windows.Forms.Padding(4);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(1168, 4);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(4, 74);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 789);
            this.panelMain.TabIndex = 8;
            // 
            // chkEleDontDel
            // 
            this.chkEleDontDel.AutoSize = true;
            this.chkEleDontDel.Checked = true;
            this.chkEleDontDel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEleDontDel.Location = new System.Drawing.Point(136, 42);
            this.chkEleDontDel.Margin = new System.Windows.Forms.Padding(4);
            this.chkEleDontDel.Name = "chkEleDontDel";
            this.chkEleDontDel.Size = new System.Drawing.Size(205, 24);
            this.chkEleDontDel.TabIndex = 2;
            this.chkEleDontDel.Text = "结构化元素不可删除";
            this.chkEleDontDel.UseVisualStyleBackColor = true;
            this.chkEleDontDel.CheckedChanged += new System.EventHandler(this.chkEleDontDel_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 959);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结构化文书 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.tabRight.ResumeLayout(false);
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabRight;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.CheckBox chkUserInputMode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结构化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入字段自由文本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入字段单选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 使只读结构化区域可写ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 赋值取值测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入段落换行符ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 当前选中文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 当前页号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转文档尾ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转文档首ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 开始修订ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结束修订ToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkEleDontDel;
    }
}

