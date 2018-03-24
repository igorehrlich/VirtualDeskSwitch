namespace VirtualDeskSwitch
{
	partial class Form_StartSplash
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label_Seconds = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label_close = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label_Seconds);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Location = new System.Drawing.Point(12, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(492, 245);
			this.panel1.TabIndex = 1;
			// 
			// label_Seconds
			// 
			this.label_Seconds.AutoSize = true;
			this.label_Seconds.ForeColor = System.Drawing.Color.White;
			this.label_Seconds.Location = new System.Drawing.Point(12, 216);
			this.label_Seconds.Name = "label_Seconds";
			this.label_Seconds.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label_Seconds.Size = new System.Drawing.Size(0, 17);
			this.label_Seconds.TabIndex = 2;
			this.label_Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.Black;
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(86, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(392, 232);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.TabStop = false;
			this.richTextBox1.Text = "";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label_close
			// 
			this.label_close.AutoSize = true;
			this.label_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_close.ForeColor = System.Drawing.Color.White;
			this.label_close.Location = new System.Drawing.Point(497, -4);
			this.label_close.Name = "label_close";
			this.label_close.Size = new System.Drawing.Size(19, 21);
			this.label_close.TabIndex = 3;
			this.label_close.Text = "x";
			this.label_close.Click += new System.EventHandler(this.label_close_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::VirtualDeskSwitch.Properties.Resources.app;
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(65, 65);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// Form_StartSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(516, 265);
			this.ControlBox = false;
			this.Controls.Add(this.label_close);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_StartSplash";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_DesktopSplash";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.Form_DesktopSplash_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label_Seconds;
		private System.Windows.Forms.Label label_close;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}