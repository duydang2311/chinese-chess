using System;
using System.Windows.Forms;
using System.Drawing;

namespace ChineseChess {
	public partial class MainForm : Form {
		private void Game_OnNew(object sender, EventArgs e) {
			GameForm form = GameForm.Prompt(this);
			if(this.game != null) {
				this.Controls.Remove(this.game);
				this.game.Dispose();
			}
			this.game = new Game(this.panelGame, new Board(this.panelGame.Size.Width * 0.8f, new PointF(this.panelGame.Size.Width * 0.2f / 2, this.panelGame.Size.Height * 0.2f / 2)));
		}
	}
}
