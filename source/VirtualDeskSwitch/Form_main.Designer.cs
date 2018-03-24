namespace VirtualDeskSwitch
{
	partial class Form_main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
			this.notifyIcon_vDesk = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip_vDesk = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.addVirtualDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeVirtualDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.openTaskViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button_OK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox_Autostart = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.checkBox_showNotificationOnStart = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown_NotificationSplashDelay = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetToDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.installationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.installToAutoStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.roundButton1 = new VirtualDeskSwitch.RoundButton();
			this.contextMenuStrip_vDesk.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NotificationSplashDelay)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// notifyIcon_vDesk
			// 
			this.notifyIcon_vDesk.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon_vDesk.BalloonTipText = resources.GetString("notifyIcon_vDesk.BalloonTipText");
			this.notifyIcon_vDesk.BalloonTipTitle = "VirtualDeskSwitch - Ready to switch";
			this.notifyIcon_vDesk.ContextMenuStrip = this.contextMenuStrip_vDesk;
			this.notifyIcon_vDesk.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_vDesk.Icon")));
			this.notifyIcon_vDesk.Text = "Virtual Desk Switch";
			this.notifyIcon_vDesk.Visible = true;
			this.notifyIcon_vDesk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_vDesk_Click);
			// 
			// contextMenuStrip_vDesk
			// 
			this.contextMenuStrip_vDesk.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.addVirtualDesktopToolStripMenuItem,
            this.removeVirtualDesktopToolStripMenuItem,
            this.toolStripSeparator3,
            this.openTaskViewToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip_vDesk.Name = "contextMenuStrip1";
			this.contextMenuStrip_vDesk.Size = new System.Drawing.Size(201, 154);
			this.contextMenuStrip_vDesk.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
			// 
			// addVirtualDesktopToolStripMenuItem
			// 
			this.addVirtualDesktopToolStripMenuItem.Image = global::VirtualDeskSwitch.Properties.Resources.add2;
			this.addVirtualDesktopToolStripMenuItem.Name = "addVirtualDesktopToolStripMenuItem";
			this.addVirtualDesktopToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.addVirtualDesktopToolStripMenuItem.Text = "Add Virtual Desktop";
			this.addVirtualDesktopToolStripMenuItem.Click += new System.EventHandler(this.addVirtualDesktopToolStripMenuItem_Click);
			// 
			// removeVirtualDesktopToolStripMenuItem
			// 
			this.removeVirtualDesktopToolStripMenuItem.Image = global::VirtualDeskSwitch.Properties.Resources.remove2;
			this.removeVirtualDesktopToolStripMenuItem.Name = "removeVirtualDesktopToolStripMenuItem";
			this.removeVirtualDesktopToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.removeVirtualDesktopToolStripMenuItem.Text = "Remove Virtual Desktop";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);
			// 
			// openTaskViewToolStripMenuItem
			// 
			this.openTaskViewToolStripMenuItem.Name = "openTaskViewToolStripMenuItem";
			this.openTaskViewToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.openTaskViewToolStripMenuItem.Text = "Open TaskView";
			this.openTaskViewToolStripMenuItem.Click += new System.EventHandler(this.openTaskViewToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Image = global::VirtualDeskSwitch.Properties.Resources.settings;
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.ShowShortcutKeys = false;
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Settings_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = global::VirtualDeskSwitch.Properties.Resources.info;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// button_OK
			// 
			this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_OK.Location = new System.Drawing.Point(378, 243);
			this.button_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(100, 35);
			this.button_OK.TabIndex = 1;
			this.button_OK.Text = "Close";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Delay for Display Info";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "info.png");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(403, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "[ms]";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkGray;
			this.label4.Location = new System.Drawing.Point(0, 276);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(186, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "(C) 2018  - Igor Ehrlich (MIT License)";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.checkBox_Autostart);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.checkBox_showNotificationOnStart);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.numericUpDown_NotificationSplashDelay);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(13, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(465, 185);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Application Settings";
			// 
			// checkBox_Autostart
			// 
			this.checkBox_Autostart.AutoCheck = false;
			this.checkBox_Autostart.AutoSize = true;
			this.checkBox_Autostart.Location = new System.Drawing.Point(263, 106);
			this.checkBox_Autostart.Name = "checkBox_Autostart";
			this.checkBox_Autostart.Size = new System.Drawing.Size(15, 14);
			this.checkBox_Autostart.TabIndex = 11;
			this.checkBox_Autostart.UseVisualStyleBackColor = true;
			this.checkBox_Autostart.Click += new System.EventHandler(this.checkBox_Autostart_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 102);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Autostart at Logon";
			// 
			// checkBox_showNotificationOnStart
			// 
			this.checkBox_showNotificationOnStart.AutoSize = true;
			this.checkBox_showNotificationOnStart.Checked = global::VirtualDeskSwitch.Properties.Settings.Default.DisplayStartNotification;
			this.checkBox_showNotificationOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_showNotificationOnStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::VirtualDeskSwitch.Properties.Settings.Default, "DisplayStartNotification", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.checkBox_showNotificationOnStart.Location = new System.Drawing.Point(263, 73);
			this.checkBox_showNotificationOnStart.Name = "checkBox_showNotificationOnStart";
			this.checkBox_showNotificationOnStart.Size = new System.Drawing.Size(15, 14);
			this.checkBox_showNotificationOnStart.TabIndex = 9;
			this.checkBox_showNotificationOnStart.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 69);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Show Notification on first start";
			// 
			// numericUpDown_NotificationSplashDelay
			// 
			this.numericUpDown_NotificationSplashDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown_NotificationSplashDelay.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::VirtualDeskSwitch.Properties.Settings.Default, "NotificationSplashDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.numericUpDown_NotificationSplashDelay.Location = new System.Drawing.Point(263, 37);
			this.numericUpDown_NotificationSplashDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.numericUpDown_NotificationSplashDelay.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.numericUpDown_NotificationSplashDelay.Name = "numericUpDown_NotificationSplashDelay";
			this.numericUpDown_NotificationSplashDelay.Size = new System.Drawing.Size(133, 27);
			this.numericUpDown_NotificationSplashDelay.TabIndex = 4;
			this.numericUpDown_NotificationSplashDelay.Value = global::VirtualDeskSwitch.Properties.Settings.Default.NotificationSplashDelay;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.installationToolStripMenuItem,
            this.aboutToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(490, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToDefaultsToolStripMenuItem,
            this.closeApplicationToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.fileToolStripMenuItem.Text = "Tools";
			// 
			// resetToDefaultsToolStripMenuItem
			// 
			this.resetToDefaultsToolStripMenuItem.Name = "resetToDefaultsToolStripMenuItem";
			this.resetToDefaultsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.resetToDefaultsToolStripMenuItem.Text = "Restore to Defaults";
			this.resetToDefaultsToolStripMenuItem.Click += new System.EventHandler(this.button_RestoreDefaults_Click);
			// 
			// closeApplicationToolStripMenuItem
			// 
			this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
			this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.closeApplicationToolStripMenuItem.Text = "Close Application";
			this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// installationToolStripMenuItem
			// 
			this.installationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.installToAutoStartToolStripMenuItem,
            this.uninstallToolStripMenuItem});
			this.installationToolStripMenuItem.Name = "installationToolStripMenuItem";
			this.installationToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.installationToolStripMenuItem.Text = "Install";
			// 
			// installToAutoStartToolStripMenuItem
			// 
			this.installToAutoStartToolStripMenuItem.Name = "installToAutoStartToolStripMenuItem";
			this.installToAutoStartToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.installToAutoStartToolStripMenuItem.Text = "Full Install";
			this.installToAutoStartToolStripMenuItem.Click += new System.EventHandler(this.fullInstallToolStripMenuItem_Click);
			// 
			// uninstallToolStripMenuItem
			// 
			this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
			this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.uninstallToolStripMenuItem.Text = "Full Uninstall";
			this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.fullUninstallToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// roundButton1
			// 
			this.roundButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.roundButton1.BackColor = System.Drawing.Color.Transparent;
			this.roundButton1.BackgroundImage = global::VirtualDeskSwitch.Properties.Resources.info;
			this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButton1.FlatAppearance.BorderSize = 0;
			this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
			this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.roundButton1.Location = new System.Drawing.Point(13, 205);
			this.roundButton1.Name = "roundButton1";
			this.roundButton1.Size = new System.Drawing.Size(68, 68);
			this.roundButton1.TabIndex = 11;
			this.roundButton1.UseVisualStyleBackColor = false;
			this.roundButton1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// Form_main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(490, 292);
			this.Controls.Add(this.roundButton1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button_OK);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(506, 331);
			this.Name = "Form_main";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Virtual Desk Switch";
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.contextMenuStrip_vDesk.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NotificationSplashDelay)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon_vDesk;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_vDesk;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown_NotificationSplashDelay;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem addVirtualDesktopToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeVirtualDesktopToolStripMenuItem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private RoundButton roundButton1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetToDefaultsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem installationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem installToAutoStartToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.CheckBox checkBox_showNotificationOnStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem openTaskViewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.CheckBox checkBox_Autostart;
		private System.Windows.Forms.Label label5;
	}
}

