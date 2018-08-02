namespace MiniClock {
	partial class FormMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.ETabControl_Main = new System.Windows.Forms.TabControl();
            this.ETabControl_Main_PageClock = new System.Windows.Forms.TabPage();
            this.ELabel_DateTime = new System.Windows.Forms.Label();
            this.ETabControl_Main_PageStopwatch = new System.Windows.Forms.TabPage();
            this.ETableLayoutPanel_Stopwatch = new System.Windows.Forms.TableLayoutPanel();
            this.EButton_StopwatchToggle = new System.Windows.Forms.Button();
            this.EButton_StopwatchReset = new System.Windows.Forms.Button();
            this.ELabel_Stopwatch = new System.Windows.Forms.Label();
            this.ETabControl_Main_PageTimer = new System.Windows.Forms.TabPage();
            this.ETableLayoutPanel_Timer = new System.Windows.Forms.TableLayoutPanel();
            this.ELabel_Timer = new System.Windows.Forms.Label();
            this.EButton_TimerToggle = new System.Windows.Forms.Button();
            this.ETabControl_Main_PageSettings = new System.Windows.Forms.TabPage();
            this.EButton_Settings = new System.Windows.Forms.Button();
            this.EButton_Exit = new System.Windows.Forms.Button();
            this.EButton_TimerSet = new System.Windows.Forms.Button();
            this.EButton_TimerReset = new System.Windows.Forms.Button();
            this.ETabControl_Main.SuspendLayout();
            this.ETabControl_Main_PageClock.SuspendLayout();
            this.ETabControl_Main_PageStopwatch.SuspendLayout();
            this.ETableLayoutPanel_Stopwatch.SuspendLayout();
            this.ETabControl_Main_PageTimer.SuspendLayout();
            this.ETableLayoutPanel_Timer.SuspendLayout();
            this.ETabControl_Main_PageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ETabControl_Main
            // 
            this.ETabControl_Main.Controls.Add(this.ETabControl_Main_PageClock);
            this.ETabControl_Main.Controls.Add(this.ETabControl_Main_PageStopwatch);
            this.ETabControl_Main.Controls.Add(this.ETabControl_Main_PageTimer);
            this.ETabControl_Main.Controls.Add(this.ETabControl_Main_PageSettings);
            this.ETabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ETabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.ETabControl_Main.Name = "ETabControl_Main";
            this.ETabControl_Main.SelectedIndex = 0;
            this.ETabControl_Main.Size = new System.Drawing.Size(284, 61);
            this.ETabControl_Main.TabIndex = 0;
            // 
            // ETabControl_Main_PageClock
            // 
            this.ETabControl_Main_PageClock.Controls.Add(this.ELabel_DateTime);
            this.ETabControl_Main_PageClock.Location = new System.Drawing.Point(4, 22);
            this.ETabControl_Main_PageClock.Name = "ETabControl_Main_PageClock";
            this.ETabControl_Main_PageClock.Padding = new System.Windows.Forms.Padding(3);
            this.ETabControl_Main_PageClock.Size = new System.Drawing.Size(276, 35);
            this.ETabControl_Main_PageClock.TabIndex = 0;
            this.ETabControl_Main_PageClock.Text = "Clock";
            this.ETabControl_Main_PageClock.UseVisualStyleBackColor = true;
            // 
            // ELabel_DateTime
            // 
            this.ELabel_DateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ELabel_DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELabel_DateTime.Location = new System.Drawing.Point(3, 3);
            this.ELabel_DateTime.Name = "ELabel_DateTime";
            this.ELabel_DateTime.Size = new System.Drawing.Size(270, 29);
            this.ELabel_DateTime.TabIndex = 0;
            this.ELabel_DateTime.Text = "ELabel_DateTime";
            this.ELabel_DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ETabControl_Main_PageStopwatch
            // 
            this.ETabControl_Main_PageStopwatch.Controls.Add(this.ETableLayoutPanel_Stopwatch);
            this.ETabControl_Main_PageStopwatch.Location = new System.Drawing.Point(4, 22);
            this.ETabControl_Main_PageStopwatch.Name = "ETabControl_Main_PageStopwatch";
            this.ETabControl_Main_PageStopwatch.Size = new System.Drawing.Size(276, 35);
            this.ETabControl_Main_PageStopwatch.TabIndex = 2;
            this.ETabControl_Main_PageStopwatch.Text = "Stopwatch";
            this.ETabControl_Main_PageStopwatch.UseVisualStyleBackColor = true;
            // 
            // ETableLayoutPanel_Stopwatch
            // 
            this.ETableLayoutPanel_Stopwatch.ColumnCount = 3;
            this.ETableLayoutPanel_Stopwatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ETableLayoutPanel_Stopwatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ETableLayoutPanel_Stopwatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ETableLayoutPanel_Stopwatch.Controls.Add(this.EButton_StopwatchToggle, 1, 0);
            this.ETableLayoutPanel_Stopwatch.Controls.Add(this.EButton_StopwatchReset, 2, 0);
            this.ETableLayoutPanel_Stopwatch.Controls.Add(this.ELabel_Stopwatch, 0, 0);
            this.ETableLayoutPanel_Stopwatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ETableLayoutPanel_Stopwatch.Location = new System.Drawing.Point(0, 0);
            this.ETableLayoutPanel_Stopwatch.Name = "ETableLayoutPanel_Stopwatch";
            this.ETableLayoutPanel_Stopwatch.RowCount = 1;
            this.ETableLayoutPanel_Stopwatch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ETableLayoutPanel_Stopwatch.Size = new System.Drawing.Size(276, 35);
            this.ETableLayoutPanel_Stopwatch.TabIndex = 1;
            // 
            // EButton_StopwatchToggle
            // 
            this.EButton_StopwatchToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EButton_StopwatchToggle.Location = new System.Drawing.Point(168, 3);
            this.EButton_StopwatchToggle.Name = "EButton_StopwatchToggle";
            this.EButton_StopwatchToggle.Size = new System.Drawing.Size(49, 29);
            this.EButton_StopwatchToggle.TabIndex = 1;
            this.EButton_StopwatchToggle.Text = "Start";
            this.EButton_StopwatchToggle.UseVisualStyleBackColor = true;
            this.EButton_StopwatchToggle.Click += new System.EventHandler(this.EButton_StopwatchToggle_Click);
            // 
            // EButton_StopwatchReset
            // 
            this.EButton_StopwatchReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EButton_StopwatchReset.Location = new System.Drawing.Point(223, 3);
            this.EButton_StopwatchReset.Name = "EButton_StopwatchReset";
            this.EButton_StopwatchReset.Size = new System.Drawing.Size(50, 29);
            this.EButton_StopwatchReset.TabIndex = 2;
            this.EButton_StopwatchReset.Text = "Reset";
            this.EButton_StopwatchReset.UseVisualStyleBackColor = true;
            this.EButton_StopwatchReset.Click += new System.EventHandler(this.EButton_StopwatchReset_Click);
            // 
            // ELabel_Stopwatch
            // 
            this.ELabel_Stopwatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ELabel_Stopwatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELabel_Stopwatch.Location = new System.Drawing.Point(3, 0);
            this.ELabel_Stopwatch.Name = "ELabel_Stopwatch";
            this.ELabel_Stopwatch.Size = new System.Drawing.Size(159, 35);
            this.ELabel_Stopwatch.TabIndex = 0;
            this.ELabel_Stopwatch.Text = "00:00:00";
            this.ELabel_Stopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ETabControl_Main_PageTimer
            // 
            this.ETabControl_Main_PageTimer.Controls.Add(this.ETableLayoutPanel_Timer);
            this.ETabControl_Main_PageTimer.Location = new System.Drawing.Point(4, 22);
            this.ETabControl_Main_PageTimer.Name = "ETabControl_Main_PageTimer";
            this.ETabControl_Main_PageTimer.Size = new System.Drawing.Size(276, 35);
            this.ETabControl_Main_PageTimer.TabIndex = 3;
            this.ETabControl_Main_PageTimer.Text = "Timer";
            this.ETabControl_Main_PageTimer.UseVisualStyleBackColor = true;
            // 
            // ETableLayoutPanel_Timer
            // 
            this.ETableLayoutPanel_Timer.ColumnCount = 4;
            this.ETableLayoutPanel_Timer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ETableLayoutPanel_Timer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ETableLayoutPanel_Timer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ETableLayoutPanel_Timer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ETableLayoutPanel_Timer.Controls.Add(this.ELabel_Timer, 0, 0);
            this.ETableLayoutPanel_Timer.Controls.Add(this.EButton_TimerToggle, 1, 0);
            this.ETableLayoutPanel_Timer.Controls.Add(this.EButton_TimerSet, 2, 0);
            this.ETableLayoutPanel_Timer.Controls.Add(this.EButton_TimerReset, 3, 0);
            this.ETableLayoutPanel_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ETableLayoutPanel_Timer.Location = new System.Drawing.Point(0, 0);
            this.ETableLayoutPanel_Timer.Name = "ETableLayoutPanel_Timer";
            this.ETableLayoutPanel_Timer.RowCount = 1;
            this.ETableLayoutPanel_Timer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ETableLayoutPanel_Timer.Size = new System.Drawing.Size(276, 35);
            this.ETableLayoutPanel_Timer.TabIndex = 0;
            // 
            // ELabel_Timer
            // 
            this.ELabel_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ELabel_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELabel_Timer.Location = new System.Drawing.Point(3, 0);
            this.ELabel_Timer.Name = "ELabel_Timer";
            this.ELabel_Timer.Size = new System.Drawing.Size(104, 35);
            this.ELabel_Timer.TabIndex = 0;
            this.ELabel_Timer.Text = "00:00:00";
            this.ELabel_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EButton_TimerToggle
            // 
            this.EButton_TimerToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EButton_TimerToggle.Location = new System.Drawing.Point(113, 3);
            this.EButton_TimerToggle.Name = "EButton_TimerToggle";
            this.EButton_TimerToggle.Size = new System.Drawing.Size(49, 29);
            this.EButton_TimerToggle.TabIndex = 1;
            this.EButton_TimerToggle.Text = "Start";
            this.EButton_TimerToggle.UseVisualStyleBackColor = true;
            this.EButton_TimerToggle.Click += new System.EventHandler(this.EButton_TimerToggle_Click);
            // 
            // ETabControl_Main_PageSettings
            // 
            this.ETabControl_Main_PageSettings.Controls.Add(this.EButton_Settings);
            this.ETabControl_Main_PageSettings.Controls.Add(this.EButton_Exit);
            this.ETabControl_Main_PageSettings.Location = new System.Drawing.Point(4, 22);
            this.ETabControl_Main_PageSettings.Name = "ETabControl_Main_PageSettings";
            this.ETabControl_Main_PageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.ETabControl_Main_PageSettings.Size = new System.Drawing.Size(276, 35);
            this.ETabControl_Main_PageSettings.TabIndex = 1;
            this.ETabControl_Main_PageSettings.Text = "Settings";
            this.ETabControl_Main_PageSettings.UseVisualStyleBackColor = true;
            // 
            // EButton_Settings
            // 
            this.EButton_Settings.Location = new System.Drawing.Point(195, 6);
            this.EButton_Settings.Name = "EButton_Settings";
            this.EButton_Settings.Size = new System.Drawing.Size(75, 23);
            this.EButton_Settings.TabIndex = 1;
            this.EButton_Settings.Text = "Settings";
            this.EButton_Settings.UseVisualStyleBackColor = true;
            this.EButton_Settings.Click += new System.EventHandler(this.EButton_Settings_Click);
            // 
            // EButton_Exit
            // 
            this.EButton_Exit.Location = new System.Drawing.Point(6, 6);
            this.EButton_Exit.Name = "EButton_Exit";
            this.EButton_Exit.Size = new System.Drawing.Size(75, 23);
            this.EButton_Exit.TabIndex = 0;
            this.EButton_Exit.Text = "Exit";
            this.EButton_Exit.UseVisualStyleBackColor = true;
            this.EButton_Exit.Click += new System.EventHandler(this.EButton_Exit_Click);
            // 
            // EButton_TimerSet
            // 
            this.EButton_TimerSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EButton_TimerSet.Location = new System.Drawing.Point(168, 3);
            this.EButton_TimerSet.Name = "EButton_TimerSet";
            this.EButton_TimerSet.Size = new System.Drawing.Size(49, 29);
            this.EButton_TimerSet.TabIndex = 2;
            this.EButton_TimerSet.Text = "Set";
            this.EButton_TimerSet.UseVisualStyleBackColor = true;
            this.EButton_TimerSet.Click += new System.EventHandler(this.EButton_TimerSet_Click);
            // 
            // EButton_TimerReset
            // 
            this.EButton_TimerReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EButton_TimerReset.Location = new System.Drawing.Point(223, 3);
            this.EButton_TimerReset.Name = "EButton_TimerReset";
            this.EButton_TimerReset.Size = new System.Drawing.Size(50, 29);
            this.EButton_TimerReset.TabIndex = 3;
            this.EButton_TimerReset.Text = "Reset";
            this.EButton_TimerReset.UseVisualStyleBackColor = true;
            this.EButton_TimerReset.Click += new System.EventHandler(this.EButton_TimerReset_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.ETabControl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "MiniClock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ETabControl_Main.ResumeLayout(false);
            this.ETabControl_Main_PageClock.ResumeLayout(false);
            this.ETabControl_Main_PageStopwatch.ResumeLayout(false);
            this.ETableLayoutPanel_Stopwatch.ResumeLayout(false);
            this.ETabControl_Main_PageTimer.ResumeLayout(false);
            this.ETableLayoutPanel_Timer.ResumeLayout(false);
            this.ETabControl_Main_PageSettings.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabControl ETabControl_Main;
        private System.Windows.Forms.TabPage ETabControl_Main_PageClock;
        private System.Windows.Forms.TabPage ETabControl_Main_PageSettings;
        private System.Windows.Forms.Label ELabel_DateTime;
        private System.Windows.Forms.Button EButton_Exit;
        private System.Windows.Forms.Button EButton_Settings;
        private System.Windows.Forms.TabPage ETabControl_Main_PageStopwatch;
        private System.Windows.Forms.Label ELabel_Stopwatch;
        private System.Windows.Forms.TableLayoutPanel ETableLayoutPanel_Stopwatch;
        private System.Windows.Forms.Button EButton_StopwatchToggle;
        private System.Windows.Forms.Button EButton_StopwatchReset;
        private System.Windows.Forms.TabPage ETabControl_Main_PageTimer;
        private System.Windows.Forms.TableLayoutPanel ETableLayoutPanel_Timer;
        private System.Windows.Forms.Label ELabel_Timer;
        private System.Windows.Forms.Button EButton_TimerToggle;
        private System.Windows.Forms.Button EButton_TimerSet;
        private System.Windows.Forms.Button EButton_TimerReset;
    }
}

