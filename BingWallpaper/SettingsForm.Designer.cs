namespace BingWallpaper
{
	partial class SettingsForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnChange = new System.Windows.Forms.Button();
			this.txtDownloadFolder = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chbAutoDownload = new System.Windows.Forms.CheckBox();
			this.btnSaveSettings = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnChange);
			this.groupBox1.Controls.Add(this.txtDownloadFolder);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.chbAutoDownload);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(392, 101);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(300, 38);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(75, 23);
			this.btnChange.TabIndex = 3;
			this.btnChange.Text = "更改";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// txtDownloadFolder
			// 
			this.txtDownloadFolder.Location = new System.Drawing.Point(103, 40);
			this.txtDownloadFolder.Name = "txtDownloadFolder";
			this.txtDownloadFolder.Size = new System.Drawing.Size(191, 21);
			this.txtDownloadFolder.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "壁纸下载目录：";
			// 
			// chbAutoDownload
			// 
			this.chbAutoDownload.AutoSize = true;
			this.chbAutoDownload.Location = new System.Drawing.Point(14, 21);
			this.chbAutoDownload.Name = "chbAutoDownload";
			this.chbAutoDownload.Size = new System.Drawing.Size(120, 16);
			this.chbAutoDownload.TabIndex = 0;
			this.chbAutoDownload.Text = "自动下载Bing壁纸";
			this.chbAutoDownload.UseVisualStyleBackColor = true;
			// 
			// btnSaveSettings
			// 
			this.btnSaveSettings.Location = new System.Drawing.Point(312, 151);
			this.btnSaveSettings.Name = "btnSaveSettings";
			this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
			this.btnSaveSettings.TabIndex = 1;
			this.btnSaveSettings.Text = "保存";
			this.btnSaveSettings.UseVisualStyleBackColor = true;
			this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(231, 151);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 200);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveSettings);
			this.Controls.Add(this.groupBox1);
			this.Name = "SettingsForm";
			this.Text = "软件设置";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.TextBox txtDownloadFolder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chbAutoDownload;
		private System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}