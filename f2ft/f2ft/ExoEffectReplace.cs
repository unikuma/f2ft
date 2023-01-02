using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace f2ft
{
	internal class ExoEffectReplace
	{
		public ExoEffectReplace(List<string> inputExoFiles)
		{
			InputExoFiles = inputExoFiles;
			OutputExoFiles = new List<string>();
		}

		public List<string> InputExoFiles { get; private set; }     //処理を行うExoファイル
		public List<string> OutputExoFiles { get; private set; }    //処理が終わったExoファイル

		public ExoEffectReplaceCodes Border2BorderT(bool FutidoriT, bool HighPrecision, bool Namerakaf)
		{
			if (InputExoFiles.Count < 1)
				return ExoEffectReplaceCodes.ExoNotFound;

			foreach (string StrFile in InputExoFiles)
			{
				// 出力後のファイルパスを作る。元のファイル名-日付.exoというフォーマットになる
				string OutputFile = $"{StrFile.Remove(StrFile.Length - ".exo".Length)}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm")}.exo";

				// 処理を行うファイルをshift-jisで開く
				string ReadExo = File.ReadAllText(StrFile, Encoding.GetEncoding("shift_jis"));

				if (GetSearchAllCount(ReadExo, "_name=縁取り\r\n") == 0)
				{
					MessageBox.Show("縁取りエフェクトがありません。スキップします", "f2ft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					continue;
				}

				while (true)
				{
					//もし縁取りエフェクトが見つからなかったら、処理後のテキストをOutputFileとしてshift-jisで出力
					if (ReadExo.IndexOf("_name=縁取り\r\n") == -1)
					{
						File.WriteAllText(OutputFile, ReadExo, Encoding.GetEncoding("shift_jis"));
						OutputExoFiles.Add(OutputFile);
						break;
					}

					//正規表現を用いて縁取りエフェクトのテキストを取得
					Match SearchExo = Regex.Match(ReadExo, @"_name=縁取り\r\n_disable=[0-1]\r\nサイズ=(([0-9]+)|([0-9]+\.[0-9]))\r\nぼかし=(([0-9]+)|([0-9]+\.[0-9]))\r\ncolor=(([0-9a-fA-F]+)|(000000))\r\nfile=\r\n");

					//先ほど取得したエフェクトのテキストから各パラメータの値を文字列として取得
					string Size = Regex.Match(SearchExo.Value, @"サイズ=(([0-9]+)|([0-9]+\.[0-9]))\r\n").Value.Split('=')[1].Replace(Environment.NewLine, "");
					string Blur = Regex.Match(SearchExo.Value, @"ぼかし=(([0-9]+)|([0-9]+\.[0-9]))\r\n").Value.Split('=')[1].Replace(Environment.NewLine, "");
					string Color = Regex.Match(SearchExo.Value, @"color=(([0-9a-fA-F]+)|(000000))\r\n").Value.Split('=')[1].Replace(Environment.NewLine, "");

					//取得した値から縁取りTエフェクト(もしくはなめらか縁取りエフェクト)の文字列を生成
					string ReplaceExo = null;

					if (FutidoriT)//もしrdoDefaultがチェックされていたら、縁取りT(標準)に置換する
						ReplaceExo = string.Format("_name=アニメーション効果\r\ntrack0={0}\r\ntrack1={1}\r\ntrack2=128.00\r\ntrack3=100.00\r\ncheck0=0\r\ntype=0\r\nfilter=0\r\nname=縁取りT\r\nparam=local col1={2};local col2=0x0;local Lgr=0;local Mis={3};local MiV=25;local MiA=25;local mode=0;\r\n", Size, Blur, Color == "000000" ? Color : "0x" + Color, Blur == "0" ? "0" : "1");
					else if (HighPrecision)//もしrdoHighprecisionがチェックされていたら、縁取りT(高精度)に置換する
						ReplaceExo = string.Format("_name=アニメーション効果\r\ntrack0={0}\r\ntrack1={1}\r\ntrack2=128.00\r\ntrack3=100.00\r\ncheck0=1\r\ntype=0\r\nfilter=0\r\nname=縁取りT\r\nparam=local col1={2};local col2=0x0;local Lgr=0;local Mis={3};local MiV=25;local MiA=25;local mode=0;\r\n", Size, Blur, Color == "000000" ? Color : "0x" + Color, Blur == "0" ? "0" : "1");
					else if (Namerakaf)//もしradoNamerakafがチェックされていたら、なめらか縁取りに置換する。
						ReplaceExo = string.Format("_name=アニメーション効果\r\ntrack0={0}\r\ntrack1=10\r\nname=なめらか縁取り\r\nparam=color={1}\r\n", Size, Color == "000000" ? Color : "0x" + Color);

					//縁取りエフェクトの文字列を置換用テキストに置換
					ReadExo = ReadExo.Replace(SearchExo.Value, ReplaceExo);
				}
			}

			return ExoEffectReplaceCodes.Success;
		}

		private int GetSearchAllCount(string target, string search)
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
	}

	internal enum ExoEffectReplaceCodes
	{
		Success,
		ExoNotFound,

	}
}
