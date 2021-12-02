using System.Drawing;
using System.Collections.Generic;

namespace ChineseChess {
    class Board {
        public const float WidthHeightRatio = 1.125F;
        public const int Rows = 10;
        public const int Cols = 9;
        private float size;
        private PointF location;
        private List<Piece>[] sides;
        public Board(float size, PointF location) {
            int length = System.Enum.GetNames(typeof(Side)).Length;
            this.size = size;
            this.location = location;
            this.sides = new List<Piece>[length];
            for(int i = 0; i != length; ++i) {
                this.sides[i] = new List<Piece>();
            }
        }
        public float Width {
            get => this.size;
            set { this.size = value; }
        }
        public float Height {
            get => this.size * Board.WidthHeightRatio;
            set { this.size = value / Board.WidthHeightRatio; }
        }
        public List<Piece>[] Sides {
            get => this.sides;
        }
        public PointF Location {
            get => this.location;
            set { this.location = value; }
        }
        public void AddPiece(Side side, Piece piece) {
            this.sides[(int)side].Add(piece);
        }
        public void RemovePiece(Side side, Piece piece) {
            int index = this.sides[(int)side].IndexOf(piece);
            if(index == -1) return;
            this.sides[(int)side].RemoveAt(index);
        }
        public void Draw(Color[] colors, Graphics graphics) {
            graphics.DrawImage(ChineseChess.Properties.Resources.board_trans, this.location.X, this.location.Y, this.Width, this.Height);
			for(int i = 0; i != Board.Rows; ++i) {
				for(int j = 0; j != Board.Cols; ++j) {
					graphics.DrawEllipse(new Pen(System.Drawing.Color.Red), BoardHelper.GetLocation(this, i, j).X, BoardHelper.GetLocation(this, i, j).Y, 10, 10);
				}
			}
            for(int i = 0 ; i != this.sides.Length; ++i) {
                foreach(Piece piece in this.sides[i]) {
                    piece.Draw(colors[i], graphics);
                }
            }
        }
    }
}
