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
			this.components = new System.ComponentModel.Container();
			this.ELabel_Time = new System.Windows.Forms.Label();
			this.ETimer_Main = new System.Windows.Forms.Timer(this.components);
			this.ELabel_Date = new System.Windows.Forms.Label();
			this.ETabControl_Main = new System.Windows.Forms.TabControl();
			this.ETabControl_Main_TabClock = new System.Windows.Forms.TabPage();
			this.ETabControl_Main_TabTimer = new System.Windows.Forms.TabPage();
			this.EButton_TimerReset = new System.Windows.Forms.Button();
			this.EButton_TimerToggle = new System.Windows.Forms.Button();
			this.ELabel_Timer = new System.Windows.Forms.Label();
			this.ETimer_Timer = new System.Windows.Forms.Timer(this.components);
			this.ETabControl_Main_TabOptions = new System.Windows.Forms.TabPage();
			this.ECheckBox_KeepOnTop = new System.Windows.Forms.CheckBox();
			this.ETabControl_Main.SuspendLayout();
			this.ETabControl_Main_TabClock.SuspendLayout();
			this.ETabControl_Main_TabTimer.SuspendLayout();
			this.ETabControl_Main_TabOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// ELabel_Time
			// 
			this.ELabel_Time.AutoSize = true;
			this.ELabel_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ELabel_Time.Location = new System.Drawing.Point(3, 3);
			this.ELabel_Time.Name = "ELabel_Time";
			this.ELabel_Time.Size = new System.Drawing.Size(96, 25);
			this.ELabel_Time.TabIndex = 0;
			this.ELabel_Time.Text = "00:00:00";
			// 
			// ETimer_Main
			// 
			this.ETimer_Main.Enabled = true;
			this.ETimer_Main.Interval = 1000;
			this.ETimer_Main.Tick += new System.EventHandler(this.ETimer_Main_Tick);
			// 
			// ELabel_Date
			// 
			this.ELabel_Date.AutoSize = true;
			this.ELabel_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ELabel_Date.Location = new System.Drawing.Point(108, 3);
			this.ELabel_Date.Name = "ELabel_Date";
			this.ELabel_Date.Size = new System.Drawing.Size(120, 25);
			this.ELabel_Date.TabIndex = 1;
			this.ELabel_Date.Text = "00/00/0000";
			// 
			// ETabControl_Main
			// 
			this.ETabControl_Main.Controls.Add(this.ETabControl_Main_TabClock);
			this.ETabControl_Main.Controls.Add(this.ETabControl_Main_TabTimer);
			this.ETabControl_Main.Controls.Add(this.ETabControl_Main_TabOptions);
			this.ETabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ETabControl_Main.Location = new System.Drawing.Point(0, 0);
			this.ETabControl_Main.Name = "ETabControl_Main";
			this.ETabControl_Main.SelectedIndex = 0;
			this.ETabControl_Main.Size = new System.Drawing.Size(242, 57);
			this.ETabControl_Main.TabIndex = 2;
			// 
			// ETabControl_Main_TabClock
			// 
			this.ETabControl_Main_TabClock.Controls.Add(this.ELabel_Time);
			this.ETabControl_Main_TabClock.Controls.Add(this.ELabel_Date);
			this.ETabControl_Main_TabClock.Location = new System.Drawing.Point(4, 22);
			this.ETabControl_Main_TabClock.Name = "ETabControl_Main_TabClock";
			this.ETabControl_Main_TabClock.Padding = new System.Windows.Forms.Padding(3);
			this.ETabControl_Main_TabClock.Size = new System.Drawing.Size(234, 31);
			this.ETabControl_Main_TabClock.TabIndex = 0;
			this.ETabControl_Main_TabClock.Text = "Clock";
			this.ETabControl_Main_TabClock.UseVisualStyleBackColor = true;
			// 
			// ETabControl_Main_TabTimer
			// 
			this.ETabControl_Main_TabTimer.Controls.Add(this.EButton_TimerReset);
			this.ETabControl_Main_TabTimer.Controls.Add(this.EButton_TimerToggle);
			this.ETabControl_Main_TabTimer.Controls.Add(this.ELabel_Timer);
			this.ETabControl_Main_TabTimer.Location = new System.Drawing.Point(4, 22);
			this.ETabControl_Main_TabTimer.Name = "ETabControl_Main_TabTimer";
			this.ETabControl_Main_TabTimer.Size = new System.Drawing.Size(234, 31);
			this.ETabControl_Main_TabTimer.TabIndex = 1;
			this.ETabControl_Main_TabTimer.Text = "Timer";
			this.ETabControl_Main_TabTimer.UseVisualStyleBackColor = true;
			// 
			// EButton_TimerReset
			// 
			this.EButton_TimerReset.Location = new System.Drawing.Point(169, 3);
			this.EButton_TimerReset.Name = "EButton_TimerReset";
			this.EButton_TimerReset.Size = new System.Drawing.Size(57, 23);
			this.EButton_TimerReset.TabIndex = 4;
			this.EButton_TimerReset.Text = "Reset";
			this.EButton_TimerReset.UseVisualStyleBackColor = true;
			this.EButton_TimerReset.Click += new System.EventHandler(this.EButton_TimerReset_Click);
			// 
			// EButton_TimerToggle
			// 
			this.EButton_TimerToggle.Location = new System.Drawing.Point(105, 3);
			this.EButton_TimerToggle.Name = "EButton_TimerToggle";
			this.EButton_TimerToggle.Size = new System.Drawing.Size(58, 23);
			this.EButton_TimerToggle.TabIndex = 3;
			this.EButton_TimerToggle.Text = "Start";
			this.EButton_TimerToggle.UseVisualStyleBackColor = true;
			this.EButton_TimerToggle.Click += new System.EventHandler(this.EButton_TimerToggle_Click);
			// 
			// ELabel_Timer
			// 
			this.ELabel_Timer.AutoSize = true;
			this.ELabel_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ELabel_Timer.Location = new System.Drawing.Point(3, 3);
			this.ELabel_Timer.Name = "ELabel_Timer";
			this.ELabel_Timer.Size = new System.Drawing.Size(96, 25);
			this.ELabel_Timer.TabIndex = 2;
			this.ELabel_Timer.Text = "00:00:00";
			// 
			// ETimer_Timer
			// 
			this.ETimer_Timer.Interval = 1000;
			this.ETimer_Timer.Tick += new System.EventHandler(this.ETimer_Timer_Tick);
			// 
			// ETabControl_Main_TabOptions
			// 
			this.ETabControl_Main_TabOptions.Controls.Add(this.ECheckBox_KeepOnTop);
			this.ETabControl_Main_TabOptions.Location = new System.Drawing.Point(4, 22);
			this.ETabControl_Main_TabOptions.Name = "ETabControl_Main_TabOptions";
			this.ETabControl_Main_TabOptions.Padding = new System.Windows.Forms.Padding(3);
			this.ETabControl_Main_TabOptions.Size = new System.Drawing.Size(234, 31);
			this.ETabControl_Main_TabOptions.TabIndex = 2;
			this.ETabControl_Main_TabOptions.Text = "Options";
			this.ETabControl_Main_TabOptions.UseVisualStyleBackColor = true;
			// 
			// ECheckBox_KeepOnTop
			// 
			this.ECheckBox_KeepOnTop.AutoSize = true;
			this.ECheckBox_KeepOnTop.Checked = true;
			this.ECheckBox_KeepOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ECheckBox_KeepOnTop.Location = new System.Drawing.Point(8, 6);
			this.ECheckBox_KeepOnTop.Name = "ECheckBox_KeepOnTop";
			this.ECheckBox_KeepOnTop.Size = new System.Drawing.Size(84, 17);
			this.ECheckBox_KeepOnTop.TabIndex = 0;
			this.ECheckBox_KeepOnTop.Text = "Keep on top";
			this.ECheckBox_KeepOnTop.UseVisualStyleBackColor = true;
			this.ECheckBox_KeepOnTop.CheckedChanged += new System.EventHandler(this.ECheckBox_KeepOnTop_CheckedChanged);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(242, 57);
			this.Controls.Add(this.ETabControl_Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormMain";
			this.Text = "MiniClock";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.ETabControl_Main.ResumeLayout(false);
			this.ETabControl_Main_TabClock.ResumeLayout(false);
			this.ETabControl_Main_TabClock.PerformLayout();
			this.ETabControl_Main_TabTimer.ResumeLayout(false);
			this.ETabControl_Main_TabTimer.PerformLayout();
			this.ETabControl_Main_TabOptions.ResumeLayout(false);
			this.ETabControl_Main_TabOptions.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label ELabel_Time;
		private System.Windows.Forms.Timer ETimer_Main;
		private System.Windows.Forms.Label ELabel_Date;
		private System.Windows.Forms.TabControl ETabControl_Main;
		private System.Windows.Forms.TabPage ETabControl_Main_TabClock;
		private System.Windows.Forms.TabPage ETabControl_Main_TabTimer;
		private System.Windows.Forms.Timer ETimer_Timer;
		private System.Windows.Forms.Button EButton_TimerReset;
		private System.Windows.Forms.Button EButton_TimerToggle;
		private System.Windows.Forms.Label ELabel_Timer;
		private System.Windows.Forms.TabPage ETabControl_Main_TabOptions;
		private System.Windows.Forms.CheckBox ECheckBox_KeepOnTop;
	}
}

