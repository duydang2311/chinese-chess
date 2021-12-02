using System;
using System.Drawing;
using System.Windows.Forms;

namespace ChineseChess {
	class Game : PictureBox {
		private Panel panel;
		private Board board;
		public Game(Panel panel, Board board) : base() {
			this.panel = panel;
			this.board = board;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new Size(panel.ClientSize.Width, panel.ClientSize.Height);
			panel.Controls.Add(this);
			panel.Resize += Panel_Resize;
		}
		public Board Board {
			get => this.board;
			set { this.board = value; }
		}
		protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			board.Draw(e.Graphics);
		}
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
