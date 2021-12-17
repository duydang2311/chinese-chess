namespace ChineseChess {
    using System;
    using System.Drawing;
    partial class Piece {
        private Board board;
        private Pieces type;
        private Direction location;
        private Color highlight;
        private Side side;
        public Piece(Board board, Pieces type, Side side) {
            this.board = board;
            this.type = type;
            this.highlight = Color.Transparent;
            this.location = new Direction(0, 0);
            this.side = side;
        }
        public Piece(Board board, Pieces type, Side side, Direction location) {
            this.board = board;
            this.type = type;
            this.highlight = Color.Transparent;
            this.side = side;
            this.location = location;
        }
        public Board Board {
            get => this.board;
        }
        public Pieces Type {
            get => this.type;
            set { this.type = value; }
        }
        public Direction Location {
            get => this.location;
            set { this.location = value; }
        }
        public Color Highlight {
            get => this.highlight;
            set { this.highlight = value; }
        }
        public Side Side {
            get => this.side;
            set { this.side = value; }
        }
        public void Draw(SideColor color, Graphics graphics) {
            PointF location = BoardHelper.GetLocation(this.board, this.location.X, this.location.Y);
            float diameter = this.board.Width / Board.Cols;
            location.X -= diameter / 2;
            location.Y -= diameter / 2;
            graphics.DrawImage(PieceHelper.GetImage(color, this.type), location.X, location.Y, diameter, diameter);
            if(this.highlight != Color.Transparent) {
                using(Brush brush = new SolidBrush(Color.FromArgb(150, this.highlight.R, this.highlight.G, this.highlight.B))) {
                    graphics.FillEllipse(brush, location.X, location.Y, diameter, diameter);
                }
            }
        }
        public bool IsPointCollided(float x, float y) {
            PointF location = BoardHelper.GetLocation(this.board, this.location.X, this.location.Y);
            float radius = (this.board.Width / Board.Cols) / 2;
            float vx = location.X - x;
            float vy = location.Y - y;
            return ((vx * vx + vy * vy) <= radius * radius);
        }
        public Piece Capture(int x, int y) {
            Piece res = null;
            int index = 0;
            for(int i = 0, length = Enum.GetNames(typeof(Side)).Length; i != length; ++i) {
                foreach(Piece p in this.board.Sides[i]) {
                    if(p.Location.X == x && p.Location.Y == y) {
                        index = i;
                        res = p;
                        break;
                    }
                }
            }
            if(res is not null && res != this) {
                this.board.Sides[index].Remove(res);
            }
            this.Location = new Direction(x, y);
            return res;
        }
    }
}