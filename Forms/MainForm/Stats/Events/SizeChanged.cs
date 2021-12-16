namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using System.Drawing;
	public partial class MainForm : Form {
        private void PanelStats_OnSizeChanged(object sender, EventArgs e) {
            if(this.webPanel is not null) {
                this.OrganizeWebPanel();
            }
            if(this.player is not null) {
                this.OrganizePlayerControls();
            }
            if(this.game is not null) {
                this.OrganizeStatsControls();
                this.topPictureBox.Refresh();
                this.bottomPictureBox.Refresh();
            }
        }
	}
}
