using System;
using System.Windows.Forms;
using System.Drawing;

namespace ChineseChess {
	public partial class MainForm : Form {
		private void Game_OnNew(object sender, EventArgs e) {
			if(this.game != null) {
				this.Controls.Remove(this.game);
				this.game.Dispose();
			}
			this.game = new Game(new Board(400, new PointF(5, 5)));
			this.game.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
			this.panelGame.Controls.Add(this.game);
		}
	}
}
