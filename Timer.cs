using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TimerClient
{
	public partial class Timer : Form
	{
		protected string state = "Ready";
		protected string logFileName;
		protected string projectsFileName = "projectList.txt";
		DateTime startTime;
		public Timer()
		{
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
	}
}
