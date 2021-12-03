using System.Windows.Forms;

namespace ChineseChess {
    partial class Game : PictureBox {
		protected override void OnMouseMove(MouseEventArgs e) {
			board.OnMouseMove(e.X, e.Y);
			base.OnMouseMove(e);
		}
    }
}