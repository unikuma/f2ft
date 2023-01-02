using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
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
	}
}
