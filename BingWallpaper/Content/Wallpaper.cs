using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;

namespace BingWallpaper
{
	public sealed class Wallpaper
	{
		public Wallpaper() { }


		const int MAX_PATH = 260;
		const int SPI_GETDESKWALLPAPER = 0x73;
		const int SPI_SETDESKWALLPAPER = 0x14;
		const int SPIF_UPDATEINIFILE = 0x01;
		const int SPIF_SENDININICHANGE = 0x02;

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		static extern int GetLastError();

		public enum WallpaperStyle : int
		{
			Tiled,
			Centered,
			Stretched,
			Fill,
			Fit
		}

		/// <summary>
		/// 返回当前的系统壁纸路径
		/// </summary>
		/// <returns></returns>
		public static string GetDesktopWallpaper()
		{
			string wallpaper = new string('\0', MAX_PATH);
			int ret = SystemParametersInfo(SPI_GETDESKWALLPAPER, (int)wallpaper.Length, wallpaper, 0);
			return wallpaper.Substring(0, wallpaper.IndexOf('\0'));
		}

		public static void SetWallpaper(string path, WallpaperStyle style)
		{
			//System.Drawing.Image img = System.Drawing.Image.FromStream(s);
			//string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
			//img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);

			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
			if (style == WallpaperStyle.Stretched)
			{
				key.SetValue(@"WallpaperStyle", 2.ToString());
				key.SetValue(@"TileWallpaper", 0.ToString());
			}
			else if (style == WallpaperStyle.Centered)
			{
				key.SetValue(@"WallpaperStyle", 1.ToString());
				key.SetValue(@"TileWallpaper", 0.ToString());
			}
			else if (style == WallpaperStyle.Tiled)
			{
				key.SetValue(@"WallpaperStyle", 1.ToString());
				key.SetValue(@"TileWallpaper", 1.ToString());
			}
			else if (style == WallpaperStyle.Fit) //Win 7 or later
			{
				key.SetValue(@"WallpaperStyle", 6.ToString());
				key.SetValue(@"TileWallpaper", 0.ToString());
			}
			else if (style == WallpaperStyle.Fill)	//Win 7 or later
			{
				key.SetValue(@"WallpaperStyle", 10.ToString());
				key.SetValue(@"TileWallpaper", 1.ToString());
			}
			else
			{

			}

			int ret = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_SENDININICHANGE | SPIF_UPDATEINIFILE);
			if (ret > 0)
			{

			}
			else
			{
				int errCode = GetLastError();
			}
		}

	}
}
