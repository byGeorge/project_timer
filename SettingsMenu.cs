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
				TimeValidator.ConvertTo12(this);
			}
		}

		private void hour24Button_CheckedChanged(object sender, EventArgs e)
		{
			if (hour24Button.Checked)
			{
				toAmPmLabel.Visible = false;
				fromAmPmLabel.Visible = false;
				TimeValidator.ConvertTo24(this);
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
		}

		private void toTimeTextBox_Leave(object sender, EventArgs e)
		{
			var time = toTimeTextBox.Text;
			if (hour12Button.Checked)
			{
				TimeValidator.SetAmPm(this, time, "to");
			}
			toTimeTextBox.Text = TimeValidator.validateTime(time, this);
		}
	}
}
