
namespace MultithreadingScanningPort
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.beginScanning = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.endPortText = new System.Windows.Forms.TextBox();
            this.endPort = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.beginPortText = new System.Windows.Forms.TextBox();
            this.beginPort = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ipAddressText = new System.Windows.Forms.TextBox();
            this.ipAddress = new System.Windows.Forms.Label();
            this.messages = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.messages);
            this.splitContainer1.Size = new System.Drawing.Size(942, 493);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.progressBar1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 300);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 87);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(122, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(21, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 20);
            this.progressBar1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.beginScanning);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 393);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 100);
            this.panel4.TabIndex = 3;
            // 
            // beginScanning
            // 
            this.beginScanning.Location = new System.Drawing.Point(107, 22);
            this.beginScanning.Name = "beginScanning";
            this.beginScanning.Size = new System.Drawing.Size(176, 53);
            this.beginScanning.TabIndex = 0;
            this.beginScanning.Text = "开始扫描";
            this.beginScanning.UseVisualStyleBackColor = true;
            this.beginScanning.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.endPortText);
            this.panel3.Controls.Add(this.endPort);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 100);
            this.panel3.TabIndex = 2;
            // 
            // endPortText
            // 
            this.endPortText.Location = new System.Drawing.Point(116, 39);
            this.endPortText.Name = "endPortText";
            this.endPortText.Size = new System.Drawing.Size(186, 25);
            this.endPortText.TabIndex = 1;
            this.endPortText.Text = "3905";
            // 
            // endPort
            // 
            this.endPort.AutoSize = true;
            this.endPort.Location = new System.Drawing.Point(43, 42);
            this.endPort.Name = "endPort";
            this.endPort.Size = new System.Drawing.Size(67, 15);
            this.endPort.TabIndex = 0;
            this.endPort.Text = "结束端口";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.beginPortText);
            this.panel2.Controls.Add(this.beginPort);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 100);
            this.panel2.TabIndex = 1;
            // 
            // beginPortText
            // 
            this.beginPortText.Location = new System.Drawing.Point(116, 42);
            this.beginPortText.Name = "beginPortText";
            this.beginPortText.Size = new System.Drawing.Size(186, 25);
            this.beginPortText.TabIndex = 1;
            this.beginPortText.Text = "3900";
            // 
            // beginPort
            // 
            this.beginPort.AutoSize = true;
            this.beginPort.Location = new System.Drawing.Point(43, 45);
            this.beginPort.Name = "beginPort";
            this.beginPort.Size = new System.Drawing.Size(67, 15);
            this.beginPort.TabIndex = 0;
            this.beginPort.Text = "起始端口";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ipAddressText);
            this.panel1.Controls.Add(this.ipAddress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 100);
            this.panel1.TabIndex = 0;
            // 
            // ipAddressText
            // 
            this.ipAddressText.Location = new System.Drawing.Point(116, 44);
            this.ipAddressText.Name = "ipAddressText";
            this.ipAddressText.Size = new System.Drawing.Size(186, 25);
            this.ipAddressText.TabIndex = 1;
            this.ipAddressText.Text = "10.1.230.74";
            // 
            // ipAddress
            // 
            this.ipAddress.Location = new System.Drawing.Point(55, 47);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(55, 15);
            this.ipAddress.TabIndex = 0;
            this.ipAddress.Text = "ip地址";
            // 
            // messages
            // 
            this.messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messages.FormattingEnabled = true;
            this.messages.ItemHeight = 15;
            this.messages.Location = new System.Drawing.Point(0, 0);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(538, 493);
            this.messages.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "单线程扫描端口";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ipAddressText;
        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox endPortText;
        private System.Windows.Forms.Label endPort;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox beginPortText;
        private System.Windows.Forms.Label beginPort;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button beginScanning;
        private System.Windows.Forms.ListBox messages;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
    }
}

