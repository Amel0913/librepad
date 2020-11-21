namespace librepad_demo
{
    partial class frmAreaTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetAreaValue = new System.Windows.Forms.Button();
            this.txtAreaID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupID = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetAreaValue = new System.Windows.Forms.Button();
            this.txtValCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetAreaValue
            // 
            this.btnSetAreaValue.Location = new System.Drawing.Point(148, 235);
            this.btnSetAreaValue.Name = "btnSetAreaValue";
            this.btnSetAreaValue.Size = new System.Drawing.Size(75, 23);
            this.btnSetAreaValue.TabIndex = 26;
            this.btnSetAreaValue.Text = "赋值";
            this.btnSetAreaValue.UseVisualStyleBackColor = true;
            this.btnSetAreaValue.Click += new System.EventHandler(this.btnSetAreaValue_Click);
            // 
            // txtAreaID
            // 
            this.txtAreaID.Location = new System.Drawing.Point(58, 57);
            this.txtAreaID.Name = "txtAreaID";
            this.txtAreaID.Size = new System.Drawing.Size(250, 21);
            this.txtAreaID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "元素ID";
            // 
            // txtGroupID
            // 
            this.txtGroupID.Location = new System.Drawing.Point(58, 27);
            this.txtGroupID.Name = "txtGroupID";
            this.txtGroupID.Size = new System.Drawing.Size(250, 21);
            this.txtGroupID.TabIndex = 23;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(58, 90);
            this.txtVal.Multiline = true;
            this.txtVal.Name = "txtVal";
            this.txtVal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVal.Size = new System.Drawing.Size(250, 63);
            this.txtVal.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "值";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "分组ID";
            // 
            // btnGetAreaValue
            // 
            this.btnGetAreaValue.Location = new System.Drawing.Point(58, 235);
            this.btnGetAreaValue.Name = "btnGetAreaValue";
            this.btnGetAreaValue.Size = new System.Drawing.Size(75, 23);
            this.btnGetAreaValue.TabIndex = 30;
            this.btnGetAreaValue.Text = "取值";
            this.btnGetAreaValue.UseVisualStyleBackColor = true;
            this.btnGetAreaValue.Click += new System.EventHandler(this.btnGetAreaValue_Click);
            // 
            // txtValCode
            // 
            this.txtValCode.Location = new System.Drawing.Point(58, 166);
            this.txtValCode.Multiline = true;
            this.txtValCode.Name = "txtValCode";
            this.txtValCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValCode.Size = new System.Drawing.Size(250, 41);
            this.txtValCode.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "值编码";
            // 
            // frmAreaTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 337);
            this.Controls.Add(this.txtValCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetAreaValue);
            this.Controls.Add(this.btnSetAreaValue);
            this.Controls.Add(this.txtAreaID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupID);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAreaTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结构化赋值取值测试";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetAreaValue;
        private System.Windows.Forms.TextBox txtAreaID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupID;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetAreaValue;
        private System.Windows.Forms.TextBox txtValCode;
        private System.Windows.Forms.Label label3;
    }
}