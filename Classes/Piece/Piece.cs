using System.Drawing;

namespace ChineseChess {
    class Piece {
        public const float Width = 50f;
        public const float Height = 50f;
        private Board board;
        private Pieces type;
        private Point location;
        private Color highlight;
        public Piece(Board board, Pieces type) {
            this.board = board;
            this.type = type;
            this.highlight = Color.Transparent;
            this.location = new Point(0, 0);
        }
        public Piece(Board board, Pieces type, Point location) {
            this.board = board;
            this.type = type;
            this.highlight = Color.Transparent;
            this.location = location;
        }
        public Board Board {
            get => this.board;
        }
        public Pieces Type {
            get => this.type;
            set { this.type = value; }
        }
        public Point Location {
            get => this.location;
            set { this.location = value; }
        }
        public Color Highlight {
            get => this.highlight;
            set { this.highlight = value; }
        }
        public void Draw(SideColor color, Graphics graphics) {
            PointF location = BoardHelper.GetLocation(this.board, this.location.X, this.location.Y);
            float diameter = this.board.Width / Board.Cols;
            location.X -= diameter / 2;
            location.Y -= diameter / 2;
            graphics.DrawImage(PieceHelper.GetImage(color, this.type), location.X, location.Y, diameter, diameter);
            if(this.highlight != Color.Transparent) {
                using(Brush brush = new SolidBrush(Color.FromArgb(150, this.highlight.R, this.highlight.G, this.highlight.B))) {
                    graphics.FillEllipse(brush, location.X - 1, location.Y - 1, diameter + 2, diameter + 2);
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
    }
}