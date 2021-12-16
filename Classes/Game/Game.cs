namespace ChineseChess {
	using System.Drawing;
	using System.Windows.Forms;
	partial class Game : PictureBox {
		private Panel panel;
		private Player[] sidePlayers;
		private SideColor[] sideColors;
		private Board board;
		public Game(Panel panel, Player[] sidePlayers, SideColor[] sideColors, Board board) : base() {
			this.panel = panel;
			this.sidePlayers = sidePlayers;
			this.sideColors = sideColors;
			this.board = board;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new Size(panel.ClientSize.Width, panel.ClientSize.Height);
			this.DoubleBuffered = true;
			panel.Controls.Add(this);
			panel.Resize += this.Panel_Resize;

			this.board.Setup();
			this.SwitchTurn();
		}
		public Board Board {
			get => this.board;
			set { this.board = value; }
		}
		public Player[] SidePlayers {
			get => this.sidePlayers;
		}
		public SideColor[] SideColors {
			get => this.sideColors;
		}
	}
}
