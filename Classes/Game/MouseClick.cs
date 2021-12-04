using System.Windows.Forms;

namespace ChineseChess {
    partial class Game : PictureBox {
		protected override void OnMouseClick(MouseEventArgs e) {
			if(board.OnMouseClick(e.Location.X, e.Location.Y)) {
				this.Refresh();
			}
			base.OnMouseClick(e);
		}
    }
}