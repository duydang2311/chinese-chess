namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using System.Drawing;
	public partial class MainForm : Form {
        private void PanelStats_OnSizeChanged(object sender, EventArgs e) {
            this.OrganizeStatsControls();
            this.topPictureBox.Refresh();
            this.bottomPictureBox.Refresh();
        }
	}
}
