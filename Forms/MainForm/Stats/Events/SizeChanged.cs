namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using System.Drawing;
	public partial class MainForm : Form {
        private void PanelStats_OnSizeChanged(object sender, EventArgs e) {
            if(this.game is null) return;
            this.OrganizeStatsControls();
            this.OrganizeWebPanel();
            this.topPictureBox.Refresh();
            this.bottomPictureBox.Refresh();
        }
	}
}
