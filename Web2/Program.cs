using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web2.Properties;

namespace Web2 {
	internal static class Program {
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(String[] args) {


			string init = Settings.Default.index_page;

			if (args.Length != 0) {
				init = args[0];
			}
			else {
			}



			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow(init));
			Settings.Default.Save();
		}

	}
}
