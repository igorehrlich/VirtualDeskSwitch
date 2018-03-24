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
	public partial class Form_StartSplash : Form
	{
		public int SplashDelay { get; set; }
		public Form_StartSplash(string text = "", int splashDelay = 0)
		{
			InitializeComponent();
			richTextBox1.Text = text;
			SplashDelay = splashDelay;
			label_Seconds.Focus();
		}
		private void Form_DesktopSplash_Shown(object sender, EventArgs e)
		{
			Application.DoEvents();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			SplashDelay = SplashDelay - 1000;
			if (SplashDelay < 0)
			{
				Application.DoEvents();
				this.Close();
			}
			label_Seconds.Text = $"({(int)(SplashDelay / 1000)} s)";
			Application.DoEvents();
		}

		private void label_close_Click(object sender, EventArgs e)
		{
			Application.DoEvents();
			this.Close();
		}
	}
}
