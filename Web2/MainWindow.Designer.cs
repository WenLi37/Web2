namespace Web2 {
	partial class MainWindow {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.设置 = new System.Windows.Forms.ToolStripMenuItem();
			this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// 设置
			// 
			this.设置.Checked = true;
			this.设置.CheckState = System.Windows.Forms.CheckState.Checked;
			this.设置.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.sysToolStripMenuItem});
			this.设置.Name = "设置";
			resources.ApplyResources(this.设置, "设置");
			this.设置.Click += new System.EventHandler(this.SetToolStripMenuItem_Click);
			// 
			// mainToolStripMenuItem
			// 
			this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
			resources.ApplyResources(this.mainToolStripMenuItem, "mainToolStripMenuItem");
			this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
			// 
			// sysToolStripMenuItem
			// 
			this.sysToolStripMenuItem.Name = "sysToolStripMenuItem";
			resources.ApplyResources(this.sysToolStripMenuItem, "sysToolStripMenuItem");
			this.sysToolStripMenuItem.Click += new System.EventHandler(this.sysToolStripMenuItem_Click);
			// 
			// chromiumWebBrowser1
			// 
			this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
			resources.ApplyResources(this.chromiumWebBrowser1, "chromiumWebBrowser1");
			this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
			this.chromiumWebBrowser1.LoadingStateChanged += new System.EventHandler<CefSharp.LoadingStateChangedEventArgs>(this.chromiumWebBrowser1_LoadingStateChanged_1);
			// 
			// MainWindow
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.chromiumWebBrowser1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void 主页ToolStripMenuI(object sender, System.EventArgs e) {
			throw new System.NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 设置;
		private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sysToolStripMenuItem;
		private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
	}
}

