namespace IP_Manager
{
	partial class config
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_cancle = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_name = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioBtn_fix_ip = new System.Windows.Forms.RadioButton();
			this.radioBtn_auto_ip = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.radioBtn_fix_dns = new System.Windows.Forms.RadioButton();
			this.radioBtn_auto_dns = new System.Windows.Forms.RadioButton();
			this.textbox_ip = new iptb.IPTextBox();
			this.textbox_subnetmask = new iptb.IPTextBox();
			this.textbox_gateway = new iptb.IPTextBox();
			this.textbox_dns1 = new iptb.IPTextBox();
			this.textbox_dns2 = new iptb.IPTextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textbox_gateway);
			this.groupBox1.Controls.Add(this.textbox_subnetmask);
			this.groupBox1.Controls.Add(this.textbox_ip);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(2, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 104);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "기본 게이트웨이 :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "서브넷 마스크 :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "IP 주소 :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textbox_dns2);
			this.groupBox2.Controls.Add(this.textbox_dns1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(4, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(390, 76);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "보조 DNS 서버 :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(122, 12);
			this.label6.TabIndex = 3;
			this.label6.Text = "기본 설정 DNS 서버 :";
			// 
			// btn_cancle
			// 
			this.btn_cancle.Location = new System.Drawing.Point(319, 111);
			this.btn_cancle.Name = "btn_cancle";
			this.btn_cancle.Size = new System.Drawing.Size(75, 23);
			this.btn_cancle.TabIndex = 10;
			this.btn_cancle.Text = "취소";
			this.btn_cancle.UseVisualStyleBackColor = true;
			this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(238, 111);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(75, 23);
			this.btn_ok.TabIndex = 9;
			this.btn_ok.Text = "확인";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 11);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "이름 :";
			// 
			// textBox_name
			// 
			this.textBox_name.Location = new System.Drawing.Point(62, 9);
			this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox_name.Name = "textBox_name";
			this.textBox_name.Size = new System.Drawing.Size(340, 21);
			this.textBox_name.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioBtn_fix_ip);
			this.panel1.Controls.Add(this.radioBtn_auto_ip);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(12, 35);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(398, 133);
			this.panel1.TabIndex = 14;
			// 
			// radioBtn_fix_ip
			// 
			this.radioBtn_fix_ip.AutoSize = true;
			this.radioBtn_fix_ip.Location = new System.Drawing.Point(8, 25);
			this.radioBtn_fix_ip.Name = "radioBtn_fix_ip";
			this.radioBtn_fix_ip.Size = new System.Drawing.Size(126, 16);
			this.radioBtn_fix_ip.TabIndex = 3;
			this.radioBtn_fix_ip.TabStop = true;
			this.radioBtn_fix_ip.Text = "다음 IP 주소 사용 :";
			this.radioBtn_fix_ip.UseVisualStyleBackColor = true;
			this.radioBtn_fix_ip.CheckedChanged += new System.EventHandler(this.radioBtn_fix_ip_CheckedChanged);
			// 
			// radioBtn_auto_ip
			// 
			this.radioBtn_auto_ip.AutoSize = true;
			this.radioBtn_auto_ip.Location = new System.Drawing.Point(8, 3);
			this.radioBtn_auto_ip.Name = "radioBtn_auto_ip";
			this.radioBtn_auto_ip.Size = new System.Drawing.Size(142, 16);
			this.radioBtn_auto_ip.TabIndex = 2;
			this.radioBtn_auto_ip.TabStop = true;
			this.radioBtn_auto_ip.Text = "자동으로 IP 주소 받기";
			this.radioBtn_auto_ip.UseVisualStyleBackColor = true;
			this.radioBtn_auto_ip.CheckedChanged += new System.EventHandler(this.radioBtn_auto_ip_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.radioBtn_fix_dns);
			this.panel2.Controls.Add(this.radioBtn_auto_dns);
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.btn_cancle);
			this.panel2.Controls.Add(this.btn_ok);
			this.panel2.Location = new System.Drawing.Point(12, 174);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(398, 143);
			this.panel2.TabIndex = 15;
			// 
			// radioBtn_fix_dns
			// 
			this.radioBtn_fix_dns.AutoSize = true;
			this.radioBtn_fix_dns.Location = new System.Drawing.Point(8, 27);
			this.radioBtn_fix_dns.Name = "radioBtn_fix_dns";
			this.radioBtn_fix_dns.Size = new System.Drawing.Size(168, 16);
			this.radioBtn_fix_dns.TabIndex = 16;
			this.radioBtn_fix_dns.TabStop = true;
			this.radioBtn_fix_dns.Text = "다음 DNS 서버 주소 사용 :";
			this.radioBtn_fix_dns.UseVisualStyleBackColor = true;
			this.radioBtn_fix_dns.CheckedChanged += new System.EventHandler(this.radioBtn_fix_dns_CheckedChanged);
			// 
			// radioBtn_auto_dns
			// 
			this.radioBtn_auto_dns.AutoSize = true;
			this.radioBtn_auto_dns.Location = new System.Drawing.Point(8, 5);
			this.radioBtn_auto_dns.Name = "radioBtn_auto_dns";
			this.radioBtn_auto_dns.Size = new System.Drawing.Size(184, 16);
			this.radioBtn_auto_dns.TabIndex = 14;
			this.radioBtn_auto_dns.TabStop = true;
			this.radioBtn_auto_dns.Text = "자동으로 DNS 서버 주소 받기";
			this.radioBtn_auto_dns.UseVisualStyleBackColor = true;
			this.radioBtn_auto_dns.CheckedChanged += new System.EventHandler(this.radioBtn_auto_dns_CheckedChanged);
			// 
			// textbox_ip
			// 
			this.textbox_ip.AutoSize = true;
			this.textbox_ip.Location = new System.Drawing.Point(204, 21);
			this.textbox_ip.Name = "textbox_ip";
			this.textbox_ip.Size = new System.Drawing.Size(131, 25);
			this.textbox_ip.TabIndex = 15;
			this.textbox_ip.ToolTipText = "";
			// 
			// textbox_subnetmask
			// 
			this.textbox_subnetmask.AutoSize = true;
			this.textbox_subnetmask.Location = new System.Drawing.Point(204, 46);
			this.textbox_subnetmask.Name = "textbox_subnetmask";
			this.textbox_subnetmask.Size = new System.Drawing.Size(131, 25);
			this.textbox_subnetmask.TabIndex = 16;
			this.textbox_subnetmask.ToolTipText = "";
			// 
			// textbox_gateway
			// 
			this.textbox_gateway.AutoSize = true;
			this.textbox_gateway.Location = new System.Drawing.Point(204, 71);
			this.textbox_gateway.Name = "textbox_gateway";
			this.textbox_gateway.Size = new System.Drawing.Size(131, 25);
			this.textbox_gateway.TabIndex = 17;
			this.textbox_gateway.ToolTipText = "";
			// 
			// textbox_dns1
			// 
			this.textbox_dns1.AutoSize = true;
			this.textbox_dns1.Location = new System.Drawing.Point(202, 17);
			this.textbox_dns1.Name = "textbox_dns1";
			this.textbox_dns1.Size = new System.Drawing.Size(131, 25);
			this.textbox_dns1.TabIndex = 16;
			this.textbox_dns1.ToolTipText = "";
			// 
			// textbox_dns2
			// 
			this.textbox_dns2.AutoSize = true;
			this.textbox_dns2.Location = new System.Drawing.Point(202, 43);
			this.textbox_dns2.Name = "textbox_dns2";
			this.textbox_dns2.Size = new System.Drawing.Size(131, 25);
			this.textbox_dns2.TabIndex = 17;
			this.textbox_dns2.ToolTipText = "";
			// 
			// config
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 324);
			this.ControlBox = false;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox_name);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Name = "config";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "추가 / 수정";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_cancle;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton radioBtn_fix_ip;
		private System.Windows.Forms.RadioButton radioBtn_auto_ip;
		private System.Windows.Forms.RadioButton radioBtn_auto_dns;
		private System.Windows.Forms.RadioButton radioBtn_fix_dns;
		private iptb.IPTextBox textbox_ip;
		private iptb.IPTextBox textbox_gateway;
		private iptb.IPTextBox textbox_subnetmask;
		private iptb.IPTextBox textbox_dns2;
		private iptb.IPTextBox textbox_dns1;
	}
}