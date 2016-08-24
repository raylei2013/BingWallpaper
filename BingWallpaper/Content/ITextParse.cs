using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BingWallpaper
{
	/// <summary>
	/// 文本解析接口，对应于对不同的网站内容进行文本解析取出目标地址；
	/// </summary>
	interface ITextParse
	{
		/// <summary>
		/// 返回图像Url
		/// </summary>
		/// <returns></returns>
		string GetImageUrl();
	}
}
