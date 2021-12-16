using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace ChineseChess {
	public partial class MainForm : Form {
		private void Game_OnNew(object sender, EventArgs e) {
			using(GameForm form = new GameForm()) {
				switch(form.ShowDialog(this)) {
					case DialogResult.OK: {
						if(this.game != null) {
							this.game.Dispose();
						}
						int sides = Enum.GetNames(typeof(Side)).Length;
						SideColor[] sideColors = new SideColor[sides];
						Player[] sidePlayers = new Player[sides];
						sidePlayers[(int)form.BlackSide] = new Player(form.BlackName, form.BlackIsAI);
						sidePlayers[(int)form.RedSide] = new Player(form.RedName, form.RedIsAI);
						sideColors[(int)form.BlackSide] = SideColor.Black; 
						sideColors[(int)form.RedSide] = SideColor.Red; 
						this.game = new Game(this.panelGame, sidePlayers, sideColors, new Board(ChineseChess.Properties.Resources.board_trans, this.panelGame.Size.Width * 0.8f, new PointF(this.panelGame.Size.Width * 0.2f / 2, this.panelGame.Size.Height * 0.2f / 2)));
						this.game.Board.Game = this.game;
						this.InitStats();
						break;
					}
				}
			}
		}
	}
}
