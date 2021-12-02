using System.Drawing;

namespace ChineseChess {
    class Piece {
        public const float Width = 50f;
        public const float Height = 50f;
        private Board board;
        private Pieces type;
        private Point location;
        public Piece(Board board, Pieces type) {
            this.board = board;
            this.type = type;
            this.location = new Point(0, 0);
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
        public void Draw(Color color, Graphics graphics) {
            PointF location = BoardHelper.GetLocation(this.board, this.location.X, this.location.Y);
            graphics.DrawImage(PieceHelper.GetImage(color, this.type), location.X, location.Y, Piece.Width, Piece.Height);
        }
    }
}