
namespace ChineseChess {
    using System;
    using System.Drawing;
    using System.Windows.Forms;
	partial class Game : PictureBox {
		private void Panel_Resize(object sender, EventArgs e) {
			this.ClientSize = new Size(panel.ClientSize.Width, panel.ClientSize.Height);
			if(panel.ClientSize.Width * Board.WidthHeightRatio > panel.ClientSize.Height) {
				this.board.Height = this.panel.ClientSize.Height * 0.8f;
			} else {
				this.board.Width = this.panel.ClientSize.Width * 0.8f;
			}
			this.board.Location = new PointF(panel.ClientSize.Width * 0.2f / 2, panel.ClientSize.Height * 0.2f / 2);
			this.Refresh();
		}
	}
}
