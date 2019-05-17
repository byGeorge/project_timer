using System;
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
			}
		}

		private void hour24Button_CheckedChanged(object sender, EventArgs e)
		{
			if (hour24Button.Checked)
			{
				toAmPmLabel.Visible = false;
				fromAmPmLabel.Visible = false;
			}
		}

		private void cancelButton_MouseClick(object sender, MouseEventArgs e)
		{
			settingsMenu.Visible = false;
		}

		private string validateTime(String time)
		{
			string tempString = time;
			string returnString = "";
			tempString = Regex.Replace(tempString, "[^0-9]", "");
			if (hour24Button.Checked)
			{
				if (tempString.Length >= 2)
				{
					int hours = int.Parse(tempString.Substring(0, 2));
					if (hours == 0)
						returnString = "00";
					else if (hours >= 24)
					{
						hours = int.Parse(tempString.Substring(0, 1));
						returnString = "0" + hours;
					}
					else if (hours < 10)
					{
						returnString = "0" + hours;
					}
					else
						returnString += hours;
				}
				else if (tempString.Length == 1)
					return "0" + tempString;
				else
					return "";
				int minutes;
				if (tempString.Length >= 4 && tempString.Substring(2, 2) != "00")
					minutes = int.Parse(tempString.Substring(2, 2));
				else if (tempString.Length == 3)
					minutes = int.Parse(tempString.Substring(2, 1));
				else
					minutes = 0;
				if (minutes == 0 || minutes >= 60)
				{
					returnString += ":00";
				}
				else if (minutes < 10)
				{
					returnString += ":0" + minutes;
				}
				else
					returnString += ":" + minutes;
			}
			else if (hour12Button.Checked)
			{
				//strip leading 0s
				while (returnString[0] == '0')
				{
					returnString = returnString.Substring(1);
				}
			}
			return returnString;
		}

		private void fromTimeTextBox_Leave(object sender, EventArgs e)
		{
			fromTimeTextBox.Text = validateTime(fromTimeTextBox.Text);
		}
	}
}
