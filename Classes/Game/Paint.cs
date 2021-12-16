
using System.Windows.Forms;

namespace ChineseChess {
    partial class Game : PictureBox {
		protected override void OnPaint(PaintEventArgs e) {
			e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			base.OnPaint(e);
			this.board.Draw(this.sideColors, e.Graphics);

			float cellWidth = this.board.Width / Board.Cols;
			float cellHeight = this.board.Height / Board.Rows;
			if(this.panel.Size.Width - this.board.Width - this.board.Location.X > cellWidth * 2 + this.board.Location.X) {
				this.board.DrawCaptured(this.sideColors, e.Graphics, (int)((this.panel.Size.Width - this.board.Width - this.board.Location.X) / (cellWidth * 2 + this.board.Location.X)) - 1);
			} else if(this.panel.Size.Height - this.board.Height - this.board.Location.Y > cellHeight * 2 + this.board.Location.Y) {
				this.board.DrawCaptured(this.sideColors, e.Graphics, (int)((this.panel.Size.Height - this.board.Height - this.board.Location.Y) / (cellHeight * 2 + this.board.Location.Y)) - 1, false);
			}
		}
    }
}