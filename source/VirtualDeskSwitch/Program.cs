using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualDeskSwitch
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			bool createdNew;
			using (Mutex mutex = new Mutex(true, "VirtualDeskSwitch", out createdNew))
			{
				if (createdNew)
				{
					Application.EnableVisualStyles();
					Application.SetCompatibleTextRenderingDefault(false);
					Application.Run(new Form_main());
				}
				else
				{
					MessageBox.Show("Another Instance of Virtual Desk Switch is Already Running!"
						+ " \n\nPlease close all running instances of this app and try again.", "Error"
						, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
		}
	}
}
