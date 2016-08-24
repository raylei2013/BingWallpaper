using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace BingWallpaper
{
	/// <summary>
	/// 网页内容抓取类
	/// </summary>
	public static class WebHelper
	{
		/// <summary>
		/// 获取指定网页内容
		/// </summary>
		/// <param name="url"></param>
		/// <returns></returns>
		public static string GetContent(string url)
		{
			string result = string.Empty;
			try
			{
				if (string.IsNullOrEmpty(url)) return result;
				//Console.WriteLine(DateTime.Now.ToString());
				using (WebClient client = new WebClient())
				{
					result = client.DownloadString(url);
				}
				//Console.WriteLine(DateTime.Now.ToString());
			}
			catch 
			{
				//Console.WriteLine(ex.Message);
			}


			return result;
		}

		/// <summary>
		/// 从指定URL中下载文件
		/// </summary>
		/// <param name="address"></param>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static bool GetFile(string address, string filename)
		{
			try
			{
				if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(filename)) return false;
				//Console.WriteLine(DateTime.Now.ToString());
				using (WebClient client = new WebClient())
				{
					//Uri uri = new Uri(address);
					client.DownloadFile(address, filename);
				}
				//Console.WriteLine(DateTime.Now.ToString());
				return true;
			}
			catch
			{
				//Console.WriteLine(ex.Message);
			}


			return false;
		}
	}
}
