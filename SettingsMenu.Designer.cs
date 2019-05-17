namespace TimerClient
{
	partial class SettingsMenu
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
			this.hoursWorkedLabel = new System.Windows.Forms.Label();
			this.fromTimeTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.toTimeTextBox = new System.Windows.Forms.TextBox();
			this.hour24Button = new System.Windows.Forms.RadioButton();
			this.hour12Button = new System.Windows.Forms.RadioButton();
			this.wakeAlertButton = new System.Windows.Forms.CheckBox();
			this.autoQuitButton = new System.Windows.Forms.CheckBox();
			this.largeTextButton = new System.Windows.Forms.CheckBox();
			this.modeLabel = new System.Windows.Forms.Label();
			this.darkModeButton = new System.Windows.Forms.RadioButton();
			this.lightModeButton = new System.Windows.Forms.RadioButton();
			this.timeType = new System.Windows.Forms.Panel();
			this.Modes = new System.Windows.Forms.Panel();
			this.highContrastModeButton = new System.Windows.Forms.RadioButton();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.fromAmPmLabel = new System.Windows.Forms.Label();
			this.toAmPmLabel = new System.Windows.Forms.Label();
			this.timeType.SuspendLayout();
			this.Modes.SuspendLayout();
			this.SuspendLayout();
			// 
			// hoursWorkedLabel
			// 
			this.hoursWorkedLabel.AutoSize = true;
			this.hoursWorkedLabel.Location = new System.Drawing.Point(15, 13);
			this.hoursWorkedLabel.Name = "hoursWorkedLabel";
			this.hoursWorkedLabel.Size = new System.Drawing.Size(72, 13);
			this.hoursWorkedLabel.TabIndex = 0;
			this.hoursWorkedLabel.Text = "Work Time:";
			// 
			// fromTimeTextBox
			// 
			this.fromTimeTextBox.Location = new System.Drawing.Point(19, 30);
			this.fromTimeTextBox.Name = "fromTimeTextBox";
			this.fromTimeTextBox.Size = new System.Drawing.Size(116, 20);
			this.fromTimeTextBox.TabIndex = 1;
			this.fromTimeTextBox.Leave += new System.EventHandler(this.fromTimeTextBox_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(143, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "to";
			// 
			// toTimeTextBox
			// 
			this.toTimeTextBox.Location = new System.Drawing.Point(170, 30);
			this.toTimeTextBox.Name = "toTimeTextBox";
			this.toTimeTextBox.Size = new System.Drawing.Size(116, 20);
			this.toTimeTextBox.TabIndex = 3;
			this.toTimeTextBox.Leave += new System.EventHandler(this.toTimeTextBox_Leave);
			// 
			// hour24Button
			// 
			this.hour24Button.AccessibleDescription = "Changes settings to 24 hour time";
			this.hour24Button.AccessibleName = "24 hour button";
			this.hour24Button.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.hour24Button.AutoSize = true;
			this.hour24Button.Checked = true;
			this.hour24Button.Location = new System.Drawing.Point(3, 3);
			this.hour24Button.Name = "hour24Button";
			this.hour24Button.Size = new System.Drawing.Size(70, 17);
			this.hour24Button.TabIndex = 4;
			this.hour24Button.TabStop = true;
			this.hour24Button.Text = "24 Hour";
			this.hour24Button.UseVisualStyleBackColor = true;
			this.hour24Button.CheckedChanged += new System.EventHandler(this.hour24Button_CheckedChanged);
			// 
			// hour12Button
			// 
			this.hour12Button.AccessibleDescription = "Choose to select 12 hour (am/pm) time";
			this.hour12Button.AccessibleName = "12 hour";
			this.hour12Button.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
			this.hour12Button.AutoSize = true;
			this.hour12Button.Location = new System.Drawing.Point(3, 26);
			this.hour12Button.Name = "hour12Button";
			this.hour12Button.Size = new System.Drawing.Size(70, 17);
			this.hour12Button.TabIndex = 5;
			this.hour12Button.Text = "12 Hour";
			this.hour12Button.UseVisualStyleBackColor = true;
			this.hour12Button.CheckedChanged += new System.EventHandler(this.hour12Button_CheckedChanged);
			// 
			// wakeAlertButton
			// 
			this.wakeAlertButton.AutoSize = true;
			this.wakeAlertButton.Location = new System.Drawing.Point(15, 57);
			this.wakeAlertButton.Name = "wakeAlertButton";
			this.wakeAlertButton.Size = new System.Drawing.Size(196, 17);
			this.wakeAlertButton.TabIndex = 6;
			this.wakeAlertButton.Text = "Alert at beginning of work day";
			this.wakeAlertButton.UseVisualStyleBackColor = true;
			// 
			// autoQuitButton
			// 
			this.autoQuitButton.AutoSize = true;
			this.autoQuitButton.Location = new System.Drawing.Point(15, 81);
			this.autoQuitButton.Name = "autoQuitButton";
			this.autoQuitButton.Size = new System.Drawing.Size(186, 17);
			this.autoQuitButton.TabIndex = 7;
			this.autoQuitButton.Text = "End task at end of work day";
			this.autoQuitButton.UseVisualStyleBackColor = true;
			// 
			// largeTextButton
			// 
			this.largeTextButton.AutoSize = true;
			this.largeTextButton.Location = new System.Drawing.Point(15, 105);
			this.largeTextButton.Name = "largeTextButton";
			this.largeTextButton.Size = new System.Drawing.Size(83, 17);
			this.largeTextButton.TabIndex = 8;
			this.largeTextButton.Text = "Large text";
			this.largeTextButton.UseVisualStyleBackColor = true;
			// 
			// modeLabel
			// 
			this.modeLabel.AutoSize = true;
			this.modeLabel.Location = new System.Drawing.Point(15, 129);
			this.modeLabel.Name = "modeLabel";
			this.modeLabel.Size = new System.Drawing.Size(42, 13);
			this.modeLabel.TabIndex = 9;
			this.modeLabel.Text = "Mode:";
			// 
			// darkModeButton
			// 
			this.darkModeButton.AutoSize = true;
			this.darkModeButton.Checked = true;
			this.darkModeButton.Location = new System.Drawing.Point(3, 3);
			this.darkModeButton.Name = "darkModeButton";
			this.darkModeButton.Size = new System.Drawing.Size(52, 17);
			this.darkModeButton.TabIndex = 10;
			this.darkModeButton.TabStop = true;
			this.darkModeButton.Text = "Dark";
			this.darkModeButton.UseVisualStyleBackColor = true;
			// 
			// lightModeButton
			// 
			this.lightModeButton.AutoSize = true;
			this.lightModeButton.Location = new System.Drawing.Point(3, 26);
			this.lightModeButton.Name = "lightModeButton";
			this.lightModeButton.Size = new System.Drawing.Size(53, 17);
			this.lightModeButton.TabIndex = 11;
			this.lightModeButton.Text = "Light";
			this.lightModeButton.UseVisualStyleBackColor = true;
			// 
			// timeType
			// 
			this.timeType.Controls.Add(this.hour24Button);
			this.timeType.Controls.Add(this.hour12Button);
			this.timeType.Location = new System.Drawing.Point(294, 7);
			this.timeType.Name = "timeType";
			this.timeType.Size = new System.Drawing.Size(80, 52);
			this.timeType.TabIndex = 12;
			// 
			// Modes
			// 
			this.Modes.Controls.Add(this.highContrastModeButton);
			this.Modes.Controls.Add(this.darkModeButton);
			this.Modes.Controls.Add(this.lightModeButton);
			this.Modes.Location = new System.Drawing.Point(19, 145);
			this.Modes.Name = "Modes";
			this.Modes.Size = new System.Drawing.Size(127, 75);
			this.Modes.TabIndex = 13;
			// 
			// highContrastModeButton
			// 
			this.highContrastModeButton.AutoSize = true;
			this.highContrastModeButton.Location = new System.Drawing.Point(3, 49);
			this.highContrastModeButton.Name = "highContrastModeButton";
			this.highContrastModeButton.Size = new System.Drawing.Size(102, 17);
			this.highContrastModeButton.TabIndex = 12;
			this.highContrastModeButton.Text = "High Contrast";
			this.highContrastModeButton.UseVisualStyleBackColor = true;
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.saveButton.ForeColor = System.Drawing.Color.Black;
			this.saveButton.Location = new System.Drawing.Point(13, 348);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 14;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cancelButton.ForeColor = System.Drawing.Color.Black;
			this.cancelButton.Location = new System.Drawing.Point(95, 348);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 15;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cancelButton_MouseClick);
			// 
			// fromAmPmLabel
			// 
			this.fromAmPmLabel.AutoSize = true;
			this.fromAmPmLabel.BackColor = System.Drawing.Color.White;
			this.fromAmPmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.fromAmPmLabel.ForeColor = System.Drawing.Color.Black;
			this.fromAmPmLabel.Location = new System.Drawing.Point(108, 35);
			this.fromAmPmLabel.Name = "fromAmPmLabel";
			this.fromAmPmLabel.Size = new System.Drawing.Size(27, 13);
			this.fromAmPmLabel.TabIndex = 16;
			this.fromAmPmLabel.Text = "a.m.";
			this.fromAmPmLabel.Visible = false;
			// 
			// toAmPmLabel
			// 
			this.toAmPmLabel.AutoSize = true;
			this.toAmPmLabel.BackColor = System.Drawing.Color.White;
			this.toAmPmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.toAmPmLabel.ForeColor = System.Drawing.Color.Black;
			this.toAmPmLabel.Location = new System.Drawing.Point(259, 35);
			this.toAmPmLabel.Name = "toAmPmLabel";
			this.toAmPmLabel.Size = new System.Drawing.Size(27, 13);
			this.toAmPmLabel.TabIndex = 17;
			this.toAmPmLabel.Text = "p.m.";
			this.toAmPmLabel.Visible = false;
			// 
			// SettingsMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(584, 391);
			this.ControlBox = false;
			this.Controls.Add(this.toAmPmLabel);
			this.Controls.Add(this.fromAmPmLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.Modes);
			this.Controls.Add(this.timeType);
			this.Controls.Add(this.modeLabel);
			this.Controls.Add(this.largeTextButton);
			this.Controls.Add(this.autoQuitButton);
			this.Controls.Add(this.wakeAlertButton);
			this.Controls.Add(this.toTimeTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.fromTimeTextBox);
			this.Controls.Add(this.hoursWorkedLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.LightGray;
			this.Name = "SettingsMenu";
			this.Text = "Settings";
			this.timeType.ResumeLayout(false);
			this.timeType.PerformLayout();
			this.Modes.ResumeLayout(false);
			this.Modes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label hoursWorkedLabel;
		internal System.Windows.Forms.TextBox fromTimeTextBox;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox toTimeTextBox;
		internal System.Windows.Forms.RadioButton hour24Button;
		internal System.Windows.Forms.RadioButton hour12Button;
		internal System.Windows.Forms.CheckBox wakeAlertButton;
		internal System.Windows.Forms.CheckBox autoQuitButton;
		internal System.Windows.Forms.CheckBox largeTextButton;
		internal System.Windows.Forms.Label modeLabel;
		internal System.Windows.Forms.RadioButton darkModeButton;
		internal System.Windows.Forms.RadioButton lightModeButton;
		internal System.Windows.Forms.Panel timeType;
		internal System.Windows.Forms.Panel Modes;
		internal System.Windows.Forms.RadioButton highContrastModeButton;
		internal System.Windows.Forms.Button saveButton;
		internal System.Windows.Forms.Button cancelButton;
		internal System.Windows.Forms.Label fromAmPmLabel;
		internal System.Windows.Forms.Label toAmPmLabel;
	}
}