using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualDeskSwitch
{
	public partial class Form_DesktopSplash : Form
	{
		public int SplashDelay { get; set; }
		public Form_DesktopSplash(string DeskNumber, int splashDelay=0)
		{
			InitializeComponent();
			label1.Text = "Desktop: " + DeskNumber;
			SplashDelay = splashDelay;
		}
		private void Form_DesktopSplash_Shown(object sender, EventArgs e)
		{
			Application.DoEvents();
			if (SplashDelay > 0)
			{
				System.Threading.Thread.Sleep(SplashDelay);
				this.Close();
			}
		}
	}
}
