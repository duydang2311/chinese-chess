
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(769, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			//menuItemGame 
			// 
			this.menuItemGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame_New});
			this.menuItemGame.Name = "menuItemGame";
			this.menuItemGame.Size = new System.Drawing.Size(50, 20);
			this.menuItemGame.Text = "Game";
			// 
			//menuItemGame_New 
			// 
			this.menuItemGame_New.Name = "menuItemGame_New";
			this.menuItemGame_New.Size = new System.Drawing.Size(98, 22);
			this.menuItemGame_New.Text = "New";
			// 
			//panelGame 
			// 
			this.panelGame.Location = new System.Drawing.Point(0, 24);
			this.panelGame.Name = "panelGame";
			this.panelGame.Size = new System.Drawing.Size(493, 617);
			this.panelGame.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(493, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(276, 617);
			this.panel2.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 641);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelGame);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
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
		private System.Windows.Forms.Panel panel2;
	}
}

