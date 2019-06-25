using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TimerClient
{
	class TimeValidator
	{
		internal static string validateTime(String time, SettingsMenu panel)
		{   // example strings 36something428, 0020, 0820, 1225, 8:08, and 5am
			string tempString = time;
			string returnString = "";
			if (panel.hour24Button.Checked)
			{
				// replace all letters. Strings will be 36428, 0020, 0820, 1225, 808 and 5
				tempString = Regex.Replace(tempString, "[^0-9]", "");
				int placeholder = 0;
				if (tempString.Length >= 4)
				{
					int hours = int.Parse(tempString.Substring(0, 2));
					if (hours == 0)
					{// for 0020, hours will be 00
						returnString = "00";
						placeholder = 2;
					}
					else if (hours >= 24)
					{// for 36428, 36 hours is too many. Hours will be 03
						hours = int.Parse(tempString.Substring(0, 1));
						returnString = "0" + hours;
						placeholder = 1;
					}
					else if (hours < 10)
					{// for 0820, hours will be 08
						returnString = "0" + hours;
						if (tempString[0] == '0')
							placeholder = 2;
						else
							placeholder = 1;
					}
					else
					{ // for 1220, hours will be 12
						returnString += hours;
						placeholder = 2;
					}
				}
				else if (tempString.Length == 3)
				{ // 808 becomes 08:08. if it were 865, the method would return 08:00
					returnString = "0" + tempString[0] + ":";
					string mins = tempString.Substring(1);
					if (int.Parse(mins) >= 60)
						return returnString + "00";
					else
						return returnString + mins;
				}
				else if (tempString.Length == 2)
				{ // for 12, the return value will be 12:00 for 25, the returned string will be empty
					if (int.Parse(tempString) <= 24)
						return tempString + ":00";
					else
						return "";
				}
				else if (tempString.Length == 1) // for 5, the return value will be 05:00
					return "0" + tempString + ":00";
				else // otherwise we don't have any numbers so we quit
					return "";

				int minutes;
				// get the minutes from the next two digits, if there are enough digits
				// minutes: 36428=64, 0020=20, 0820=20, 1225=25
				if (tempString.Length >= (placeholder + 2) && tempString.Substring(placeholder, 2) != "00")
					minutes = int.Parse(tempString.Substring(placeholder, 2));
				else // otherwise just zero it out
					minutes = 0;

				if (minutes == 0 || minutes >= 60)
				{ // 64 is too large a number to be minutes, so the return string will be 03:00
					returnString += ":00";
				}
				else if (minutes < 10)
				{ // parsing 08 would make that number 8, so add a zero
					returnString += ":0" + minutes;
				}
				else // 0020 returns 00:20, 0820 returns 08:20, 1225 returns 12:25
					returnString += ":" + minutes;
			}
			else if (panel.hour12Button.Checked)
			{
				//strip leading 0s. Strings will be 36428, 20, 820, 1225, 808, and 5
				while (tempString[0] == '0')
				{
					tempString = tempString.Substring(1);
				}
				// replace all letters. Strings will be 36428, 20, 820, 1225, 808 and 5
				tempString = Regex.Replace(tempString, "[^0-9]", "");
				int placeholder = 2;
				if (tempString.Length >= 2)
				{ // 36, 20, 82, 12 and 80
					int hours = int.Parse(tempString.Substring(0, 2));
					if (hours > 12)
					{ //36=3, 20=2, 82=8, 80=8
						hours = int.Parse(tempString.Substring(0, 1));
						placeholder = 1;
					}
					returnString = hours + ":";
					string minutes;
					if (tempString.Length >= (placeholder + 2))
					{ // 36248=3:00, 20=2:00, 820=8:20, 1225=1225, 808=8:08
						minutes = tempString.Substring(placeholder, 2);
						if (int.Parse(minutes) >= 60)
							minutes = "00";
						returnString += minutes;
					}
					else
						returnString += "00";
				}
				else if (tempString.Length == 1)
				{ // 5 returns 5:00
					return tempString + ":00";
				}
				else
					return "";
			}
			return returnString;
		}

		internal static void SetAmPm(SettingsMenu settingsMenu, string time, string toOrFrom)
		{
			// just get the letters
			string letters = Regex.Replace(time, "[^a-zA-Z]", "");
			if (letters.Length >= 2)
				letters = letters.Substring(letters.Length - 2).ToLower();// get the last two letters
			else
				return; // no changes needed
			if (toOrFrom.Equals("from"))
			{
				if (letters.Equals("am"))
					settingsMenu.fromAmPmLabel.Text = "a.m.";
				else if (letters.Equals("pm"))
					settingsMenu.fromAmPmLabel.Text = "p.m.";
			}
			else
			{
				if (letters.Equals("am"))
					settingsMenu.toAmPmLabel.Text = "a.m.";
				else if (letters.Equals("pm"))
					settingsMenu.toAmPmLabel.Text = "p.m.";
			}
		}

		internal static void ConvertTo24(SettingsMenu settingsMenu)
		{
			TextBox toBox = settingsMenu.toTimeTextBox;
			TextBox fromBox = settingsMenu.fromTimeTextBox;
			if (toBox.Text == "" && fromBox.Text == "")
				return; // nothing to convert

			//to box//
			if (toBox.Text != "" && settingsMenu.toAmPmLabel.Text == "p.m.")
			{ // set for pm. Add 12 hours to current time
				string[] time = toBox.Text.Split(':');
				int hours = int.Parse(time[0]);
				if (hours < 12)
					hours = hours + 12;
				toBox.Text = hours + ":" + time[1];
			}
			else if (toBox.Text.Substring(0,2) == "12" && settingsMenu.toAmPmLabel.Text == "a.m.")
			{ // 12am is 00 hours
				toBox.Text = "00" + toBox.Text.Substring(2);
			}

			//from box//
			if (fromBox.Text != "" && settingsMenu.fromAmPmLabel.Text == "p.m.")
			{ // set for pm. Add 12 hours to current time
				string[] time = fromBox.Text.Split(':');
				int hours = int.Parse(time[0]);
				if (hours < 12)
					hours = hours + 12;
				fromBox.Text = hours + ":" + time[1];
			}
			else if (fromBox.Text.Substring(0, 2) == "12" && settingsMenu.fromAmPmLabel.Text == "a.m.")
			{ // 12am is 00 hours
				fromBox.Text = "00" + fromBox.Text.Substring(2);
			}
		}

		internal static void ConvertTo12(SettingsMenu settingsMenu)
		{
			TextBox toBox = settingsMenu.toTimeTextBox;
			TextBox fromBox = settingsMenu.fromTimeTextBox;
			if (toBox.Text == "" && fromBox.Text == "")
				return; // nothing to convert

			//to box//
			if (toBox.Text != "" && toBox.Text.Substring(0,2) != "00")
			{ 
				string[] time = toBox.Text.Split(':');
				int hours = int.Parse(time[0]);
				if (hours > 12)
				{	// anything after 1200 hours
					hours = hours - 12;
					settingsMenu.toAmPmLabel.Text = "p.m.";
				}
				toBox.Text = hours + ":" + time[1];
			}
			else if (toBox.Text.Substring(0, 2) == "00")
			{ // 0000 hours is 12am
				toBox.Text = "12" + toBox.Text.Substring(2);
				settingsMenu.toAmPmLabel.Text = "a.m.";
			}

			//from box//
			if (fromBox.Text != "" && fromBox.Text.Substring(0, 2) != "00")
			{ 
				string[] time = fromBox.Text.Split(':');
				int hours = int.Parse(time[0]);
				if (hours > 12)
				{   // anything after 1200 hours
					hours = hours - 12;
					settingsMenu.fromAmPmLabel.Text = "p.m.";
				}
				fromBox.Text = hours + ":" + time[1];
			}
			else if (fromBox.Text.Substring(0, 2) == "00")
			{ // 0000 hours is 12am
				fromBox.Text = "12" + fromBox.Text.Substring(2);
				settingsMenu.fromAmPmLabel.Text = "a.m.";
			}
		}
	}
}
