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
			this.timeToLabel = new System.Windows.Forms.Label();
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
			this.modesLabel = new System.Windows.Forms.Panel();
			this.highContrastModeButton = new System.Windows.Forms.RadioButton();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.fromAmPmLabel = new System.Windows.Forms.Label();
			this.toAmPmLabel = new System.Windows.Forms.Label();
			this.timeType.SuspendLayout();
			this.modesLabel.SuspendLayout();
			this.SuspendLayout();
			// 
			// hoursWorkedLabel
			// 
			this.hoursWorkedLabel.AutoSize = true;
			this.hoursWorkedLabel.Location = new System.Drawing.Point(15, 13);
			this.hoursWorkedLabel.Name = "hoursWorkedLabel";
			this.hoursWorkedLabel.Size = new System.Drawing.Size(72, 13);
			this.hoursWorkedLabel.TabIndex = 22;
			this.hoursWorkedLabel.Text = "Work Time:";
			// 
			// fromTimeTextBox
			// 
			this.fromTimeTextBox.Location = new System.Drawing.Point(19, 30);
			this.fromTimeTextBox.Name = "fromTimeTextBox";
			this.fromTimeTextBox.Size = new System.Drawing.Size(116, 20);
			this.fromTimeTextBox.TabIndex = 0;
			this.fromTimeTextBox.Leave += new System.EventHandler(this.fromTimeTextBox_Leave);
			// 
			// timeToLabel
			// 
			this.timeToLabel.AccessibleDescription = "Label between start time and end time";
			this.timeToLabel.AccessibleName = "to";
			this.timeToLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
			this.timeToLabel.AutoSize = true;
			this.timeToLabel.Location = new System.Drawing.Point(143, 30);
			this.timeToLabel.Name = "timeToLabel";
			this.timeToLabel.Size = new System.Drawing.Size(18, 13);
			this.timeToLabel.TabIndex = 21;
			this.timeToLabel.Text = "to";
			// 
			// toTimeTextBox
			// 
			this.toTimeTextBox.Location = new System.Drawing.Point(170, 30);
			this.toTimeTextBox.Name = "toTimeTextBox";
			this.toTimeTextBox.Size = new System.Drawing.Size(116, 20);
			this.toTimeTextBox.TabIndex = 1;
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
			this.hour24Button.TabIndex = 3;
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
			this.hour12Button.TabIndex = 4;
			this.hour12Button.Text = "12 Hour";
			this.hour12Button.UseVisualStyleBackColor = true;
			this.hour12Button.CheckedChanged += new System.EventHandler(this.hour12Button_CheckedChanged);
			// 
			// wakeAlertButton
			// 
			this.wakeAlertButton.AutoSize = true;
			this.wakeAlertButton.Location = new System.Drawing.Point(19, 58);
			this.wakeAlertButton.Name = "wakeAlertButton";
			this.wakeAlertButton.Size = new System.Drawing.Size(196, 17);
			this.wakeAlertButton.TabIndex = 5;
			this.wakeAlertButton.Text = "Alert at beginning of work day";
			this.wakeAlertButton.UseVisualStyleBackColor = true;
			this.wakeAlertButton.CheckedChanged += new System.EventHandler(this.wakeAlertButton_CheckedChanged);
			// 
			// autoQuitButton
			// 
			this.autoQuitButton.AutoSize = true;
			this.autoQuitButton.Location = new System.Drawing.Point(19, 81);
			this.autoQuitButton.Name = "autoQuitButton";
			this.autoQuitButton.Size = new System.Drawing.Size(186, 17);
			this.autoQuitButton.TabIndex = 6;
			this.autoQuitButton.Text = "End task at end of work day";
			this.autoQuitButton.UseVisualStyleBackColor = true;
			this.autoQuitButton.CheckedChanged += new System.EventHandler(this.autoQuitButton_CheckedChanged);
			// 
			// largeTextButton
			// 
			this.largeTextButton.AutoSize = true;
			this.largeTextButton.Location = new System.Drawing.Point(19, 104);
			this.largeTextButton.Name = "largeTextButton";
			this.largeTextButton.Size = new System.Drawing.Size(83, 17);
			this.largeTextButton.TabIndex = 7;
			this.largeTextButton.Text = "Large text";
			this.largeTextButton.UseVisualStyleBackColor = true;
			this.largeTextButton.CheckedChanged += new System.EventHandler(this.largeTextButton_CheckedChanged);
			// 
			// modeLabel
			// 
			this.modeLabel.AutoSize = true;
			this.modeLabel.Location = new System.Drawing.Point(15, 129);
			this.modeLabel.Name = "modeLabel";
			this.modeLabel.Size = new System.Drawing.Size(42, 13);
			this.modeLabel.TabIndex = 20;
			this.modeLabel.Text = "Mode:";
			// 
			// darkModeButton
			// 
			this.darkModeButton.AutoSize = true;
			this.darkModeButton.Checked = true;
			this.darkModeButton.Location = new System.Drawing.Point(3, 3);
			this.darkModeButton.Name = "darkModeButton";
			this.darkModeButton.Size = new System.Drawing.Size(52, 17);
			this.darkModeButton.TabIndex = 9;
			this.darkModeButton.TabStop = true;
			this.darkModeButton.Text = "Dark";
			this.darkModeButton.UseVisualStyleBackColor = true;
			this.darkModeButton.CheckedChanged += new System.EventHandler(this.darkModeButton_CheckedChanged);
			// 
			// lightModeButton
			// 
			this.lightModeButton.AutoSize = true;
			this.lightModeButton.Location = new System.Drawing.Point(3, 26);
			this.lightModeButton.Name = "lightModeButton";
			this.lightModeButton.Size = new System.Drawing.Size(53, 17);
			this.lightModeButton.TabIndex = 10;
			this.lightModeButton.Text = "Light";
			this.lightModeButton.UseVisualStyleBackColor = true;
			this.lightModeButton.CheckedChanged += new System.EventHandler(this.lightModeButton_CheckedChanged);
			// 
			// timeType
			// 
			this.timeType.Controls.Add(this.hour24Button);
			this.timeType.Controls.Add(this.hour12Button);
			this.timeType.Location = new System.Drawing.Point(294, 7);
			this.timeType.Name = "timeType";
			this.timeType.Size = new System.Drawing.Size(80, 52);
			this.timeType.TabIndex = 2;
			// 
			// modesLabel
			// 
			this.modesLabel.Controls.Add(this.highContrastModeButton);
			this.modesLabel.Controls.Add(this.darkModeButton);
			this.modesLabel.Controls.Add(this.lightModeButton);
			this.modesLabel.Location = new System.Drawing.Point(19, 145);
			this.modesLabel.Name = "modesLabel";
			this.modesLabel.Size = new System.Drawing.Size(127, 75);
			this.modesLabel.TabIndex = 8;
			// 
			// highContrastModeButton
			// 
			this.highContrastModeButton.AutoSize = true;
			this.highContrastModeButton.Location = new System.Drawing.Point(3, 49);
			this.highContrastModeButton.Name = "highContrastModeButton";
			this.highContrastModeButton.Size = new System.Drawing.Size(102, 17);
			this.highContrastModeButton.TabIndex = 11;
			this.highContrastModeButton.Text = "High Contrast";
			this.highContrastModeButton.UseVisualStyleBackColor = true;
			this.highContrastModeButton.CheckedChanged += new System.EventHandler(this.highContrastModeButton_CheckedChanged);
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.saveButton.ForeColor = System.Drawing.Color.Black;
			this.saveButton.Location = new System.Drawing.Point(19, 240);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 12;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cancelButton.ForeColor = System.Drawing.Color.Black;
			this.cancelButton.Location = new System.Drawing.Point(100, 240);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 13;
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
			this.fromAmPmLabel.TabIndex = 1;
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
			this.toAmPmLabel.TabIndex = 0;
			this.toAmPmLabel.Text = "p.m.";
			this.toAmPmLabel.Visible = false;
			// 
			// SettingsMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(380, 275);
			this.ControlBox = false;
			this.Controls.Add(this.toAmPmLabel);
			this.Controls.Add(this.fromAmPmLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.modesLabel);
			this.Controls.Add(this.timeType);
			this.Controls.Add(this.modeLabel);
			this.Controls.Add(this.largeTextButton);
			this.Controls.Add(this.autoQuitButton);
			this.Controls.Add(this.wakeAlertButton);
			this.Controls.Add(this.toTimeTextBox);
			this.Controls.Add(this.timeToLabel);
			this.Controls.Add(this.fromTimeTextBox);
			this.Controls.Add(this.hoursWorkedLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.LightGray;
			this.Name = "SettingsMenu";
			this.Text = "Settings";
			this.timeType.ResumeLayout(false);
			this.timeType.PerformLayout();
			this.modesLabel.ResumeLayout(false);
			this.modesLabel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label hoursWorkedLabel;
		internal System.Windows.Forms.TextBox fromTimeTextBox;
		internal System.Windows.Forms.Label timeToLabel;
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
		internal System.Windows.Forms.Panel modesLabel;
		internal System.Windows.Forms.RadioButton highContrastModeButton;
		internal System.Windows.Forms.Button saveButton;
		internal System.Windows.Forms.Button cancelButton;
		internal System.Windows.Forms.Label fromAmPmLabel;
		internal System.Windows.Forms.Label toAmPmLabel;
	}
}