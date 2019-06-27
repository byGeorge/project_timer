using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerClient
{
	public partial class MessagePanel : Form
	{
		string type = "unset";
		Timer timer;
		public MessagePanel()
		{
			InitializeComponent();
		}

		public MessagePanel(string messageType, Timer curTimer)
		{
			InitializeComponent();
			type = messageType;
			timer = curTimer;
			if (Equals(type, "wake"))
			{
				messagePanelText.Text = "Good Morning! \nWhat would you like to work on today?";
				okayButton.Text = "OK";
				closeButton.Text = "Cancel";
				string[] projects = Timer.getProjects();
				if (projects != null)
				{
					foreach (var project in projects)
					{
						projectListBox.Items.Add(project);
					}
				}
				projectListBox.Visible = true;
			}
			else if (Equals(type, "sleep"))
			{
				messagePanelText.Text = "Congratulations! You've reached the end of your work day.\nShould I stop the timer?";
				this.Text = "Wake Alert";
				okayButton.Text = "Yes";
				closeButton.Text = "No";
				projectListBox.Visible = false;
			}
			this.Visible = true;
		}

		private void MessagePanel_Load(object sender, EventArgs e)
		{

		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}

		private void okayButton_Click(object sender, EventArgs e)
		{
			if (type == "wake")
			{
				timer.SetProject(projectListBox.Text);
				this.Visible = false;
			}
			else if (type == "sleep")
			{
				timer.DoStop();
				this.Visible = false;
			}
		}
	}
}
