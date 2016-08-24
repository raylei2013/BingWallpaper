namespace BingWallpaper
{
	partial class MainForm
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
			this.btnSetWallpaper = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioCenter = new System.Windows.Forms.RadioButton();
			this.radioTile = new System.Windows.Forms.RadioButton();
			this.radioStretch = new System.Windows.Forms.RadioButton();
			this.radioFit = new System.Windows.Forms.RadioButton();
			this.radioFill = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSetWallpaper
			// 
			this.btnSetWallpaper.Location = new System.Drawing.Point(408, 250);
			this.btnSetWallpaper.Name = "btnSetWallpaper";
			this.btnSetWallpaper.Size = new System.Drawing.Size(75, 23);
			this.btnSetWallpaper.TabIndex = 0;
			this.btnSetWallpaper.Text = "设置";
			this.btnSetWallpaper.UseVisualStyleBackColor = true;
			this.btnSetWallpaper.Click += new System.EventHandler(this.btnSetWallpaper_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(79, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(314, 21);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "当前壁纸：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "新壁纸：";
			// 
			// txtFilename
			// 
			this.txtFilename.Location = new System.Drawing.Point(79, 46);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(314, 21);
			this.txtFilename.TabIndex = 4;
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(410, 46);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
			this.btnSelectFile.TabIndex = 5;
			this.btnSelectFile.Text = "选择";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "jpg(*.jpg)|*.jpg|bmp(*.bmp)|*bmp|*.*|*.*";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(79, 73);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(314, 201);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioCenter);
			this.groupBox1.Controls.Add(this.radioTile);
			this.groupBox1.Controls.Add(this.radioStretch);
			this.groupBox1.Controls.Add(this.radioFit);
			this.groupBox1.Controls.Add(this.radioFill);
			this.groupBox1.Location = new System.Drawing.Point(408, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(77, 148);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "图片位置";
			// 
			// radioCenter
			// 
			this.radioCenter.AutoSize = true;
			this.radioCenter.Location = new System.Drawing.Point(12, 111);
			this.radioCenter.Name = "radioCenter";
			this.radioCenter.Size = new System.Drawing.Size(47, 16);
			this.radioCenter.TabIndex = 4;
			this.radioCenter.Text = "居中";
			this.radioCenter.UseVisualStyleBackColor = true;
			// 
			// radioTile
			// 
			this.radioTile.AutoSize = true;
			this.radioTile.Location = new System.Drawing.Point(12, 89);
			this.radioTile.Name = "radioTile";
			this.radioTile.Size = new System.Drawing.Size(47, 16);
			this.radioTile.TabIndex = 3;
			this.radioTile.Text = "平铺";
			this.radioTile.UseVisualStyleBackColor = true;
			// 
			// radioStretch
			// 
			this.radioStretch.AutoSize = true;
			this.radioStretch.Checked = true;
			this.radioStretch.Location = new System.Drawing.Point(12, 67);
			this.radioStretch.Name = "radioStretch";
			this.radioStretch.Size = new System.Drawing.Size(47, 16);
			this.radioStretch.TabIndex = 2;
			this.radioStretch.TabStop = true;
			this.radioStretch.Text = "拉伸";
			this.radioStretch.UseVisualStyleBackColor = true;
			// 
			// radioFit
			// 
			this.radioFit.AutoSize = true;
			this.radioFit.Location = new System.Drawing.Point(12, 45);
			this.radioFit.Name = "radioFit";
			this.radioFit.Size = new System.Drawing.Size(47, 16);
			this.radioFit.TabIndex = 1;
			this.radioFit.Text = "适应";
			this.radioFit.UseVisualStyleBackColor = true;
			// 
			// radioFill
			// 
			this.radioFill.AutoSize = true;
			this.radioFill.Location = new System.Drawing.Point(12, 23);
			this.radioFill.Name = "radioFill";
			this.radioFill.Size = new System.Drawing.Size(47, 16);
			this.radioFill.TabIndex = 0;
			this.radioFill.Text = "填充";
			this.radioFill.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.btnSetWallpaper);
			this.groupBox2.Controls.Add(this.btnSelectFile);
			this.groupBox2.Controls.Add(this.txtFilename);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 25);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(497, 290);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "预览：";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(497, 25);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 设置ToolStripMenuItem
			// 
			this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
			this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
			this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.设置ToolStripMenuItem.Text = "设置";
			// 
			// SettingsToolStripMenuItem
			// 
			this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
			this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.SettingsToolStripMenuItem.Text = "软件设置";
			this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 315);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Bing壁纸设置程序";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSetWallpaper;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioCenter;
		private System.Windows.Forms.RadioButton radioTile;
		private System.Windows.Forms.RadioButton radioStretch;
		private System.Windows.Forms.RadioButton radioFit;
		private System.Windows.Forms.RadioButton radioFill;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
		private System.Windows.Forms.Label label3;
	}
}

