namespace TimerClient
{
	partial class Timer
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
			this.startStopTimerButton = new System.Windows.Forms.Button();
			this.projectTimer = new System.Windows.Forms.Timer(this.components);
			this.projectNameLabel = new System.Windows.Forms.Label();
			this.addProjectButton = new System.Windows.Forms.Button();
			this.projectListCombobox = new System.Windows.Forms.ComboBox();
			this.addProjectTextbox = new System.Windows.Forms.TextBox();
			this.openFile = new System.Windows.Forms.Button();
			this.runningLabel = new System.Windows.Forms.Label();
			this.nowLabel = new System.Windows.Forms.Label();
			this.settingsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startStopTimerButton
			// 
			this.startStopTimerButton.Location = new System.Drawing.Point(16, 52);
			this.startStopTimerButton.Name = "startStopTimerButton";
			this.startStopTimerButton.Size = new System.Drawing.Size(75, 23);
			this.startStopTimerButton.TabIndex = 3;
			this.startStopTimerButton.Text = "Start";
			this.startStopTimerButton.UseVisualStyleBackColor = true;
			this.startStopTimerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.startStopTimerButton_MouseClick);
			// 
			// projectNameLabel
			// 
			this.projectNameLabel.AutoSize = true;
			this.projectNameLabel.BackColor = System.Drawing.Color.Black;
			this.projectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.projectNameLabel.ForeColor = System.Drawing.Color.LightGray;
			this.projectNameLabel.Location = new System.Drawing.Point(13, 12);
			this.projectNameLabel.Name = "projectNameLabel";
			this.projectNameLabel.Size = new System.Drawing.Size(51, 13);
			this.projectNameLabel.TabIndex = 0;
			this.projectNameLabel.Text = "Project:";
			// 
			// addProjectButton
			// 
			this.addProjectButton.AccessibleDescription = "Add Project Button";
			this.addProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.addProjectButton.Location = new System.Drawing.Point(197, 8);
			this.addProjectButton.Name = "addProjectButton";
			this.addProjectButton.Size = new System.Drawing.Size(23, 23);
			this.addProjectButton.TabIndex = 2;
			this.addProjectButton.Text = "+";
			this.addProjectButton.UseVisualStyleBackColor = true;
			this.addProjectButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addProjectButton_MouseClick);
			// 
			// projectListCombobox
			// 
			this.projectListCombobox.FormattingEnabled = true;
			this.projectListCombobox.Location = new System.Drawing.Point(70, 9);
			this.projectListCombobox.Name = "projectListCombobox";
			this.projectListCombobox.Size = new System.Drawing.Size(121, 21);
			this.projectListCombobox.TabIndex = 3;
			// 
			// addProjectTextbox
			// 
			this.addProjectTextbox.AccessibleDescription = "Add Project Textbox";
			this.addProjectTextbox.AccessibleName = "Input Project Name";
			this.addProjectTextbox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
			this.addProjectTextbox.Location = new System.Drawing.Point(70, 9);
			this.addProjectTextbox.Name = "addProjectTextbox";
			this.addProjectTextbox.Size = new System.Drawing.Size(121, 20);
			this.addProjectTextbox.TabIndex = 1;
			this.addProjectTextbox.Visible = false;
			// 
			// openFile
			// 
			this.openFile.Location = new System.Drawing.Point(145, 52);
			this.openFile.Name = "openFile";
			this.openFile.Size = new System.Drawing.Size(75, 23);
			this.openFile.TabIndex = 5;
			this.openFile.Text = "Open File";
			this.openFile.UseVisualStyleBackColor = true;
			this.openFile.Click += new System.EventHandler(this.openFile_Click);
			// 
			// runningLabel
			// 
			this.runningLabel.AutoSize = true;
			this.runningLabel.ForeColor = System.Drawing.Color.LightGray;
			this.runningLabel.Location = new System.Drawing.Point(13, 36);
			this.runningLabel.Name = "runningLabel";
			this.runningLabel.Size = new System.Drawing.Size(86, 13);
			this.runningLabel.TabIndex = 6;
			this.runningLabel.Text = "0:00:00 Stopped";
			this.runningLabel.Visible = false;
			// 
			// nowLabel
			// 
			this.nowLabel.AutoSize = true;
			this.nowLabel.ForeColor = System.Drawing.Color.LightGray;
			this.nowLabel.Location = new System.Drawing.Point(141, 36);
			this.nowLabel.Name = "nowLabel";
			this.nowLabel.Size = new System.Drawing.Size(62, 13);
			this.nowLabel.TabIndex = 7;
			this.nowLabel.Text = "Now: 13:30";
			// 
			// settingsButton
			// 
			this.settingsButton.AccessibleDescription = "Settings Button";
			this.settingsButton.AccessibleName = "Settings";
			this.settingsButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
			this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.settingsButton.Font = new System.Drawing.Font("Webdings", 9.75F);
			this.settingsButton.Location = new System.Drawing.Point(105, 52);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(29, 23);
			this.settingsButton.TabIndex = 4;
			this.settingsButton.Tag = "";
			this.settingsButton.Text = "@";
			this.settingsButton.UseVisualStyleBackColor = true;
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// Timer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(234, 87);
			this.Controls.Add(this.nowLabel);
			this.Controls.Add(this.runningLabel);
			this.Controls.Add(this.settingsButton);
			this.Controls.Add(this.openFile);
			this.Controls.Add(this.addProjectTextbox);
			this.Controls.Add(this.projectListCombobox);
			this.Controls.Add(this.addProjectButton);
			this.Controls.Add(this.projectNameLabel);
			this.Controls.Add(this.startStopTimerButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Timer";
			this.Text = "Project Timer";
			this.Load += new System.EventHandler(this.TimerBoard_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button startStopTimerButton;
		internal System.Windows.Forms.Timer projectTimer;
		internal System.Windows.Forms.Label projectNameLabel;
		internal System.Windows.Forms.Button addProjectButton;
		internal System.Windows.Forms.ComboBox projectListCombobox;
		internal System.Windows.Forms.TextBox addProjectTextbox;
		internal System.Windows.Forms.Button openFile;
		internal System.Windows.Forms.Button settingsButton;
		internal System.Windows.Forms.Label runningLabel;
		internal System.Windows.Forms.Label nowLabel;
	}
}