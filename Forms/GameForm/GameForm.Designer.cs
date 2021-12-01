
namespace ChineseChess
{
	partial class GameForm
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
			this.panelRed = new System.Windows.Forms.Panel();
			this.checkboxRedAI = new System.Windows.Forms.CheckBox();
			this.comboBoxRedSide = new System.Windows.Forms.ComboBox();
			this.labelRedSide = new System.Windows.Forms.Label();
			this.labelRedName = new System.Windows.Forms.Label();
			this.textBoxRedName = new System.Windows.Forms.TextBox();
			this.labelRed = new System.Windows.Forms.Label();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.checkboxBlackAI = new System.Windows.Forms.CheckBox();
			this.labelBlack = new System.Windows.Forms.Label();
			this.comboBoxBlackSide = new System.Windows.Forms.ComboBox();
			this.textBoxBlackName = new System.Windows.Forms.TextBox();
			this.labelBlackSide = new System.Windows.Forms.Label();
			this.labelBlackName = new System.Windows.Forms.Label();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.panelRed.SuspendLayout();
			this.panelBlack.SuspendLayout();
			this.SuspendLayout();
			// 
			//panelRed 
			// 
			this.panelRed.Controls.Add(this.checkboxRedAI);
			this.panelRed.Controls.Add(this.comboBoxRedSide);
			this.panelRed.Controls.Add(this.labelRedSide);
			this.panelRed.Controls.Add(this.labelRedName);
			this.panelRed.Controls.Add(this.textBoxRedName);
			this.panelRed.Controls.Add(this.labelRed);
			this.panelRed.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.panelRed.Location = new System.Drawing.Point(12, 12);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(263, 190);
			this.panelRed.TabIndex = 0;
			// 
			//checkboxRedAI 
			// 
			this.checkboxRedAI.AutoSize = true;
			this.checkboxRedAI.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkboxRedAI.Location = new System.Drawing.Point(80, 160);
			this.checkboxRedAI.Name = "checkboxRedAI";
			this.checkboxRedAI.Size = new System.Drawing.Size(44, 24);
			this.checkboxRedAI.TabIndex = 7;
			this.checkboxRedAI.Text = "AI";
			this.checkboxRedAI.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBoxRedSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRedSide.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboBoxRedSide.FormattingEnabled = true;
			this.comboBoxRedSide.Items.AddRange(new object[] {
            "Top",
            "Bottom"});
			this.comboBoxRedSide.Location = new System.Drawing.Point(80, 119);
			this.comboBoxRedSide.Name = "comboBoxRedSide";
			this.comboBoxRedSide.Size = new System.Drawing.Size(180, 27);
			this.comboBoxRedSide.TabIndex = 6;
			// 
			//labelRedSide 
			// 
			this.labelRedSide.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelRedSide.ForeColor = System.Drawing.Color.Black;
			this.labelRedSide.Location = new System.Drawing.Point(0, 120);
			this.labelRedSide.Name = "labelRedSide";
			this.labelRedSide.Size = new System.Drawing.Size(80, 25);
			this.labelRedSide.TabIndex = 3;
			this.labelRedSide.Text = "Side";
			this.labelRedSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			//labelRedName 
			// 
			this.labelRedName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelRedName.ForeColor = System.Drawing.Color.Black;
			this.labelRedName.Location = new System.Drawing.Point(0, 78);
			this.labelRedName.Name = "labelRedName";
			this.labelRedName.Size = new System.Drawing.Size(80, 25);
			this.labelRedName.TabIndex = 2;
			this.labelRedName.Text = "Name";
			this.labelRedName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			//textBoxRedName 
			// 
			this.textBoxRedName.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxRedName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxRedName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxRedName.Location = new System.Drawing.Point(80, 80);
			this.textBoxRedName.Name = "textBoxRedName";
			this.textBoxRedName.Size = new System.Drawing.Size(180, 25);
			this.textBoxRedName.TabIndex = 1;
			// 
			//labelRed 
			// 
			this.labelRed.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelRed.ForeColor = System.Drawing.Color.Red;
			this.labelRed.Location = new System.Drawing.Point(3, 0);
			this.labelRed.Name = "labelRed";
			this.labelRed.Size = new System.Drawing.Size(260, 46);
			this.labelRed.TabIndex = 0;
			this.labelRed.Text = "RED";
			this.labelRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			//panelBlack 
			// 
			this.panelBlack.Controls.Add(this.checkboxBlackAI);
			this.panelBlack.Controls.Add(this.labelBlack);
			this.panelBlack.Controls.Add(this.comboBoxBlackSide);
			this.panelBlack.Controls.Add(this.textBoxBlackName);
			this.panelBlack.Controls.Add(this.labelBlackSide);
			this.panelBlack.Controls.Add(this.labelBlackName);
			this.panelBlack.Location = new System.Drawing.Point(297, 12);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(262, 190);
			this.panelBlack.TabIndex = 1;
			// 
			//checkboxBlackAI 
			// 
			this.checkboxBlackAI.AutoSize = true;
			this.checkboxBlackAI.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkboxBlackAI.Location = new System.Drawing.Point(80, 160);
			this.checkboxBlackAI.Name = "checkboxBlackAI";
			this.checkboxBlackAI.Size = new System.Drawing.Size(44, 24);
			this.checkboxBlackAI.TabIndex = 13;
			this.checkboxBlackAI.Text = "AI";
			this.checkboxBlackAI.UseVisualStyleBackColor = true;
			// 
			//labelBlack 
			// 
			this.labelBlack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelBlack.ForeColor = System.Drawing.Color.Black;
			this.labelBlack.Location = new System.Drawing.Point(3, 0);
			this.labelBlack.Name = "labelBlack";
			this.labelBlack.Size = new System.Drawing.Size(256, 46);
			this.labelBlack.TabIndex = 8;
			this.labelBlack.Text = "BLACK";
			this.labelBlack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			//comboBoxBlackSide 
			// 
			this.comboBoxBlackSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBlackSide.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.comboBoxBlackSide.FormattingEnabled = true;
			this.comboBoxBlackSide.Items.AddRange(new object[] {
            "Top",
            "Bottom"});
			this.comboBoxBlackSide.Location = new System.Drawing.Point(80, 119);
			this.comboBoxBlackSide.Name = "comboBoxBlackSide";
			this.comboBoxBlackSide.Size = new System.Drawing.Size(180, 27);
			this.comboBoxBlackSide.TabIndex = 12;
			// 
			//textBoxBlackName 
			// 
			this.textBoxBlackName.BackColor = System.Drawing.SystemColors.Control;
			this.textBoxBlackName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxBlackName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.textBoxBlackName.Location = new System.Drawing.Point(80, 80);
			this.textBoxBlackName.Name = "textBoxBlackName";
			this.textBoxBlackName.Size = new System.Drawing.Size(180, 25);
			this.textBoxBlackName.TabIndex = 9;
			// 
			//labelBlackSide 
			// 
			this.labelBlackSide.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelBlackSide.ForeColor = System.Drawing.Color.Black;
			this.labelBlackSide.Location = new System.Drawing.Point(0, 120);
			this.labelBlackSide.Name = "labelBlackSide";
			this.labelBlackSide.Size = new System.Drawing.Size(80, 25);
			this.labelBlackSide.TabIndex = 11;
			this.labelBlackSide.Text = "Side";
			this.labelBlackSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			//labelBlackName 
			// 
			this.labelBlackName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelBlackName.ForeColor = System.Drawing.Color.Black;
			this.labelBlackName.Location = new System.Drawing.Point(0, 80);
			this.labelBlackName.Name = "labelBlackName";
			this.labelBlackName.Size = new System.Drawing.Size(80, 25);
			this.labelBlackName.TabIndex = 10;
			this.labelBlackName.Text = "Name";
			this.labelBlackName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			//buttonCancel 
			// 
			this.buttonCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonCancel.Location = new System.Drawing.Point(490, 223);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(69, 24);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			//buttonOk 
			// 
			this.buttonOk.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.buttonOk.Location = new System.Drawing.Point(415, 223);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(69, 24);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			// 
			// GameForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(570, 294);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.panelBlack);
			this.Controls.Add(this.panelRed);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Name = "GameForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "New Game";
			this.panelRed.ResumeLayout(false);
			this.panelRed.PerformLayout();
			this.panelBlack.ResumeLayout(false);
			this.panelBlack.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelRed;
		private System.Windows.Forms.Panel panelBlack;
		private System.Windows.Forms.TextBox textBoxRedName;
		private System.Windows.Forms.Label labelRed;
		private System.Windows.Forms.Label labelRedName;
		private System.Windows.Forms.Label labelRedSide;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ComboBox comboBoxRedSide;
		private System.Windows.Forms.CheckBox checkboxRedAI;
		private System.Windows.Forms.CheckBox checkboxBlackAI;
		private System.Windows.Forms.Label labelBlack;
		private System.Windows.Forms.ComboBox comboBoxBlackSide;
		private System.Windows.Forms.TextBox textBoxBlackName;
		private System.Windows.Forms.Label labelBlackSide;
		private System.Windows.Forms.Label labelBlackName;
		private System.Windows.Forms.Button buttonOk;
	}
}