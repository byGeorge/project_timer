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
				messagePanelText.Text = "Hello! \n\nWhat would you like to work on?";
				okayButton.Visible = false;
				closeButton.Visible = true;
				closeButton.Text = "Close";
				BackColor = Color.Yellow;
			}
			else if (Equals(type, "sleep"))
			{
				messagePanelText.Text = "Congratulations! You've reached \nthe end of your work day.\n\nShould I stop the timer?";
				this.Text = "Wake Alert";
				okayButton.Visible = true;
				closeButton.Visible = true;
				BackColor = Color.Navy;
				ForeColor = Color.White;
				okayButton.ForeColor = Color.Navy;
				closeButton.ForeColor = Color.Navy;
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
				timer.projectListCombobox.Focus();
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
