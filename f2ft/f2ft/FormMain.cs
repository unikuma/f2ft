using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f2ft
{
	internal partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();

			this.MinimumSize = this.Size;

			// 故意にイベントを起こしてタブのタイトルを変える
			TabControl1_SelectedIndexChanged(TabControl1, null);


		}

		// タブが変わったらウィンドウのタイトルを現在選択中のタブのテキストに変える。
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.Text = $"f2ft - {((TabControl)sender).SelectedTab.Text}";
		}

		// LinkLabel.Textに書かれているURLに飛ぶようになっている。
		// 新しくLinkLabelを追加した際は、Textプロパティを飛びたいURLにし、LinkClickedにこれを指定するだけ。
		private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(((LinkLabel)sender).Text);
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			// 下処理（ExoEffectReplaceクラスのコンストラクタに渡すリストの作成）
			List<string> ExoFilePaths = new List<string>();
			for (int i = 0; i < LstExoFiles.Items.Count; i++)
			{
				if (Regex.IsMatch(LstExoFiles.Items[i].ToString(), @"\.exo$"))
					ExoFilePaths.Add(LstExoFiles.Items[i].ToString());
			}

			ExoEffectReplace eer = new ExoEffectReplace(ExoFilePaths);
			switch (eer.Border2BorderT(RdoFutidoriT.Checked, RdoHighPrecision.Checked, RdoNmrkf.Checked))
			{
				case ExoEffectReplaceCodes.Success:
					string FinishExo = null;
					foreach (string OutputExoFile in eer.OutputExoFiles)
						FinishExo += OutputExoFile + "\r\n";
					MessageBox.Show($"以下のファイルの処理が終わりました。\r\n{FinishExo}", "f2ft", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
				case ExoEffectReplaceCodes.ExoNotFound:
					MessageBox.Show("Exoファイルが指定されていなかったので処理を行えませんでした。", "f2ft", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
			}
		}

		// リストボックスへのD&D操作
		private void LstExoFiles_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void LstExoFiles_DragDrop(object sender, DragEventArgs e)
		{
			//コントロール内にドロップされたとき実行される
			//ドロップされたすべてのファイル名を取得する
			string[] fileName =	(string[])e.Data.GetData(DataFormats.FileDrop, false);
			//ListBoxに追加する
			LstExoFiles.Items.AddRange(fileName);
		}
	}
}
