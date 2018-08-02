namespace MiniClock {
    partial class FormSettings {
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
            this.ECheckBox_HideBorder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ECheckBox_KeepOnTop
            // 
            this.ECheckBox_KeepOnTop.AutoSize = true;
            this.ECheckBox_KeepOnTop.Location = new System.Drawing.Point(12, 12);
            this.ECheckBox_KeepOnTop.Name = "ECheckBox_KeepOnTop";
            this.ECheckBox_KeepOnTop.Size = new System.Drawing.Size(84, 17);
            this.ECheckBox_KeepOnTop.TabIndex = 0;
            this.ECheckBox_KeepOnTop.Text = "Keep on top";
            this.ECheckBox_KeepOnTop.UseVisualStyleBackColor = true;
            this.ECheckBox_KeepOnTop.CheckedChanged += new System.EventHandler(this.ECheckBox_KeepOnTop_CheckedChanged);
            // 
            // ECheckBox_HideBorder
            // 
            this.ECheckBox_HideBorder.AutoSize = true;
            this.ECheckBox_HideBorder.Location = new System.Drawing.Point(102, 12);
            this.ECheckBox_HideBorder.Name = "ECheckBox_HideBorder";
            this.ECheckBox_HideBorder.Size = new System.Drawing.Size(120, 17);
            this.ECheckBox_HideBorder.TabIndex = 1;
            this.ECheckBox_HideBorder.Text = "Hide window border";
            this.ECheckBox_HideBorder.UseVisualStyleBackColor = true;
            this.ECheckBox_HideBorder.CheckedChanged += new System.EventHandler(this.ECheckBox_HideBorder_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 36);
            this.Controls.Add(this.ECheckBox_HideBorder);
            this.Controls.Add(this.ECheckBox_KeepOnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ECheckBox_KeepOnTop;
        private System.Windows.Forms.CheckBox ECheckBox_HideBorder;
    }
}