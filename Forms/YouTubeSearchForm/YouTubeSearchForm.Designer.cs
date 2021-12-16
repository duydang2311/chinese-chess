
namespace ChineseChess
{
	partial class YouTubeSearchForm
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
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.cancelButton = new System.Windows.Forms.Button();
			this.playButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(13, 13);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.PlaceholderText = "Type a song name...";
			this.searchTextBox.Size = new System.Drawing.Size(278, 23);
			this.searchTextBox.TabIndex = 0;
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(216, 42);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// playButton
			// 
			this.playButton.Location = new System.Drawing.Point(135, 42);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(75, 23);
			this.playButton.TabIndex = 2;
			this.playButton.Text = "Play";
			this.playButton.UseVisualStyleBackColor = true;
			// 
			// YouTubeSearchForm
			// 
			this.AcceptButton = this.playButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(303, 74);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.searchTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "YouTubeSearchForm";
			this.Text = "YouTubeSearchForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button playButton;
	}
}