namespace ChineseChess {
	using System.Drawing;
	using System.Windows.Forms;
	partial class Game : PictureBox {
		private Panel panel;
		private Player[] sidePlayers;
		private SideColor[] sideColors;
		private float[] sidePoints;
		private Board board;
		private bool ended;
		public Game(Panel panel, Player[] sidePlayers, SideColor[] sideColors, Board board) : base() {
			this.panel = panel;
			this.sidePlayers = sidePlayers;
			this.sideColors = sideColors;
			this.sidePoints = new float[2]{0f, 0f};
			this.board = board;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new Size(panel.ClientSize.Width, panel.ClientSize.Height);
			this.DoubleBuffered = true;
			this.ended = false;
			panel.Controls.Add(this);
			panel.Resize += this.Panel_Resize;

			this.board.Setup();
			this.SwitchTurn();
			this.Panel_Resize(null, null);
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
		public bool Ended {
			get => this.ended;
		}
		public void End() {
			if(this.sidePoints[(int)Side.Top] > this.sidePoints[(int)Side.Bottom]) {
				MessageBox.Show("The winner of this match is: " + this.SidePlayers[(int)Side.Top].Name);
			} else if(this.sidePoints[(int)Side.Bottom] > this.sidePoints[(int)Side.Top]) {
				MessageBox.Show("The winner of this match is: " + this.SidePlayers[(int)Side.Bottom].Name);
			} else {
				MessageBox.Show("The result of this match is: Draw");
			}
			for(int i = 0; i != 2; ++i) {
				this.sidePlayers[i].Timer.Enabled = false;
				this.sidePlayers[i].Timer.Dispose();
			}
			this.ended = true;
		}
		public void UpdateSidePoint(Piece piece) {
			Side side = (piece.Side == Side.Top) ? Side.Bottom : Side.Top;
			float point = 0;
			switch(piece.Type) {
				case Pieces.Soldier: {
					Direction min = new Direction(0, (Board.Rows - 5) * (int)side);
					Direction max = new Direction(Board.Cols + 1, (Board.Rows - 5) * (int)side + 5);
					if(DirectionHelper.Validate(piece, new Direction(0, 0), min, max)) {
						point = 2f;
					} else {
						point = 1f;
					}
					break;
				}
				case Pieces.Horse: {
					point = 4f;
					break;
				}
				case Pieces.Chariot: {
					point = 9f;
					break;
				}
				case Pieces.Cannon: {
					point = 4.5f;
					break;
				}
				case Pieces.Guard:
				case Pieces.Elephant: {
					point = 2f;
					break;
				}
				case Pieces.General: {
					point = 100f;
					break;
				}
			}
			this.sidePoints[(int)side] += point;
		}
	}
}
