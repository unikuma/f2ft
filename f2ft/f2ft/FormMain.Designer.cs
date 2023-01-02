
namespace f2ft
{
	partial class FormMain
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.MainPage = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnRun = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.LstExoFiles = new System.Windows.Forms.ListBox();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MenuSelectItemsDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuAllItemsDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.Label1 = new System.Windows.Forms.Label();
			this.SettingPage = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.FlowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.ChkHrgnSmall = new System.Windows.Forms.CheckBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.RdoFutidoriT = new System.Windows.Forms.RadioButton();
			this.RdoHighPrecision = new System.Windows.Forms.RadioButton();
			this.RdoNmrkf = new System.Windows.Forms.RadioButton();
			this.InfoPage = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.LinkGitHub = new System.Windows.Forms.LinkLabel();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.LinkTwitter = new System.Windows.Forms.LinkLabel();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.TxtVersionInfo = new System.Windows.Forms.TextBox();
			this.TabControl1.SuspendLayout();
			this.MainPage.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SettingPage.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.FlowLayoutPanel2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.FlowLayoutPanel1.SuspendLayout();
			this.InfoPage.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabControl1
			// 
			this.TabControl1.Controls.Add(this.MainPage);
			this.TabControl1.Controls.Add(this.SettingPage);
			this.TabControl1.Controls.Add(this.InfoPage);
			this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl1.Location = new System.Drawing.Point(0, 0);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(325, 375);
			this.TabControl1.TabIndex = 0;
			this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
			// 
			// MainPage
			// 
			this.MainPage.Controls.Add(this.TableLayoutPanel1);
			this.MainPage.Location = new System.Drawing.Point(4, 26);
			this.MainPage.Name = "MainPage";
			this.MainPage.Size = new System.Drawing.Size(317, 345);
			this.MainPage.TabIndex = 0;
			this.MainPage.Text = "一般";
			this.MainPage.UseVisualStyleBackColor = true;
			// 
			// TableLayoutPanel1
			// 
			this.TableLayoutPanel1.ColumnCount = 1;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanel1.Controls.Add(this.BtnRun, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
			this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.TableLayoutPanel1.RowCount = 2;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.44757F));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.55243F));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(317, 345);
			this.TableLayoutPanel1.TabIndex = 0;
			// 
			// BtnRun
			// 
			this.BtnRun.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnRun.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
			this.BtnRun.Location = new System.Drawing.Point(5, 257);
			this.BtnRun.Margin = new System.Windows.Forms.Padding(0);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(307, 83);
			this.BtnRun.TabIndex = 1;
			this.BtnRun.Text = "実行";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Panel1
			// 
			this.Panel1.Controls.Add(this.LstExoFiles);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(5, 5);
			this.Panel1.Margin = new System.Windows.Forms.Padding(0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(307, 252);
			this.Panel1.TabIndex = 2;
			// 
			// LstExoFiles
			// 
			this.LstExoFiles.AllowDrop = true;
			this.LstExoFiles.ContextMenuStrip = this.ContextMenuStrip1;
			this.LstExoFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LstExoFiles.FormattingEnabled = true;
			this.LstExoFiles.ItemHeight = 17;
			this.LstExoFiles.Location = new System.Drawing.Point(0, 22);
			this.LstExoFiles.Margin = new System.Windows.Forms.Padding(5);
			this.LstExoFiles.Name = "LstExoFiles";
			this.LstExoFiles.Size = new System.Drawing.Size(307, 230);
			this.LstExoFiles.TabIndex = 1;
			this.LstExoFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LstExoFiles_DragDrop);
			this.LstExoFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.LstExoFiles_DragEnter);
			// 
			// ContextMenuStrip1
			// 
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSelectItemsDelete,
            this.MenuAllItemsDelete});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(196, 48);
			// 
			// MenuSelectItemsDelete
			// 
			this.MenuSelectItemsDelete.Name = "MenuSelectItemsDelete";
			this.MenuSelectItemsDelete.Size = new System.Drawing.Size(195, 22);
			this.MenuSelectItemsDelete.Text = "選択されたアイテムを削除";
			// 
			// MenuAllItemsDelete
			// 
			this.MenuAllItemsDelete.Name = "MenuAllItemsDelete";
			this.MenuAllItemsDelete.Size = new System.Drawing.Size(195, 22);
			this.MenuAllItemsDelete.Text = "全てのアイテムを削除";
			// 
			// Label1
			// 
			this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.Label1.Location = new System.Drawing.Point(0, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(307, 22);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "下のリストボックスにExoファイルをD&&Dしてください";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SettingPage
			// 
			this.SettingPage.Controls.Add(this.TableLayoutPanel2);
			this.SettingPage.Location = new System.Drawing.Point(4, 26);
			this.SettingPage.Name = "SettingPage";
			this.SettingPage.Size = new System.Drawing.Size(317, 345);
			this.SettingPage.TabIndex = 1;
			this.SettingPage.Text = "設定";
			this.SettingPage.UseVisualStyleBackColor = true;
			// 
			// TableLayoutPanel2
			// 
			this.TableLayoutPanel2.ColumnCount = 1;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel2.Controls.Add(this.GroupBox2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.GroupBox1, 0, 0);
			this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
			this.TableLayoutPanel2.RowCount = 2;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(317, 345);
			this.TableLayoutPanel2.TabIndex = 0;
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.FlowLayoutPanel2);
			this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox2.Location = new System.Drawing.Point(5, 105);
			this.GroupBox2.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(307, 235);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "その他の設定";
			// 
			// FlowLayoutPanel2
			// 
			this.FlowLayoutPanel2.Controls.Add(this.ChkHrgnSmall);
			this.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowLayoutPanel2.Location = new System.Drawing.Point(3, 21);
			this.FlowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.FlowLayoutPanel2.Name = "FlowLayoutPanel2";
			this.FlowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.FlowLayoutPanel2.Size = new System.Drawing.Size(301, 211);
			this.FlowLayoutPanel2.TabIndex = 0;
			// 
			// ChkHrgnSmall
			// 
			this.ChkHrgnSmall.AutoSize = true;
			this.ChkHrgnSmall.Location = new System.Drawing.Point(13, 3);
			this.ChkHrgnSmall.Name = "ChkHrgnSmall";
			this.ChkHrgnSmall.Size = new System.Drawing.Size(124, 23);
			this.ChkHrgnSmall.TabIndex = 0;
			this.ChkHrgnSmall.Text = "ひらがな小さ置換";
			this.ChkHrgnSmall.UseVisualStyleBackColor = true;
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.FlowLayoutPanel1);
			this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox1.Location = new System.Drawing.Point(5, 5);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(307, 100);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "縁取り系設定";
			// 
			// FlowLayoutPanel1
			// 
			this.FlowLayoutPanel1.Controls.Add(this.RdoFutidoriT);
			this.FlowLayoutPanel1.Controls.Add(this.RdoHighPrecision);
			this.FlowLayoutPanel1.Controls.Add(this.RdoNmrkf);
			this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowLayoutPanel1.Location = new System.Drawing.Point(3, 21);
			this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
			this.FlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.FlowLayoutPanel1.Size = new System.Drawing.Size(301, 76);
			this.FlowLayoutPanel1.TabIndex = 0;
			// 
			// RdoFutidoriT
			// 
			this.RdoFutidoriT.AutoSize = true;
			this.RdoFutidoriT.Checked = true;
			this.RdoFutidoriT.Location = new System.Drawing.Point(13, 3);
			this.RdoFutidoriT.Name = "RdoFutidoriT";
			this.RdoFutidoriT.Size = new System.Drawing.Size(72, 23);
			this.RdoFutidoriT.TabIndex = 0;
			this.RdoFutidoriT.TabStop = true;
			this.RdoFutidoriT.Text = "縁取りT";
			this.RdoFutidoriT.UseVisualStyleBackColor = true;
			// 
			// RdoHighPrecision
			// 
			this.RdoHighPrecision.AutoSize = true;
			this.RdoHighPrecision.Location = new System.Drawing.Point(91, 3);
			this.RdoHighPrecision.Name = "RdoHighPrecision";
			this.RdoHighPrecision.Size = new System.Drawing.Size(142, 23);
			this.RdoHighPrecision.TabIndex = 1;
			this.RdoHighPrecision.Text = "縁取りT（高精度）";
			this.RdoHighPrecision.UseVisualStyleBackColor = true;
			// 
			// RdoNmrkf
			// 
			this.RdoNmrkf.AutoSize = true;
			this.RdoNmrkf.Location = new System.Drawing.Point(13, 32);
			this.RdoNmrkf.Name = "RdoNmrkf";
			this.RdoNmrkf.Size = new System.Drawing.Size(109, 23);
			this.RdoNmrkf.TabIndex = 2;
			this.RdoNmrkf.Text = "なめらか縁取り";
			this.RdoNmrkf.UseVisualStyleBackColor = true;
			// 
			// InfoPage
			// 
			this.InfoPage.Controls.Add(this.TableLayoutPanel3);
			this.InfoPage.Location = new System.Drawing.Point(4, 26);
			this.InfoPage.Name = "InfoPage";
			this.InfoPage.Size = new System.Drawing.Size(317, 345);
			this.InfoPage.TabIndex = 2;
			this.InfoPage.Text = "情報";
			this.InfoPage.UseVisualStyleBackColor = true;
			// 
			// TableLayoutPanel3
			// 
			this.TableLayoutPanel3.ColumnCount = 1;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel3.Controls.Add(this.GroupBox4, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.GroupBox3, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.GroupBox5, 0, 2);
			this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
			this.TableLayoutPanel3.RowCount = 3;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(317, 345);
			this.TableLayoutPanel3.TabIndex = 0;
			// 
			// GroupBox4
			// 
			this.GroupBox4.Controls.Add(this.LinkGitHub);
			this.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox4.Location = new System.Drawing.Point(5, 55);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(307, 50);
			this.GroupBox4.TabIndex = 1;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "最新版の確認はこちらから";
			// 
			// LinkGitHub
			// 
			this.LinkGitHub.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LinkGitHub.Location = new System.Drawing.Point(3, 21);
			this.LinkGitHub.Name = "LinkGitHub";
			this.LinkGitHub.Size = new System.Drawing.Size(301, 26);
			this.LinkGitHub.TabIndex = 0;
			this.LinkGitHub.TabStop = true;
			this.LinkGitHub.Text = "https://github.com/unikuma/f2ft/releases/latest";
			this.LinkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.LinkTwitter);
			this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox3.Location = new System.Drawing.Point(5, 5);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(307, 50);
			this.GroupBox3.TabIndex = 0;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "不具合・バグなどは作者Twitterまでご連絡ください";
			// 
			// LinkTwitter
			// 
			this.LinkTwitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LinkTwitter.Location = new System.Drawing.Point(3, 21);
			this.LinkTwitter.Name = "LinkTwitter";
			this.LinkTwitter.Size = new System.Drawing.Size(301, 26);
			this.LinkTwitter.TabIndex = 0;
			this.LinkTwitter.TabStop = true;
			this.LinkTwitter.Text = "https://twitter.com/unikuma_sub";
			this.LinkTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
			// 
			// GroupBox5
			// 
			this.GroupBox5.Controls.Add(this.TxtVersionInfo);
			this.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GroupBox5.Location = new System.Drawing.Point(5, 105);
			this.GroupBox5.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(307, 235);
			this.GroupBox5.TabIndex = 2;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "バージョン情報";
			// 
			// TxtVersionInfo
			// 
			this.TxtVersionInfo.BackColor = System.Drawing.SystemColors.Window;
			this.TxtVersionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TxtVersionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtVersionInfo.Location = new System.Drawing.Point(3, 21);
			this.TxtVersionInfo.Margin = new System.Windows.Forms.Padding(0);
			this.TxtVersionInfo.Multiline = true;
			this.TxtVersionInfo.Name = "TxtVersionInfo";
			this.TxtVersionInfo.ReadOnly = true;
			this.TxtVersionInfo.Size = new System.Drawing.Size(301, 211);
			this.TxtVersionInfo.TabIndex = 0;
			this.TxtVersionInfo.Text = "f2ft.exe (x86) [Version 3.1.0]\r\nCopyright (c) 2022 unikuma. All rights reserved.\r" +
    "\n";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(325, 375);
			this.Controls.Add(this.TabControl1);
			this.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.Text = "f2ft";
			this.TabControl1.ResumeLayout(false);
			this.MainPage.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.SettingPage.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.FlowLayoutPanel2.ResumeLayout(false);
			this.FlowLayoutPanel2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.FlowLayoutPanel1.ResumeLayout(false);
			this.FlowLayoutPanel1.PerformLayout();
			this.InfoPage.ResumeLayout(false);
			this.TableLayoutPanel3.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl1;
		private System.Windows.Forms.TabPage MainPage;
		private System.Windows.Forms.TabPage SettingPage;
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		private System.Windows.Forms.Button BtnRun;
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
		private System.Windows.Forms.GroupBox GroupBox2;
		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
		private System.Windows.Forms.RadioButton RdoFutidoriT;
		private System.Windows.Forms.RadioButton RdoHighPrecision;
		private System.Windows.Forms.RadioButton RdoNmrkf;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.ListBox LstExoFiles;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MenuSelectItemsDelete;
		private System.Windows.Forms.ToolStripMenuItem MenuAllItemsDelete;
		private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel2;
		private System.Windows.Forms.CheckBox ChkHrgnSmall;
		private System.Windows.Forms.TabPage InfoPage;
		private System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
		private System.Windows.Forms.GroupBox GroupBox4;
		private System.Windows.Forms.LinkLabel LinkGitHub;
		private System.Windows.Forms.GroupBox GroupBox3;
		private System.Windows.Forms.LinkLabel LinkTwitter;
		private System.Windows.Forms.GroupBox GroupBox5;
		private System.Windows.Forms.TextBox TxtVersionInfo;
	}
}

