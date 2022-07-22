using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web2;

namespace Web2 {
	public partial class inputWindow : Form {
		public inputWindow() {
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e) {
			this.textBox1.Text=Properties.Settings.Default.index_page;
			Properties.Settings.Default.index_page = this.textBox1.Text;
			Properties.Settings.Default.Save();
			try {
				Close();
			}
			catch (InvalidOperationException i) {
				Console.WriteLine(i.Message);
				Console.WriteLine(i.StackTrace);
				Console.WriteLine(i.Source);
				Console.WriteLine(i.StackTrace.ToString());
				
			}
		}
		private void button2_Click(object sender, EventArgs e) {
			Properties.Settings.Default.Save();
			try {
				Close();
			}
			catch (InvalidOperationException i) {
				Console.WriteLine(i.Message);
				Console.WriteLine(i.StackTrace);
				Console.WriteLine(i.Source);
				Console.WriteLine(i.StackTrace.ToString());
			}
		}
	}
}