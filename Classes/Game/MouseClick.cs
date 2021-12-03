using System.Windows.Forms;

namespace ChineseChess {
    partial class Game : PictureBox {
		protected override void OnMouseClick(MouseEventArgs e) {
			if(board.OnMouseClick()) {
				this.Refresh();
			}
			base.OnMouseClick(e);
		}
    }
}