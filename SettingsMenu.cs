﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerClient
{

	public partial class SettingsMenu : Form
	{
		private SettingsMenu settingsMenu;
		public SettingsMenu()
		{
			settingsMenu = this;
			InitializeComponent();
		}

		private void hour12Button_CheckedChanged(object sender, EventArgs e)
		{
			if (hour12Button.Checked)
			{
				toAmPmLabel.Visible = true;
				fromAmPmLabel.Visible = true;
				TimeValidator.ConvertTo12(this);
			}
			Settings.SetSetting("TimeFormat", "12");
		}

		private void hour24Button_CheckedChanged(object sender, EventArgs e)
		{
			if (hour24Button.Checked)
			{
				toAmPmLabel.Visible = false;
				fromAmPmLabel.Visible = false;
				TimeValidator.ConvertTo24(this);
				Settings.SetSetting("TimeFormat", "24");
			}
		}

		private void cancelButton_MouseClick(object sender, MouseEventArgs e)
		{
			settingsMenu.Visible = false;
		}

		private void fromTimeTextBox_Leave(object sender, EventArgs e)
		{
			var time = fromTimeTextBox.Text;
			if (hour12Button.Checked)
			{
				TimeValidator.SetAmPm(this, time, "from");
			}
			fromTimeTextBox.Text = TimeValidator.validateTime(time, this);
			Settings.SetSetting("WorkTimeStart", fromTimeTextBox.Text);
		}

		private void toTimeTextBox_Leave(object sender, EventArgs e)
		{
			var time = toTimeTextBox.Text;
			if (hour12Button.Checked)
			{
				TimeValidator.SetAmPm(this, time, "to");
			}
			toTimeTextBox.Text = TimeValidator.validateTime(time, this);
			Settings.SetSetting("WorkTimeStart", toTimeTextBox.Text);
		}

		private void darkModeButton_CheckedChanged(object sender, EventArgs e)
		{
			if (darkModeButton.Checked)
			{
				bool worked = Settings.SetSetting("Mode", "Dark");
				if (worked)
				{
					this.BackColor = Color.Black;
					this.ForeColor = Color.LightGray;
				}
				else
					HandleError("Mode Change Failed");
			}
		}

		private void lightModeButton_CheckedChanged(object sender, EventArgs e)
		{
			if (lightModeButton.Checked)
			{
				bool worked = Settings.SetSetting("Mode", "Light");
				if (worked)
				{
					this.BackColor = Color.LightGray;
					this.ForeColor = Color.Black;
				}
				else
					HandleError("Mode Change Failed");
			}
		}


		private void highContrastModeButton_CheckedChanged(object sender, EventArgs e)
		{
			if (highContrastModeButton.Checked)
			{
				bool worked = Settings.SetSetting("Mode", "Contrast");
				if (worked)
				{
					this.BackColor = Color.White;
					this.ForeColor = Color.Navy;
				}
				else
					HandleError("Mode Change Failed");
			}
		}

		private void HandleError(string error)
		{
			Console.WriteLine(error);
		}

		private void largeTextButton_CheckedChanged(object sender, EventArgs e)
		{
			if (largeTextButton.Checked)
			{
				Font f = new System.Drawing.Font("Microsoft Sans Serif", 14F);
				this.Font = f;
				Settings.SetSetting("LargeText", "1");
			}
			else
			{
				Font f = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
				this.Font = f;
				Settings.SetSetting("LargeText", "0");
			}
		}

		private void saveButton_MouseClick(object sender, MouseEventArgs e)
		{
			bool success = Settings.WriteSettingsToFile();
			if (!success) {
				Task task = Task.Run(() => saveButton_MouseClick(sender, e));
				if (task.Wait(TimeSpan.FromMilliseconds(50)))
				{
					Timer.UpdateSettings();
					this.Close();
				}
				else
				{
					saveButton_MouseClick(sender, e);
				}
			}
		}

		private void wakeAlertButton_CheckedChanged(object sender, EventArgs e)
		{
			if (wakeAlertButton.Checked)
			{
				Settings.SetSetting("AlertBeginning", "1");
			}
			else
			{
				Settings.SetSetting("AlertBeginning", "0");
			}
		}

		private void autoQuitButton_CheckedChanged(object sender, EventArgs e)
		{
			if (autoQuitButton.Checked)
			{
				Settings.SetSetting("AlertBeginning", "1");
			}
			else
			{
				Settings.SetSetting("AlertBeginning", "0");
			}
		}
	}
}
