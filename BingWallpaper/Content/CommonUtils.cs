using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace BingWallpaper
{
	public static class CommonUtils
	{
		/// <summary>
		/// 是否自动下载壁纸
		/// </summary>
		public const string IS_AUTO_DOWNLOAD = "IS_AUTO_DOWNLOAD";
		/// <summary>
		/// 壁纸下载目录
		/// </summary>
		public const string DOWNLOAD_SAVE_DIR = "DOWNLOAD_SAVE_DIR";
		/// <summary>
		/// 添加或更新App.config中的(key, value)
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool AddOrUpdateSettings(string key, string value)
		{

			try
			{
				var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
				var settings = configFile.AppSettings.Settings;
				if (settings[key] == null)
				{
					settings.Add(key, value);
				}
				else
				{
					settings[key].Value = value;
				}

				configFile.Save(ConfigurationSaveMode.Modified);
				ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
				return true;
			}
			catch
			{
			}

			return false;
		}
		/// <summary>
		/// 读取App.config中的Setting值
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string ReadSetting(string key)
		{
			try
			{
				var settings = ConfigurationManager.AppSettings;
				return settings[key] == null ? "" : settings[key];
			}
			catch
			{

			}

			return string.Empty;
		}

		public static string DownloadSaveDir
		{
			get
			{
				string path = string.Empty;
				try
				{
					string downloadSaveDir = ReadSetting(DOWNLOAD_SAVE_DIR);
					path = Directory.GetCurrentDirectory() + downloadSaveDir;

					if (!Directory.Exists(path))
						Directory.CreateDirectory(path);
				}
				catch
				{
				}
				return path;
			}
		}

		/// <summary>
		/// 根据要下载的URL解析出文件名
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		public static string ParseFileName(string url)
		{
			if (string.IsNullOrEmpty(url)) return string.Empty;
			string path = CommonUtils.DownloadSaveDir;

			try
			{
				int index = url.LastIndexOf('/');
				if (index != -1)
				{
					string date = DateTime.Now.ToString("yyyyMMdd");
					string filename = url.Substring(index + 1);
					int pos = filename.LastIndexOf('_');
					date = pos != -1 ? date + filename.Substring(pos) : date;
					path += date;
				}
			}
			catch
			{
			}

			return path;
		}
	}
}
