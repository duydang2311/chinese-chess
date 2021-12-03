
using System.Windows.Forms;

namespace ChineseChess {
    partial class Game : PictureBox {
		protected override void OnPaint(PaintEventArgs e) {
			e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
			e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
			base.OnPaint(e);
			board.Draw(this.sideColors, e.Graphics);
		}
    }
}