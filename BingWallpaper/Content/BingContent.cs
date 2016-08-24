using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BingWallpaper
{
	public class BingContent : ITextParse
	{
		private string content;

		public BingContent(string content)
		{
			this.content = content;
		}

		public string GetImageUrl()
		{
			string url = string.Empty;

			try
			{
				string start_flag = "g_img={"; //开头标志
				string end_flag = "}";
				int index = content.IndexOf(start_flag);
				if (index != -1)
				{
					//string content = content.Substring(index);
					int endIndex = content.IndexOf(end_flag, index);
					if (endIndex != -1)
					{
						string subContent = content.Substring(index, endIndex - index + 1);
						Console.WriteLine(subContent);

						// 截取 "{", "}"
						string data = subContent.Substring(subContent.IndexOf('{'));
						string[] dataArr = data.Split(',');
						string[] items = dataArr[0].Split(':');

						url = items[1] + ":" + items[2];
						url = url.Substring(2, url.Length - 3);
					}
				}

				//if (!string.IsNullOrEmpty(url))
				//{
				//    string file = "bing.jpg";
				//    string[] arr = url.Split('/');
				//    if (arr.Length > 0)
				//    {
				//        file = arr[arr.Length - 1];
				//    }
				//}
			}
			catch { }

			return url;
		}
	}
}
