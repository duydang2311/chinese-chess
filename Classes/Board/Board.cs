using System.Drawing;

namespace ChineseChess {
    class Board {
        public const float WIDTH_HEIGHT_RATIO = 1.125F;
        public const int ROWS = 10;
        public const int COLS = 9;
        private float size;
        private PointF location;
        private Player[] players;
        public Board(float size, PointF location) {
            this.size = size;
            this.location = location;
            this.players = new Player[System.Enum.GetNames(typeof(Side)).Length];
        }
        public float Width {
            get => this.size;
            set { this.size = value; }
        }
        public float Height {
            get => this.size * Board.WIDTH_HEIGHT_RATIO;
            set { this.size = value / Board.WIDTH_HEIGHT_RATIO; }
        }
        public Player[] Players {
            get => this.players;
        }
        public PointF Location {
            get => this.location;
            set { this.location = value; }
        }
        public void AddPlayer(Side side, Player player) {
            this.players[(int)side] = player;
        }
        public Player GetPlayer(Side side) {
            int index = (int)side;
            if(index < 0 && index >= this.players.Length) return null;
            return this.players[index];
        }
        public void Draw(Graphics graphics) {
            graphics.DrawImage(ChineseChess.Properties.Resources.board_trans, this.location.X, this.location.Y, this.Width, this.Height);
        }
    }
}