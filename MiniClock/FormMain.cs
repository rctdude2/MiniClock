using System;
using System.Windows.Forms;

namespace MiniClock {
    public partial class FormMain : Form {
        private ToolTip Tooltip;

        private System.Timers.Timer Timer_Clock;
        private System.Timers.Timer Timer_Stopwatch;
        private System.Timers.Timer Timer_Timer;

        private TimeSpan TimeSpan_Stopwatch;
        private TimeSpan TimeSpan_Timer;

        #region Main form window, init
        public FormMain() {
            InitializeComponent();

            this.Tooltip = new ToolTip();

            this.Timer_Clock = new System.Timers.Timer {
                Interval = (1000 * 1),
                SynchronizingObject = ELabel_DateTime
            };
            this.Timer_Clock.Elapsed += this.Update_ELabel_DateTime;

            this.Timer_Stopwatch = new System.Timers.Timer {
                Interval = (1000 * 1),
                SynchronizingObject = ELabel_Stopwatch
            };
            this.Timer_Stopwatch.Elapsed += this.Timer_Stopwatch_Tick;
            this.TimeSpan_Stopwatch = new TimeSpan();

            this.Timer_Timer = new System.Timers.Timer {
                Interval = (1000 * 1),
                SynchronizingObject = ELabel_Timer
            };
            this.Timer_Timer.Elapsed += this.Timer_Timer_Tick;
            this.TimeSpan_Timer = new TimeSpan();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            this.Update_ELabel_DateTime(sender, e);
            this.Timer_Clock.Start();

            this.TopMost = Properties.Settings.Default.U_KeepOnTop;
            this.FormBorderStyle = (Properties.Settings.Default.U_HideBorder ? FormBorderStyle.None : FormBorderStyle.FixedDialog);
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
        #endregion

        #region Clock
        private void Update_ELabel_DateTime(object sender, EventArgs e) {
            ELabel_DateTime.Text = DateTime.Now.ToString();
        }
        #endregion

        #region Stopwatch
        private void Timer_Stopwatch_Tick(object sender, EventArgs e) {
            this.TimeSpan_Stopwatch = this.TimeSpan_Stopwatch.Add(TimeSpan.FromSeconds(1));
            ELabel_Stopwatch.Text = this.TimeSpan_Stopwatch.ToString();
        }

        private void EButton_StopwatchToggle_Click(object sender, EventArgs e) {
            if (!this.Timer_Stopwatch.Enabled) {
                this.Timer_Stopwatch.Start();
                EButton_StopwatchToggle.Text = "Stop";
            }
            else {
                this.Timer_Stopwatch.Stop();
                EButton_StopwatchToggle.Text = "Start";
            }
        }

        private void EButton_StopwatchReset_Click(object sender, EventArgs e) {
            if (this.Timer_Stopwatch.Enabled) {
                this.Timer_Stopwatch.Stop();
                EButton_StopwatchToggle.Text = "Start";
                this.Tooltip.Show("Click again to reset stopwatch.", this, EButton_StopwatchReset.Location + EButton_StopwatchReset.Size, 3000);
            }
            else {
                this.TimeSpan_Stopwatch = TimeSpan.FromTicks(0);
                ELabel_Stopwatch.Text = "00:00:00";
            }
        }
        #endregion

        #region Timer
        private bool TimerSmallerFont = false;

        private void Timer_Timer_Tick(object sender, EventArgs e) {
            this.TimeSpan_Timer = this.TimeSpan_Timer.Subtract(TimeSpan.FromSeconds(1));
            ELabel_Timer.Text = this.TimeSpan_Timer.ToString();
            if (this.TimerSmallerFont && this.TimeSpan_Timer.TotalDays < 1) {
                ELabel_Timer.Font = new System.Drawing.Font(ELabel_Timer.Font.FontFamily.Name, 16.0F);
                this.TimerSmallerFont = false;
            }
            if (this.TimeSpan_Timer.TotalSeconds <= 0) {
                this.Timer_Timer.Stop();
                EButton_TimerToggle.Text = "Start";
                MessageBox.Show("Timer is up!", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void EButton_TimerToggle_Click(object sender, EventArgs e) {
            if (!this.Timer_Timer.Enabled && this.TimeSpan_Timer.TotalSeconds > 0) {
                this.Timer_Timer.Start();
                EButton_TimerToggle.Text = "Stop";
            }
            else if (this.Timer_Timer.Enabled) {
                this.Timer_Timer.Stop();
                EButton_TimerToggle.Text = "Start";
            }
        }

        private void EButton_TimerSet_Click(object sender, EventArgs e) {
            if (this.Timer_Timer.Enabled) {
                this.Tooltip.Show("Stop the timer first.", this, EButton_TimerSet.Location + EButton_TimerSet.Size, 3000);
                return;
            }
            this.TopMost = false;
            string time = Microsoft.VisualBasic.Interaction.InputBox("Enter a time (hh:mm:ss):", DefaultResponse: "00:00:00");
            this.TopMost = Properties.Settings.Default.U_KeepOnTop;
            bool validtime = TimeSpan.TryParse(time, out TimeSpan result);
            if (validtime) {
                this.TimeSpan_Timer = TimeSpan.FromSeconds(0);
                this.TimeSpan_Timer = this.TimeSpan_Timer.Add(result);
                ELabel_Timer.Text = this.TimeSpan_Timer.ToString();
                if (this.TimeSpan_Timer.TotalDays >= 1) {
                    ELabel_Timer.Font = new System.Drawing.Font(ELabel_Timer.Font.FontFamily.Name, 14.0F);
                    this.TimerSmallerFont = true;
                }
            }
            else {
                MessageBox.Show($"\"{time}\" is not a valid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EButton_TimerReset_Click(object sender, EventArgs e) {
            if (this.Timer_Timer.Enabled) {
                this.Timer_Timer.Stop();
                EButton_TimerToggle.Text = "Start";
                this.Tooltip.Show("Click again to reset timer.", this, EButton_TimerReset.Location + EButton_TimerReset.Size, 3000);
            }
            else {
                this.TimeSpan_Timer = TimeSpan.FromTicks(0);
                ELabel_Timer.Text = "00:00:00";
            }
        }
        #endregion

        #region Settings
        private void EButton_Exit_Click(object sender, EventArgs e) {
            if (this.Timer_Stopwatch.Enabled || this.Timer_Timer.Enabled) {
                DialogResult confirm = MessageBox.Show($"You have a timer running.{Environment.NewLine}Are you sure you want to exit?",
                                                       "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (confirm == DialogResult.No) { return; }
            }

            Application.Exit();
        }

        private void EButton_Settings_Click(object sender, EventArgs e) {
            FormSettings form = new FormSettings();
            form.Show(this);
        }
        #endregion
    }
}
