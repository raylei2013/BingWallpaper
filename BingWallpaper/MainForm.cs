using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BingWallpaper
{
	public partial class MainForm : Form
	{
		private string newWallpaperPath = string.Empty;
		private const string bingAddress = "http://cn.bing.com/";


		public MainForm()
		{
			InitializeComponent();
		}

		public Wallpaper.WallpaperStyle SelectWallpaperStyle
		{
			get
			{
				if (this.radioCenter.Checked)
				{
					return Wallpaper.WallpaperStyle.Centered;
				}
				else if (this.radioFill.Checked)
				{
					return Wallpaper.WallpaperStyle.Fill;
				}
				else if (this.radioFit.Checked)
				{
					return Wallpaper.WallpaperStyle.Fit;
				}
				else if (this.radioStretch.Checked)
				{
					return Wallpaper.WallpaperStyle.Stretched;
				}
				else if (this.radioTile.Checked)
				{
					return Wallpaper.WallpaperStyle.Tiled;
				}
				else
				{
					return Wallpaper.WallpaperStyle.Stretched;
				}
			}
		}

		public static bool SupprtJpgWallpaper
		{
			get
			{
				return (Environment.OSVersion.Version >= new Version(6, 0));
			}
		}
		public static bool SupprtFitFillWallpaper
		{
			get
			{
				return (Environment.OSVersion.Version >= new Version(6, 1));
			}
		}

		private void btnSetWallpaper_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.newWallpaperPath) || !File.Exists(this.newWallpaperPath))
			{
				MessageBox.Show("文件不存在！");
				return;
			}

			string ext = Path.GetExtension(this.newWallpaperPath);
			if ((!ext.Equals(".bmp", StringComparison.OrdinalIgnoreCase) &&
				 !ext.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
				 ||
				 (ext.Equals(".jpg", StringComparison.OrdinalIgnoreCase) &&
					!SupprtJpgWallpaper)))
			{
				using (Image image = Image.FromFile(this.newWallpaperPath))
				{
					this.newWallpaperPath = String.Format(@"{0}\Microsoft\Windows\Themes\{1}.bmp",
						Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
						Path.GetFileNameWithoutExtension(this.newWallpaperPath));
					image.Save(this.newWallpaperPath, ImageFormat.Bmp);
				}
			}


			//string path = @"C:\Users\Administrator\Pictures\moon.jpg";
			Wallpaper.SetWallpaper(this.newWallpaperPath, this.SelectWallpaperStyle);
			this.textBox1.Text = Wallpaper.GetDesktopWallpaper();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.textBox1.Text = Wallpaper.GetDesktopWallpaper();
			openFileDialog1.Multiselect = false;
			openFileDialog1.InitialDirectory = CommonUtils.DownloadSaveDir;
			previewImage(this.textBox1.Text);

			Task.Factory.StartNew(() => autoDownload());

		}


		private void autoDownload()
		{
			string date = DateTime.Now.ToString("yyyyMMdd");
			string[] files = Directory.GetFiles(CommonUtils.DownloadSaveDir, string.Format("*{0}*", date));

			if (files.Length <= 0)
			{
				string html = WebHelper.GetContent(bingAddress);
				BingContent bing = new BingContent(html);
				string url = bing.GetImageUrl();

				string filename = CommonUtils.ParseFileName(url);

				WebHelper.GetFile(url, filename);

			}

		}

		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			if (DialogResult.OK != openFileDialog1.ShowDialog()) return;

			this.newWallpaperPath = openFileDialog1.FileName;
			this.txtFilename.Text = this.newWallpaperPath;

			previewImage(this.newWallpaperPath);
		}


		private void previewImage(string path)
		{
			//图像预览
			Image image = Image.FromFile(path);

			if (image.Width < this.pictureBox1.Width
				&& image.Height < this.pictureBox1.Height)
			{
				this.pictureBox1.Image = image;
			}
			else
			{
				float imageRatio = (float)image.Width / (float)image.Height;
				float picboxRatio = (float)pictureBox1.Width / (float)pictureBox1.Height;

				if (imageRatio > picboxRatio)
				{
					this.pictureBox1.Image = image.GetThumbnailImage(
								this.pictureBox1.Width,
								(int)(this.pictureBox1.Width / imageRatio),
								null, IntPtr.Zero);
				}
				else
				{
					this.pictureBox1.Image = image.GetThumbnailImage(
							  (int)(this.pictureBox1.Height * imageRatio),
							  this.pictureBox1.Height,
							  null, IntPtr.Zero);
				}
			}
		}

		private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsForm settings = new SettingsForm();
			settings.ShowDialog();
		}
	}
}
