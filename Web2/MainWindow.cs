using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web2 {
	public partial class MainWindow : Form {

		public ChromiumWebBrowser browser;
		public void InitBrowser(string a) {

			CefSharp.Cef.Initialize(new CefSettings());
			browser = new ChromiumWebBrowser(a);
			this.Controls.Add(browser);
			browser.Dock = DockStyle.Fill;

		}
		public MainWindow(string i) {
			InitBrowser(i);
			InitializeComponent();
		}

		private void ChromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e) { }
		private void SetToolStripMenuItem_Click(object sender, EventArgs e) {
		}
		private void mainToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				Application.Run(new inputWindow());
				
			}
			catch(InvalidOperationException i) {
				Application.Exit();

			}

		}

		private void sysToolStripMenuItem_Click(object sender, EventArgs e) {

		}

		private void chromiumWebBrowser1_LoadingStateChanged_1(object sender, CefSharp.LoadingStateChangedEventArgs e) {

		}
	}
}
