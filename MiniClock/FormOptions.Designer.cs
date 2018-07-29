namespace MiniClock {
	partial class FormOptions {
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
			this.ECheckBox_KeepOnTop = new System.Windows.Forms.CheckBox();
			this.ETrackBar_Opacity = new System.Windows.Forms.TrackBar();
			this.ELabel_Opacity = new System.Windows.Forms.Label();
			this.ECheckBox_HideBorder = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.ETrackBar_Opacity)).BeginInit();
			this.SuspendLayout();
			// 
			// ECheckBox_KeepOnTop
			// 
			this.ECheckBox_KeepOnTop.AutoSize = true;
			this.ECheckBox_KeepOnTop.Checked = true;
			this.ECheckBox_KeepOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ECheckBox_KeepOnTop.Location = new System.Drawing.Point(12, 12);
			this.ECheckBox_KeepOnTop.Name = "ECheckBox_KeepOnTop";
			this.ECheckBox_KeepOnTop.Size = new System.Drawing.Size(84, 17);
			this.ECheckBox_KeepOnTop.TabIndex = 0;
			this.ECheckBox_KeepOnTop.Text = "Keep on top";
			this.ECheckBox_KeepOnTop.UseVisualStyleBackColor = true;
			this.ECheckBox_KeepOnTop.CheckedChanged += new System.EventHandler(this.ECheckBox_KeepOnTop_CheckedChanged);
			// 
			// ETrackBar_Opacity
			// 
			this.ETrackBar_Opacity.AutoSize = false;
			this.ETrackBar_Opacity.LargeChange = 10;
			this.ETrackBar_Opacity.Location = new System.Drawing.Point(64, 35);
			this.ETrackBar_Opacity.Maximum = 100;
			this.ETrackBar_Opacity.Minimum = 10;
			this.ETrackBar_Opacity.Name = "ETrackBar_Opacity";
			this.ETrackBar_Opacity.Size = new System.Drawing.Size(208, 30);
			this.ETrackBar_Opacity.TabIndex = 1;
			this.ETrackBar_Opacity.TickFrequency = 10;
			this.ETrackBar_Opacity.Value = 100;
			this.ETrackBar_Opacity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ETrackBar_Opacity_KeyUp);
			this.ETrackBar_Opacity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ETrackBar_Opacity_MouseUp);
			// 
			// ELabel_Opacity
			// 
			this.ELabel_Opacity.AutoSize = true;
			this.ELabel_Opacity.Location = new System.Drawing.Point(12, 35);
			this.ELabel_Opacity.Name = "ELabel_Opacity";
			this.ELabel_Opacity.Size = new System.Drawing.Size(46, 13);
			this.ELabel_Opacity.TabIndex = 2;
			this.ELabel_Opacity.Text = "Opacity:";
			// 
			// ECheckBox_HideBorder
			// 
			this.ECheckBox_HideBorder.AutoSize = true;
			this.ECheckBox_HideBorder.Location = new System.Drawing.Point(102, 12);
			this.ECheckBox_HideBorder.Name = "ECheckBox_HideBorder";
			this.ECheckBox_HideBorder.Size = new System.Drawing.Size(120, 17);
			this.ECheckBox_HideBorder.TabIndex = 3;
			this.ECheckBox_HideBorder.Text = "Hide window border";
			this.ECheckBox_HideBorder.UseVisualStyleBackColor = true;
			this.ECheckBox_HideBorder.CheckedChanged += new System.EventHandler(this.ECheckBox_HideBorder_CheckedChanged);
			// 
			// FormOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 74);
			this.Controls.Add(this.ECheckBox_HideBorder);
			this.Controls.Add(this.ELabel_Opacity);
			this.Controls.Add(this.ETrackBar_Opacity);
			this.Controls.Add(this.ECheckBox_KeepOnTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FormOptions";
			this.Text = "Options";
			this.Load += new System.EventHandler(this.FormOptions_Load);
			((System.ComponentModel.ISupportInitialize)(this.ETrackBar_Opacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox ECheckBox_KeepOnTop;
		private System.Windows.Forms.TrackBar ETrackBar_Opacity;
		private System.Windows.Forms.Label ELabel_Opacity;
		private System.Windows.Forms.CheckBox ECheckBox_HideBorder;
	}
}