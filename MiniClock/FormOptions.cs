using System;
using System.Windows.Forms;

namespace MiniClock {
	public partial class FormOptions : Form {
		public FormOptions() {
			InitializeComponent();
		}

		private void FormOptions_Load(object sender, EventArgs e) {
			ECheckBox_KeepOnTop.Checked = this.Owner.TopMost;
			ETrackBar_Opacity.Value = (int)(this.Owner.Opacity * 100);
			ECheckBox_HideBorder.Checked = (this.Owner.FormBorderStyle == FormBorderStyle.None) ? true : false;
		}

		private void ECheckBox_KeepOnTop_CheckedChanged(object sender, EventArgs e) {
			this.Owner.TopMost = ((CheckBox)sender).Checked;
		}

		private void ECheckBox_HideBorder_CheckedChanged(object sender, EventArgs e) {
			this.Owner.FormBorderStyle = (((CheckBox)sender).Checked) ? FormBorderStyle.None : FormBorderStyle.FixedToolWindow;
		}

		private void ETrackBar_Opacity_MouseUp(object sender, MouseEventArgs e) {
			ETrackBar_Opacity_ValueChange(sender);
		}
		private void ETrackBar_Opacity_KeyUp(object sender, KeyEventArgs e) {
			ETrackBar_Opacity_ValueChange(sender);
		}
		private void ETrackBar_Opacity_ValueChange(object sender) {
			this.Owner.Opacity = (((TrackBar)sender).Value / 100.0);
		}
	}
}
