using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BingWallpaper
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
		}

		private void SettingsForm_Load(object sender, EventArgs e)
		{
			string isAutoDownload = CommonUtils.ReadSetting(CommonUtils.IS_AUTO_DOWNLOAD);
			string downloadSaveDir = CommonUtils.ReadSetting(CommonUtils.DOWNLOAD_SAVE_DIR);
			this.chbAutoDownload.Checked = isAutoDownload == "1";
			this.txtDownloadFolder.Text = downloadSaveDir;

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSaveSettings_Click(object sender, EventArgs e)
		{
			string isAutoDownload = this.chbAutoDownload.Checked ? "1" : "0";
			string downloadSaveDir = this.txtDownloadFolder.Text.Trim();

			if (CommonUtils.AddOrUpdateSettings(CommonUtils.IS_AUTO_DOWNLOAD, isAutoDownload)
					&& CommonUtils.AddOrUpdateSettings(CommonUtils.DOWNLOAD_SAVE_DIR, downloadSaveDir))
			{
				MessageBox.Show("保存成功！");
				this.Close();
			}
			else
			{
				MessageBox.Show("保存失败！");
			}
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == this.folderBrowserDialog1.ShowDialog())
			{
				this.txtDownloadFolder.Text = this.folderBrowserDialog1.SelectedPath;
			}
		}
	}
}
