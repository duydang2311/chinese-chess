using System.Windows.Forms;

namespace ChineseChess {
	class Game : PictureBox {
		private Board board;
		public Game(Board board) : base() {
			this.board = board;
			MessageBox.Show(this.board.Width + " " + this.board.Height);
		}
		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			board.Draw(e.Graphics);
		}
	}
}
