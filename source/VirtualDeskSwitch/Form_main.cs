using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsDesktop;

namespace VirtualDeskSwitch
{
	public partial class Form_main : Form
	{
		public bool close = false;

		public Form_main()
		{
			InitializeComponent();
			switchToDesktop(VirtualDesktop.Current.Id);
			VirtualDesktop.CurrentChanged += new EventHandler<VirtualDesktopChangedEventArgs>(this.vDeskChanged);
			if (Properties.Settings.Default.DisplayStartNotification)
			{
				//notifyIcon_vDesk.ShowBalloonTip(10000);
				Form_StartSplash f = new Form_StartSplash($"Virtual Desk Switch has been started. " +
					$"\n\nIf the App icon isn't visible in the Notification Tray, " +
					$"click the ^ arrow next to the Notification Tray and check if it's in the hidden Notification Tray Area. " +
					$"Then drag & drop the icon to the visible notification area near the clock.", 17000);
				f.Location = new Point(Screen.PrimaryScreen.Bounds.Width - f.Bounds.Width - 50
					, Screen.PrimaryScreen.Bounds.Height);
				f.Show();
				for (int i = 0; i < 320; i += 3)
				{
					f.Location = new Point(Screen.PrimaryScreen.Bounds.Width - f.Bounds.Width - 50
						, Screen.PrimaryScreen.Bounds.Height - i);
				}
			}
			checkAtostartEnabled();
		}
		private void checkAtostartEnabled()
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\VirtualDeskSwitch.lnk"))
			{
				checkBox_Autostart.Checked = true;
			}
			else
			{
				checkBox_Autostart.Checked = false;
			}
		}
		private void vDeskChanged(object sender, VirtualDesktopChangedEventArgs e)
		{
			setNotificationIcon();
		}
		private void notifyIcon_vDesk_Click(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
			{
				return;
			}
			if (VirtualDesktop.Current.GetRight() != null)
			{
				switchToDesktop(VirtualDesktop.Current.GetRight().Id);
				this.MoveToDesktop(VirtualDesktop.Current);
			}
			else
			{
				var vDesks = VirtualDesktop.GetDesktops();
				if (vDesks != null && vDesks.Count() > 0)
				{
					switchToDesktop(vDesks[0].Id);
					this.MoveToDesktop(VirtualDesktop.Current);
				}
			}
		}
		private void switchToDesktop(Guid vDeskId)
		{
			VirtualDesktop.FromId(vDeskId).Switch();
			Application.DoEvents();
			setNotificationIcon();
		}
		private void setNotificationIcon()
		{
			int vDeskIndex = getCurrentVirtualDeskIndex();
			int iconIndex = vDeskIndex;
			if (iconIndex > 19)
			{
				iconIndex = 0;
			}
			Form_DesktopSplash DeskSplashInfo = new Form_DesktopSplash(vDeskIndex.ToString()
				, (int)Properties.Settings.Default.NotificationSplashDelay);
			DeskSplashInfo.Show();
			notifyIcon_vDesk.Icon = getResourceIcon(iconIndex);
			Application.DoEvents();
		}
		private int getCurrentVirtualDeskIndex()
		{
			VirtualDesktop[] vDesks = VirtualDesktop.GetDesktops();
			for (int i = 0; i < vDesks.Count(); i++)
			{
				if (VirtualDesktop.Current == vDesks[i])
				{
					return i + 1;
				}
			}
			return 0;
		}
		private Icon getResourceIcon(int vDeskIndex)
		{
			return getResourceIcon("_" + vDeskIndex);
		}
		private Icon getResourceIcon(string iconName)
		{
			object obj = Properties.Resources.ResourceManager.GetObject(iconName);
			return (Icon)obj;
		}
		private void addDesktopsToContextMenu()
		{
			List<ToolStripMenuItem> toRemoveList = new List<ToolStripMenuItem>();
			foreach (var item in contextMenuStrip_vDesk.Items)
			{
				if (item.GetType() == typeof(ToolStripMenuItem) && ((ToolStripMenuItem)item).Name.StartsWith("d"))
				{
					toRemoveList.Add((ToolStripMenuItem)item);
				}
			}
			foreach (var item in toRemoveList)
			{
				contextMenuStrip_vDesk.Items.Remove(item);
			}
			removeVirtualDesktopToolStripMenuItem.DropDownItems.Clear();
			VirtualDesktop[] vDesks = VirtualDesktop.GetDesktops();
			int vDeskIndex = getCurrentVirtualDeskIndex() - 1;
			if (vDesks != null && vDesks.Count() > 0)
			{
				for (int i = vDesks.Count() - 1; i >= 0; i--)
				{
					ToolStripMenuItem vDeskToolstripItem = new ToolStripMenuItem()
					{
						Name = "d" + (i + 1),
						Text = (i == vDeskIndex) ? "-> Desktop " + (i + 1) : "  Desktop " + (i + 1),
						Tag = vDesks[i].Id,
						Image = (i == vDeskIndex) ? (Image)Properties.Resources.ResourceManager.GetObject("active") : null
					};
					vDeskToolstripItem.Click += new System.EventHandler(this.vDeskToolStripMenuItem_Click);
					contextMenuStrip_vDesk.Items.Insert(0, vDeskToolstripItem);

					ToolStripMenuItem vDeskRemoveToolstripItem = new ToolStripMenuItem()
					{
						Name = "r" + (i + 1),
						Text = "Remove Desktop " + (i + 1),
						Tag = vDesks[i].Id,
						Image = (i == vDeskIndex) ? (Image)Properties.Resources.ResourceManager.GetObject("active") : null
					};
					vDeskRemoveToolstripItem.Click += new System.EventHandler(this.vDeskRemoveToolStripMenuItem_Click);
					removeVirtualDesktopToolStripMenuItem.DropDownItems.Insert(0, vDeskRemoveToolstripItem);
				}
			}
		}
		private void vDeskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Trace.WriteLine(e);
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			Guid vDeskId = (Guid)item.Tag;
			switchToDesktop(vDeskId);
		}
		private void vDeskRemoveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			Guid vDeskId = (Guid)item.Tag;
			VirtualDesktop.FromId(vDeskId).Remove();
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			close = true; // Tells the form_closing function to close
			this.Close();
		}
		private void ToolStripMenuItem_Settings_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.Focus();
			this.ShowInTaskbar = true;
			checkAtostartEnabled();
		}
		private void button_OK_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			this.ShowInTaskbar = false;
			Properties.Settings.Default.Save();
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing && close == false)
			{
				e.Cancel = true;
				this.WindowState = FormWindowState.Minimized;
				this.ShowInTaskbar = false;
			}
		}
		private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			addDesktopsToContextMenu();
		}
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox ab = new AboutBox();
			ab.StartPosition = FormStartPosition.CenterScreen;
			ab.ShowDialog();
		}
		private void addVirtualDesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			VirtualDesktop vDesk = VirtualDesktop.Create();
			vDesk.Switch();
		}
		private void button_RestoreDefaults_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Restore all Settings to their default values?", "Restore?"
				, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Properties.Settings.Default.Reset();
				Properties.Settings.Default.Save();
			}
		}

		[DllImport("user32.dll")]
		private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
		private const int KEYEVENTF_EXTENDEDKEY = 1;
		private const int KEYEVENTF_KEYUP = 2;
		public static void KeyDown(Keys vKey)
		{
			keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY, 0);
		}
		public static void KeyUp(Keys vKey)
		{
			keybd_event((byte)vKey, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
		}
		private void openTaskViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			KeyDown(Keys.LWin);
			KeyDown(Keys.Tab);
			KeyUp(Keys.LWin);
			KeyUp(Keys.Tab);
		}

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		private void fullInstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("The application will be installed to the users personal folder. A shortcut will be created in Startup and Desktop folder. Continue?", "Install?"
					, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Process p = new Process();
				p.StartInfo = new ProcessStartInfo("cmd", "/c install.bat");
				p.Start();
			}
		}

		private void fullUninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("The application will be completely uninstalled from this computer. Continue?", "Uninstall?"
					, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Process p = new Process();
				p.StartInfo = new ProcessStartInfo("cmd", "/c uninstall.bat");
				p.Start();
			}
		}

		private void checkBox_Autostart_Click(object sender, EventArgs e)
		{
			checkAtostartEnabled();
			if (checkBox_Autostart.Checked &&
				File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\VirtualDeskSwitch.lnk"))
			{
				try
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\VirtualDeskSwitch.lnk");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Autostart uninstall failed:\n\n" + ex.Message, "Error"
						, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				if (MessageBox.Show("A shortcut to the current application path will be installed to the users startup folder. Continue?", "Install?"
						, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Process p = new Process();
					p.StartInfo = new ProcessStartInfo("cmd", "/c install_autostart.bat");
					p.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
					p.Start();
					p.WaitForExit(10000);
				}
			}
			checkAtostartEnabled();
		}
	}
}
