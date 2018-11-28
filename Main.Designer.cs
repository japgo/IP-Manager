namespace IP_Manager
{
	partial class Main
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_modify = new System.Windows.Forms.Button();
			this.checkBox_all = new System.Windows.Forms.CheckBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_apply = new System.Windows.Forms.Button();
			this.checkedListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btn_modify
			// 
			this.btn_modify.Location = new System.Drawing.Point(250, 35);
			this.btn_modify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_modify.Name = "btn_modify";
			this.btn_modify.Size = new System.Drawing.Size(75, 29);
			this.btn_modify.TabIndex = 1;
			this.btn_modify.Text = "수정";
			this.btn_modify.UseVisualStyleBackColor = true;
			this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
			// 
			// checkBox_all
			// 
			this.checkBox_all.AutoSize = true;
			this.checkBox_all.Location = new System.Drawing.Point(15, 43);
			this.checkBox_all.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.checkBox_all.Name = "checkBox_all";
			this.checkBox_all.Size = new System.Drawing.Size(78, 19);
			this.checkBox_all.TabIndex = 4;
			this.checkBox_all.Text = "모두 체크";
			this.checkBox_all.UseVisualStyleBackColor = true;
			this.checkBox_all.Visible = false;
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(169, 35);
			this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 29);
			this.btn_add.TabIndex = 5;
			this.btn_add.Text = "추가";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(331, 35);
			this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 29);
			this.btn_delete.TabIndex = 6;
			this.btn_delete.Text = "삭제";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(314, 15);
			this.label2.TabIndex = 8;
			this.label2.Text = "※ 랜 카드 어뎁터 이름은 \'로컬 영역 연결\' 이여야 합니다.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(107, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "선택한 설정을 로컬 영역 연결 어뎁터에";
			// 
			// btn_apply
			// 
			this.btn_apply.Location = new System.Drawing.Point(331, 227);
			this.btn_apply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(75, 29);
			this.btn_apply.TabIndex = 10;
			this.btn_apply.Text = "적용";
			this.btn_apply.UseVisualStyleBackColor = true;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// checkedListBox
			// 
			this.checkedListBox.FormattingEnabled = true;
			this.checkedListBox.ItemHeight = 15;
			this.checkedListBox.Location = new System.Drawing.Point(15, 71);
			this.checkedListBox.Name = "checkedListBox";
			this.checkedListBox.Size = new System.Drawing.Size(391, 139);
			this.checkedListBox.TabIndex = 11;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 266);
			this.Controls.Add(this.checkedListBox);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.checkBox_all);
			this.Controls.Add(this.btn_modify);
			this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IP Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_modify;
		private System.Windows.Forms.CheckBox checkBox_all;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_apply;
		private System.Windows.Forms.ListBox checkedListBox;
	}
}

