using System.Drawing;

namespace ChineseChess {
    class Piece {
        public const float Width = 50f;
        public const float Height = 50f;
        private Pieces type;
        private Player player;
        private Point location;
        public Piece(Player player, Pieces type) {
            this.player = player;
            this.type = type;
            this.location = new Point(0, 0);
        }
        public Pieces Type {
            get => this.type;
            set { this.type = value; }
        }
        public Point Location {
            get => this.location;
            set { this.location = value; }
        }
        public Image Image {
            get => PieceHelper.GetImage(player.Color, this.type);
        }
        public void Draw(Color color, Graphics graphics) {
            PointF location = BoardHelper.GetLocation(this.player.Board, this.location.X, this.location.Y);
            graphics.DrawImage(PieceHelper.GetImage(color, this.type), location.X, location.Y, Piece.Width, Piece.Height);
        }
    }
}