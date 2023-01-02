using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f2ft
{
	internal static class ExoEffectReplace
	{
		// エフェクトの数を取得する為の関数。それ以外でも行けるが。
		public static int GetSearchAllCount(string target, string search)
		{
			int count = 0;

			int index = target.IndexOf(search);
			while (index != -1)
			{
				count++;
				index = target.IndexOf(search, index + search.Length);
			}

			return count;
		}

		public static void Border2BorderT()
		{

		}

	}
}
