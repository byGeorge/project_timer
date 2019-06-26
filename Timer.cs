﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerClient
{
	public partial class Timer : Form
	{
		protected string state = "Ready";
		protected string logFileName;
		protected string projectsFileName = "projectList.txt";
		private static DateTime startWork = new DateTime();
		private static DateTime stopWork = new DateTime();
		private static int timeFormat = 24;
		private static bool startAlert = false;
		private static bool stopAlert = false;
		private static string waitingToQuit = "";
		private static bool largeText = false;
		private static string mode = "Dark";
		internal TimeSpan elapsedTime;

		DateTime startTime;
		public Timer()
		{
			DateTime now = new DateTime();
			logFileName = now.Year.ToString() + "_" + now.Month.ToString() + ".txt";
			InitializeComponent();
		}

		private void TimerBoard_Load(object sender, EventArgs e)
		{
			var noProjects = true;
			if (File.Exists(projectsFileName))
			{
				string p = File.ReadAllText(projectsFileName);
				string[] projects= p.Split(',');
				Array.Sort(projects);
				foreach(var project in projects)
				{
					projectListCombobox.Items.Add(project);
				}
				if (projects.Length > 0)
				{
					noProjects = false;
				}
					
			}
			if (noProjects)
			{
				addProject();
			}
			UpdateSettings();
			setInterval(SetTimeNow, 1000);
		}

		private void addProjectButton_MouseClick(object sender, MouseEventArgs e)
		{
			addProject();
		}

		private void addProject()
		{
			DoStop();
			state = "Adding";
			addProjectTextbox.Text = "";
			addProjectTextbox.Visible = true;
			startStopTimerButton.Text = "Add Project";
		}

		private string FormatElapsedTime()
		{
			int mins = elapsedTime.Minutes;
			string minutes = mins.ToString();
			if (mins < 10)
				minutes = "0" + minutes;
			int secs = elapsedTime.Seconds;
			string seconds = secs.ToString();
			if (secs < 10)
				seconds = "0" + seconds;
			return elapsedTime.Hours + ":" + minutes + ":" + seconds;
		}

		private async void RunningLabelStart()
		{
			while (state == "Running")
			{
				runningLabel.Text = await RunningLabelRun();
			}
			runningLabel.Text = FormatElapsedTime() + " Stopped";
		}

		private async Task<string> RunningLabelRun()
		{
			DateTime curTime = DateTime.Now;
			elapsedTime = curTime - startTime;
			await Task.Delay(1000);
			return FormatElapsedTime() + " Running";
		}

		private void startStopTimerButton_MouseClick(object sender, MouseEventArgs e)
		{
			if (state == "Ready")
			{
				if (projectListCombobox.Text != "")
				{
					startTime = DateTime.Now;
					logFileName = startTime.Year.ToString() + "_" + startTime.Month.ToString() + ".txt";
					projectTimer.Start();
					startStopTimerButton.Text = "Stop";
					state = "Running";
					projectListCombobox.Enabled = false;
					runningLabel.Visible = true;
					runningLabel.Text = "0:00:00 Running";
					RunningLabelStart();
				}
				else
					projectListCombobox.DroppedDown = true;
			}
			else if (state == "Running")
			{
				projectListCombobox.Enabled = true;
				DoStop();
			}
			else if (state == "Adding")
			{
				SendNewProject();
			}

		}

		private void SendNewProject()
		{
			projectListCombobox.Enabled = true;
			addProjectTextbox.Visible = false;
			startStopTimerButton.Text = "Start";
			state = "Ready";
			string entry = addProjectTextbox.Text;
			if (!string.IsNullOrWhiteSpace(entry.Trim()))
			{
				bool fileExists = File.Exists(projectsFileName);
				bool entryExists = false;
				if (fileExists)
				{
					string p = File.ReadAllText(projectsFileName);
					string[] projects = p.Split(',');
					if (Array.IndexOf(projects, entry) > -1)
					{
						entryExists = true;
					}
				}
				using (StreamWriter w = File.AppendText(projectsFileName))
				{
					if (fileExists && !entryExists)
						w.WriteLine("," + entry.Trim());
					else
						w.WriteLine(entry); // first entry should not have a comma
				}
				projectListCombobox.Items.Add(entry);
			}
		}

		internal static void UpdateSettings()
		{
			string[] settingsArray = Settings.GetSettings();
			if (settingsArray.Length > 0)
			{
				string wStart = settingsArray[0]; // work time start
				string wStop = settingsArray[1]; // work time stop
				string frmat = settingsArray[2]; // time format
				string aStart = settingsArray[3]; // alert at start?
				string aStop = settingsArray[4]; // auto stop?
				string lrg = settingsArray[5]; // large text?
				string mde = settingsArray[6]; // colour scheme

				DateTime today = DateTime.Now;
				if (wStart != "")
				{
					string[] wStartArray = wStart.Split(':');
					int hour = 0;
					int.TryParse(wStartArray[0], out hour);
					int minutes = 0;
					int.TryParse(wStartArray[1], out minutes);
					startWork = new DateTime(today.Year, today.Month, today.Day, hour, minutes, 0);
				}

				if (wStop != "")
				{
					string[] wStopArray = wStop.Split(':');
					int hour = 0;
					int.TryParse(wStopArray[0], out hour);
					int minutes = 0;
					int.TryParse(wStopArray[1], out minutes);
					startWork = new DateTime(today.Year, today.Month, today.Day, hour, minutes, 0);
				}

				if (frmat == "12")
				{
					timeFormat = 12;
				}
				else if (frmat == "24")
				{
					timeFormat = 24;
				}

				if (aStart == "0")
				{
					startAlert = false;
				}
				else if (aStart == "1")
				{
					startAlert = true;
				}

				if (aStop == "0")
				{
					stopAlert = false;
				}
				else if (aStop == "1")
				{
					stopAlert = true;
				}

				if (lrg == "0")
				{
					largeText = false;
				}
				else if (lrg == "1")
				{
					largeText = true;
				}

				if (mde != "")
				{
					mode = mde;
				}
			}
		}

		public static async Task setInterval(Action action, int timeout)
		{
			action();
			await Task.Delay(timeout);
			await setInterval(action, timeout);
		}

		private void SetTimeNow()
		{
			DateTime now = DateTime.Now;
			int hour = now.Hour;
			string hours;
			int minute = now.Minute;
			string minutes = "";
			if (minute < 10)
			{
				minutes = "0" + minute;
			}
			else
			{
				minutes = minute.ToString();
			}
			if (timeFormat == 12)
			{
				bool isEvening = false;
				if (hour > 12)
				{
					hours = (hour - 12).ToString();
					isEvening = true;
				}
				else
				{
					hours = hour.ToString();
				}
				if (isEvening)
				{
					minutes = minutes + "pm";
				}
				else
				{
					minutes = minutes + "am";
				}
			}
			else
			{
				if (hour < 10)
				{
					hours = "0" + hour;
				}
				else
				{
					hours = hour.ToString();
				}
			}
			string dt = hours + ":" + minutes;
			nowLabel.Text = "Now: " + dt;
			if (Equals(dt, Settings.GetSetting("WorkTimeStart")) && startAlert && state != "Running" )
			{
				WindowState = FormWindowState.Minimized;
				WindowState = FormWindowState.Normal;
				BringToFront();
				Focus();
				MessageBox.Show("Good Morning! \nWhat would you like to work on today?", "Wake Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			Thread t = null;
			if (Equals(dt, Settings.GetSetting("WorkTimeStop")) && stopAlert && state == "Running" && waitingToQuit != "")
			{
				WindowState = FormWindowState.Minimized;
				WindowState = FormWindowState.Normal;
				BringToFront();
				Focus();
				
				void ShowBox()
				{
					DialogResult mb = MessageBox.Show("Congratulations! You've reached the end of your work day.\nShould I stop the timer?", "Stop Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (mb == DialogResult.Yes)
					{
						// if user clicks yes on the dialog
						startStopTimerButton.PerformClick();
					}
					else
					{
						minute = (minute + 5);
						if (minute > 60)
						{
							hour = hour + 1;
							minute = minute % 60;
						}
						waitingToQuit = hour + ":" + minute;
					}
				}
				t = new Thread(new ThreadStart(ShowBox));
			}
			else if (waitingToQuit != "")
			{
				string[] time = waitingToQuit.Split(':');
				if (Equals(hour.ToString(), time[0]) && Equals(minute.ToString(), time[1]))
				{
					if (t.IsAlive && t != null)
					{
						t.Abort();
					}
				}
			}
		}

		private void DoStop()
		{
			projectTimer.Stop();
			if (state == "Running")
			{				
				startStopTimerButton.Text = "Start";
				state = "Ready";
				DateTime stopTime = DateTime.Now;
				TimeSpan elapsed = stopTime - startTime;
				int hours = (int)Math.Floor( elapsed.TotalHours);
				double min = elapsed.TotalMinutes - (hours * 60);
				int mins = (int)Math.Round(min);
				string minutes = mins.ToString();
				if (mins < 10)
					minutes = "0" + minutes;
				string timeString = hours + ":" + minutes;
				string project = projectListCombobox.Text;
				AddLogEntry(startTime.ToString() + "\t" + stopTime.ToString() + "\t" + project + "\t" + timeString + "\n");

				if (File.Exists(projectsFileName))
				{
					string p = File.ReadAllText(projectsFileName);
					string[] projects = p.Split(',');
					bool hasProject = false;
					foreach (string proj in projects)
					{
						if (proj.Trim().Equals(project.Trim()))
						{
							hasProject = true;
							break;
						}
					}
					if (!hasProject)
					{
						addProjectTextbox.Text = project;
						SendNewProject();
					}
				}
				else
				{
					addProjectTextbox.Text = project;
					SendNewProject();
				}
			}
		}


		private void AddLogEntry(string entry)
		{
			if (!File.Exists(logFileName))
				entry = "Start Time\tStop Time\tProject\tTime elapsed(H:M)\r\n" + entry;
			using (StreamWriter w = File.AppendText(logFileName))
			{
				w.WriteLine(entry);
			}
		}

		private void openFile_Click(object sender, EventArgs e)
		{
			if (File.Exists(logFileName))
				Process.Start(logFileName);
			else
			{
				using (StreamWriter w = File.AppendText(logFileName))
				{
					w.WriteLine("Start Time\tStop Time\tProject\tTime elapsed(H:M)\r\n");
				}
				Process.Start(logFileName);
			}
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			SettingsMenu settingsMenu = new SettingsMenu();
			settingsMenu.Visible = true;
		}

		private void startStopTimerButton_Click(object sender, EventArgs e)
		{

		}
	}
}
