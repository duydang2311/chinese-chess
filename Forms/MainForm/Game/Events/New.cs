using System;
using System.Windows.Forms;
using System.Drawing;

namespace ChineseChess {
	public partial class MainForm : Form {
		private void Game_OnNew(object sender, EventArgs e) {
			GameForm form = GameForm.Prompt(this);
			switch(form.DialogResult) {
				case DialogResult.OK: {
					if(this.game != null) {
						this.Controls.Remove(this.game);
						this.game.Dispose();
					}
					int sides = Enum.GetNames(typeof(Side)).Length;
					Color[] sideColors = new Color[sides];
					Player[] sidePlayers = new Player[sides];
					sidePlayers[(int)form.BlackSide] = new Player(form.BlackName, form.BlackIsAI);
					sidePlayers[(int)form.RedSide] = new Player(form.RedName, form.RedIsAI);
					sideColors[(int)form.BlackSide] = Color.Black; 
					sideColors[(int)form.RedSide] = Color.Red; 
					this.game = new Game(this.panelGame, sidePlayers, sideColors, new Board(this.panelGame.Size.Width * 0.8f, new PointF(this.panelGame.Size.Width * 0.2f / 2, this.panelGame.Size.Height * 0.2f / 2)));
					break;
				}
			}
		}
	}
}
