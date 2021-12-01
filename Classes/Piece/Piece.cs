using System.Drawing;

namespace ChineseChess {
    class Piece {
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
            get => PieceHelper.GetImage(player.Side, this.type);
        }
    }
}