using System;
using System.Windows.Forms;

namespace MiniClock {
    public partial class FormSettings : Form {
        public FormSettings() {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e) {
            ECheckBox_KeepOnTop.Checked = Properties.Settings.Default.U_KeepOnTop;
            ECheckBox_HideBorder.Checked = Properties.Settings.Default.U_HideBorder;
        }

        private void ECheckBox_KeepOnTop_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            this.Owner.TopMost = Properties.Settings.Default.U_KeepOnTop = checkBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void ECheckBox_HideBorder_CheckedChanged(object sender, EventArgs e) {
            CheckBox checkBox = (CheckBox)sender;
            Properties.Settings.Default.U_HideBorder = checkBox.Checked;
            Properties.Settings.Default.Save();
            this.Owner.FormBorderStyle = (Properties.Settings.Default.U_HideBorder ? FormBorderStyle.None : FormBorderStyle.FixedDialog);
        }
    }
}
