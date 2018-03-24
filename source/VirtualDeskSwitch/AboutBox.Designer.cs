namespace VirtualDeskSwitch
{
	partial class AboutBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label_Author = new System.Windows.Forms.Label();
			this.label_Link = new System.Windows.Forms.Label();
			this.label_Version = new System.Windows.Forms.Label();
			this.textBox_Description = new System.Windows.Forms.TextBox();
			this.button_Close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VirtualDeskSwitch.Properties.Resources.app;
			this.pictureBox1.InitialImage = global::VirtualDeskSwitch.Properties.Resources.app;
			this.pictureBox1.Location = new System.Drawing.Point(16, 18);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(111, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(432, 65);
			this.label1.TabIndex = 1;
			this.label1.Text = "Virtual Desk Switch";
			// 
			// label_Author
			// 
			this.label_Author.AutoSize = true;
			this.label_Author.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Author.Location = new System.Drawing.Point(15, 110);
			this.label_Author.Name = "label_Author";
			this.label_Author.Size = new System.Drawing.Size(77, 30);
			this.label_Author.TabIndex = 2;
			this.label_Author.Text = "Author";
			// 
			// label_Link
			// 
			this.label_Link.AutoSize = true;
			this.label_Link.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Link.Location = new System.Drawing.Point(15, 144);
			this.label_Link.Name = "label_Link";
			this.label_Link.Size = new System.Drawing.Size(50, 30);
			this.label_Link.TabIndex = 3;
			this.label_Link.Text = "Link";
			// 
			// label_Version
			// 
			this.label_Version.AutoSize = true;
			this.label_Version.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Version.Location = new System.Drawing.Point(15, 176);
			this.label_Version.Name = "label_Version";
			this.label_Version.Size = new System.Drawing.Size(81, 30);
			this.label_Version.TabIndex = 4;
			this.label_Version.Text = "Version";
			// 
			// textBox_Description
			// 
			this.textBox_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_Description.BackColor = System.Drawing.Color.White;
			this.textBox_Description.Location = new System.Drawing.Point(20, 232);
			this.textBox_Description.Multiline = true;
			this.textBox_Description.Name = "textBox_Description";
			this.textBox_Description.ReadOnly = true;
			this.textBox_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox_Description.Size = new System.Drawing.Size(626, 355);
			this.textBox_Description.TabIndex = 5;
			this.textBox_Description.Text = resources.GetString("textBox_Description.Text");
			// 
			// button_Close
			// 
			this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Close.Location = new System.Drawing.Point(571, 600);
			this.button_Close.Name = "button_Close";
			this.button_Close.Size = new System.Drawing.Size(75, 33);
			this.button_Close.TabIndex = 6;
			this.button_Close.Text = "Close";
			this.button_Close.UseVisualStyleBackColor = true;
			// 
			// AboutBox
			// 
			this.AcceptButton = this.button_Close;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(665, 650);
			this.Controls.Add(this.button_Close);
			this.Controls.Add(this.textBox_Description);
			this.Controls.Add(this.label_Version);
			this.Controls.Add(this.label_Link);
			this.Controls.Add(this.label_Author);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.Padding = new System.Windows.Forms.Padding(12, 14, 12, 14);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Info";
			this.Shown += new System.EventHandler(this.AboutBox_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_Author;
		private System.Windows.Forms.Label label_Link;
		private System.Windows.Forms.Label label_Version;
		private System.Windows.Forms.TextBox textBox_Description;
		private System.Windows.Forms.Button button_Close;
	}
}
