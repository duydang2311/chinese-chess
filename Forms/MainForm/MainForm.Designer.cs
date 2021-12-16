
namespace ChineseChess
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuItemGame = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemGame_New = new System.Windows.Forms.ToolStripMenuItem();
			this.panelGame = new System.Windows.Forms.Panel();
			this.panelStats = new System.Windows.Forms.Panel();
			this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mediaFromLocalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mediaFromYouTubeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame,
            this.mediaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(780, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuItemGame
			// 
			this.menuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame_New});
			this.menuItemGame.Name = "menuItemGame";
			this.menuItemGame.Size = new System.Drawing.Size(50, 20);
			this.menuItemGame.Text = "Game";
			// 
			// menuItemGame_New
			// 
			this.menuItemGame_New.Name = "menuItemGame_New";
			this.menuItemGame_New.Size = new System.Drawing.Size(180, 22);
			this.menuItemGame_New.Text = "New";
			// 
			// panelGame
			// 
			this.panelGame.Location = new System.Drawing.Point(0, 24);
			this.panelGame.Name = "panelGame";
			this.panelGame.Size = new System.Drawing.Size(480, 540);
			this.panelGame.TabIndex = 1;
			// 
			// panelStats
			// 
			this.panelStats.Location = new System.Drawing.Point(480, 24);
			this.panelStats.Name = "panelStats";
			this.panelStats.Size = new System.Drawing.Size(300, 540);
			this.panelStats.TabIndex = 2;
			// 
			// mediaToolStripMenuItem
			// 
			this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaFromLocalMenuItem,
            this.mediaFromYouTubeMenuItem});
			this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
			this.mediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.mediaToolStripMenuItem.Text = "Media";
			// 
			// mediaFromLocalMenuItem
			// 
			this.mediaFromLocalMenuItem.Name = "mediaFromLocalMenuItem";
			this.mediaFromLocalMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mediaFromLocalMenuItem.Text = "From Local";
			// 
			// mediaFromYouTubeMenuItem
			// 
			this.mediaFromYouTubeMenuItem.Name = "mediaFromYouTubeMenuItem";
			this.mediaFromYouTubeMenuItem.Size = new System.Drawing.Size(180, 22);
			this.mediaFromYouTubeMenuItem.Text = "From YouTube";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 564);
			this.Controls.Add(this.panelGame);
			this.Controls.Add(this.panelStats);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(796, 603);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuItemGame;
		private System.Windows.Forms.ToolStripMenuItem menuItemGame_New;
		private System.Windows.Forms.Panel panelGame;
		private System.Windows.Forms.Panel panelStats;
		private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mediaFromLocalMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mediaFromYouTubeMenuItem;
	}
}

