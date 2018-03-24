using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualDeskSwitch
{
	public class RoundButton : Button
	{
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			GraphicsPath grPath = new GraphicsPath();
			grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
			this.Region = new System.Drawing.Region(grPath);
			base.OnPaint(e);
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// RoundButton
			// 
			this.FlatAppearance.BorderSize = 0;
			this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ResumeLayout(false);

		}
	}
}
