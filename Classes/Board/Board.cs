using System.Drawing;
using System.Collections.Generic;

namespace ChineseChess {
    partial class Board {
        public const float WidthHeightRatio = 1.125F;
        public const int Rows = 10;
        public const int Cols = 9;
        private float size;
        private PointF location;
        private List<Piece>[] sides;
        private Image image;
        public Board(Image image, float size, PointF location) {
            int length = System.Enum.GetNames(typeof(Side)).Length;
            this.size = size;
            this.location = location;
            this.sides = new List<Piece>[length];
            this.image = image;
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
        public void Setup() {
			const float MAX_SIZE = 80f;
            int i = 0;
            ChineseChess.Properties.Resources.board_trans.SetResolution(788 / Board.WidthHeightRatio, 788);
			ChineseChess.Properties.Resources.red_cannon.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.red_chariot.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.red_general.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.red_elephant.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.red_guard.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.red_horse.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.red_soldier.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.black_cannon.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.black_chariot.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.black_general.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.black_elephant.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.black_guard.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.black_horse.SetResolution(MAX_SIZE, MAX_SIZE);
			ChineseChess.Properties.Resources.black_soldier.SetResolution(MAX_SIZE, MAX_SIZE);
            foreach(List<Piece> list in sides) {
                list.Clear();
                list.Add(new Piece(this, Pieces.General, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2))));
                list.Add(new Piece(this, Pieces.Guard, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) - 1)));
                list.Add(new Piece(this, Pieces.Guard, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) + 1)));
                list.Add(new Piece(this, Pieces.Elephant, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) - 2)));
                list.Add(new Piece(this, Pieces.Elephant, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) + 2)));
                list.Add(new Piece(this, Pieces.Horse, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) - 3)));
                list.Add(new Piece(this, Pieces.Horse, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) + 3)));
                list.Add(new Piece(this, Pieces.Chariot, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) - 4)));
                list.Add(new Piece(this, Pieces.Chariot, new Point(i * (Board.Rows - 1), (int)(Board.Cols / 2) + 4)));
                list.Add(new Piece(this, Pieces.Cannon, new Point(i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 2, (int)(Board.Cols / 2) - 3)));
                list.Add(new Piece(this, Pieces.Cannon, new Point(i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 2, (int)(Board.Cols / 2) + 3)));
                list.Add(new Piece(this, Pieces.Soldier, new Point(i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3, (int)(Board.Cols / 2) - 4)));
                list.Add(new Piece(this, Pieces.Soldier, new Point(i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3, (int)(Board.Cols / 2) - 2)));
                list.Add(new Piece(this, Pieces.Soldier, new Point(i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3, (int)(Board.Cols / 2))));
                list.Add(new Piece(this, Pieces.Soldier, new Point(i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3, (int)(Board.Cols / 2) + 2)));
                list.Add(new Piece(this, Pieces.Soldier, new Point(i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3, (int)(Board.Cols / 2) + 4)));
                ++i;
            }
        }
        public void AddPiece(Side side, Piece piece) {
            this.sides[(int)side].Add(piece);
        }
        public void RemovePiece(Side side, Piece piece) {
            int index = this.sides[(int)side].IndexOf(piece);
            if(index == -1) return;
            this.sides[(int)side].RemoveAt(index);
        }
        public void Draw(SideColor[] colors, Graphics graphics) {
            graphics.DrawImage(this.image, this.location.X, this.location.Y, this.Width, this.Height);
            for(int i = 0 ; i != this.sides.Length; ++i) {
                foreach(Piece piece in this.sides[i]) {
                    piece.Draw(colors[i], graphics);
                }
            }
        }
    }
}
