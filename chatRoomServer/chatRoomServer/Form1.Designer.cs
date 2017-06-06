namespace chatRoomServer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnResetIp = new System.Windows.Forms.Button();
            this.btnRcv = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labIPnow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMsg
            // 
            this.txtMsg.AcceptsReturn = true;
            this.txtMsg.Location = new System.Drawing.Point(81, 28);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(424, 239);
            this.txtMsg.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(81, 298);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 42);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(219, 299);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 41);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "重置监听服务器的IP:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(568, 67);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(246, 25);
            this.txtIP.TabIndex = 4;
            // 
            // btnResetIp
            // 
            this.btnResetIp.Location = new System.Drawing.Point(568, 114);
            this.btnResetIp.Name = "btnResetIp";
            this.btnResetIp.Size = new System.Drawing.Size(102, 28);
            this.btnResetIp.TabIndex = 5;
            this.btnResetIp.Text = "重置";
            this.btnResetIp.UseVisualStyleBackColor = true;
            this.btnResetIp.Click += new System.EventHandler(this.btnResetIp_Click);
            // 
            // btnRcv
            // 
            this.btnRcv.Location = new System.Drawing.Point(714, 114);
            this.btnRcv.Name = "btnRcv";
            this.btnRcv.Size = new System.Drawing.Size(99, 27);
            this.btnRcv.TabIndex = 6;
            this.btnRcv.Text = "恢复默认";
            this.btnRcv.UseVisualStyleBackColor = true;
            this.btnRcv.Click += new System.EventHandler(this.btnRcv_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(368, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清屏";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "当前监听的IP为：";
            // 
            // labIPnow
            // 
            this.labIPnow.AutoSize = true;
            this.labIPnow.Location = new System.Drawing.Point(688, 246);
            this.labIPnow.Name = "labIPnow";
            this.labIPnow.Size = new System.Drawing.Size(47, 15);
            this.labIPnow.TabIndex = 9;
            this.labIPnow.Text = "IPnow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 385);
            this.Controls.Add(this.labIPnow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRcv);
            this.Controls.Add(this.btnResetIp);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMsg);
            this.Name = "Form1";
            this.Text = "chatRoomServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnResetIp;
        private System.Windows.Forms.Button btnRcv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labIPnow;
    }
}

