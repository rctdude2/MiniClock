using System;
using System.Windows.Forms;

namespace MiniClock {
	public partial class FormMain : Form {
		private TimeSpan timer;
		private bool timerRunning;

		public FormMain() {
			InitializeComponent();
			timer = new TimeSpan();
			timerRunning = false;
		}

		// Allow dragging using client area
		// https://stackoverflow.com/a/3409864
		protected override void WndProc(ref Message m) {
			switch (m.Msg) {
				case 0x84:
					base.WndProc(ref m);
					if ((int)m.Result == 0x1) {
						m.Result = (IntPtr)0x2;
					}
					return;
			}

			base.WndProc(ref m);
		}

		private void FormMain_Load(object sender, EventArgs e) {
			Update_ELabel_Time();
			Update_ELabel_Date();
		}
		
		private void ETimer_Main_Tick(object sender, EventArgs e) {
			Update_ELabel_Time();
			Update_ELabel_Date();
		}

		private void ETimer_Timer_Tick(object sender, EventArgs e) {
			timer = timer.Add(TimeSpan.FromSeconds(1));
			ELabel_Timer.Text = timer.ToString();
		}

		private void Update_ELabel_Time() {
			ELabel_Time.Text = DateTime.Now.ToLongTimeString();
		}

		private void Update_ELabel_Date() {
			ELabel_Date.Text = DateTime.Now.ToShortDateString();
		}

		private void EButton_TimerToggle_Click(object sender, EventArgs e) {
			if (!timerRunning) {
				ETimer_Timer.Start();
				timerRunning = true;
				((Button)sender).Text = "Stop";
			}
			else {
				ETimer_Timer.Stop();
				timerRunning = false;
				((Button)sender).Text = "Start";
			}
		}

		private void EButton_TimerReset_Click(object sender, EventArgs e) {
			if (!timerRunning && timer.TotalSeconds == 0) {
				ELabel_Timer.Text = "00:00:00";
			}

			if (timerRunning) {
				ETimer_Timer.Stop();
				timerRunning = false;
				EButton_TimerToggle.Text = "Start";
			}
			if (timer.TotalSeconds > 0) {
				timer = timer.Subtract(timer);
			}	
		}

		private void EButton_Options_Click(object sender, EventArgs e) {
			FormOptions opt = new FormOptions();
			opt.Show(this);
		}

		private void EButton_Exit_Click(object sender, EventArgs e) {
			if (timerRunning) {
				DialogResult exit = MessageBox.Show($"You have a timer running.{Environment.NewLine}Are you sure you wish to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (exit == DialogResult.Yes) {
					Application.Exit();
				}
			}
			else {
				Application.Exit();
			}
		}
	}
}
