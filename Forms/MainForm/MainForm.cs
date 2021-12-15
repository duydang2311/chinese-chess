﻿using System.Windows.Forms;

namespace ChineseChess {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			this.menuItemGame_New.Click += Game_OnNew;
			this.Resize += MainForm_OnResize;
			this.panelStats.SizeChanged += PanelStats_OnSizeChanged;
		}
	}
}
