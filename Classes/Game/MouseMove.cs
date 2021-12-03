using System.Windows.Forms;

namespace ChineseChess {
    partial class Game : PictureBox {
		protected override void OnMouseMove(MouseEventArgs e) {
			if(board.OnMouseMove(e.X, e.Y)) {
				this.Refresh();
			}
			base.OnMouseMove(e);
		}
    }
}