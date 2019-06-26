using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerClient
{
	static class Settings
	{
		static string[] settingsArray = new string[0];
		static bool initialised = false;

		private static void GetSettingsFromFile()
		{
			// settings are in this format: 
			//WorkTimeStart|WorkTimeStop|TimeFormat|AlertBeginning|AutoStop|LargeText|Mode
			// Example:08:00|16:30|24|1|1|0|Dark
			string settings;
			try
			{
				settings = File.ReadAllText("settings.txt");
				settingsArray = settings.Split('|');
			}
			catch (FileNotFoundException e)
			{
				Console.WriteLine(e.StackTrace);
			}
			initialised = true;
		}

		internal static string[] GetSettings()
		{
			if (!initialised)
			{
				GetSettingsFromFile();
			}
			return settingsArray;
		}

		internal static bool WriteSettingsToFile()
		{
			try
			{
				File.WriteAllText("settings.txt",string.Join("|", settingsArray));
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}

		internal static string GetSetting(string setting)
		{
			if (!initialised)
				GetSettingsFromFile();
			if (settingsArray == null)
				return "";
			else
			{
				switch (setting)
				{
					case "WorkTimeStart": //When the person wants to begin their day
						return settingsArray[0];
					case "WorkTimeStop": //When the person wants to end their day
						return settingsArray[1];
					case "TimeFormat": // 24 or 12 hour format
						return settingsArray[2];
					case "AlertBeginning": // Does the person want a reminder to start the program?
						return settingsArray[3];
					case "AutoStop": // Does the person want to stop the timer automatically?
						return settingsArray[4];
					case "LargeText": // Does the person prefer larger letters?
						return settingsArray[5];
					case "Mode": // What colour scheme to use
						return settingsArray[6];
					default:
						return "";
				}
			}
		}

		internal static bool SetSetting(string setting, string entry)
		{
			try {
				if (settingsArray == null)
				{
					settingsArray = new String[7];
				}
				switch (setting)
				{
					case "WorkTimeStart": //When the person wants to begin their day
						settingsArray[0] = entry;
						break;
					case "WorkTimeStop": //When the person wants to end their day
						settingsArray[1] = entry;
						break;
					case "TimeFormat": // 24 or 12 hour format
						settingsArray[2] = entry;
						break;
					case "AlertBeginning": // Does the person want a reminder to start the program?
						settingsArray[3] = entry;
						break;
					case "AutoStop": // Does the person want to stop the timer automatically?
						settingsArray[4] = entry;
						break;
					case "LargeText": // Does the person prefer larger letters?
						settingsArray[5] = entry;
						break;
					case "Mode": // What colour scheme to use
						settingsArray[6] = entry;
						break;
					default:
						return false;
				}
				return true;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.StackTrace);
				return false;
			}

		}
	}
}
