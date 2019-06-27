namespace TimerClient
{
	partial class MessagePanel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagePanel));
			this.messagePanelText = new System.Windows.Forms.Label();
			this.okayButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.projectListBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// messagePanelText
			// 
			this.messagePanelText.AutoSize = true;
			this.messagePanelText.Location = new System.Drawing.Point(5, 8);
			this.messagePanelText.Name = "messagePanelText";
			this.messagePanelText.Size = new System.Drawing.Size(0, 13);
			this.messagePanelText.TabIndex = 0;
			// 
			// okayButton
			// 
			this.okayButton.Location = new System.Drawing.Point(8, 84);
			this.okayButton.Name = "okayButton";
			this.okayButton.Size = new System.Drawing.Size(75, 23);
			this.okayButton.TabIndex = 1;
			this.okayButton.Text = "OK";
			this.okayButton.UseVisualStyleBackColor = true;
			this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.Location = new System.Drawing.Point(90, 84);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(75, 23);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "Cancel";
			this.closeButton.UseMnemonic = false;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// projectListBox
			// 
			this.projectListBox.FormattingEnabled = true;
			this.projectListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.projectListBox.Location = new System.Drawing.Point(13, 57);
			this.projectListBox.Name = "projectListBox";
			this.projectListBox.Size = new System.Drawing.Size(121, 21);
			this.projectListBox.TabIndex = 3;
			// 
			// MessagePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(339, 119);
			this.ControlBox = false;
			this.Controls.Add(this.projectListBox);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.okayButton);
			this.Controls.Add(this.messagePanelText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MessagePanel";
			this.Text = "Notification";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MessagePanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label messagePanelText;
		private System.Windows.Forms.Button okayButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.ComboBox projectListBox;
	}
}