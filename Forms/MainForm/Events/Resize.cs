
namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using System.Drawing;
	public partial class MainForm : Form {
        private void MainForm_OnResize(object sender, EventArgs e) {
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height - 24;
            this.panelGame.Size = new Size((int)(width * 0.6), height);
            this.panelStats.Location = new Point((int)(width * 0.6), 24);
            this.panelStats.Size = new Size((int)(width * 0.4), height);
        }
	}
}
