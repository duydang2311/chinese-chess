using System.Collections.Generic;
namespace ChineseChess {
    class Player {
        private string name;
        private Color color;
        private List<Piece> pieces;
        public Player(string name) {
            this.name = name;
            this.pieces = new List<Piece>();
        }
        public string Name {
            get => this.name;
            set { this.name = value; }
        }
        public Color Color {
            get => this.color;
            set { this.color = value; }
        }
        public List<Piece> Pieces {
            get => this.pieces;
        }
        public void AddPiece(Piece piece) {
            this.pieces.Add(piece);
        }
        public void RemovePiece(Piece piece) {
            int index = this.pieces.IndexOf(piece);
            if(index == -1) return;
            this.pieces.RemoveAt(index);
        }
    }
}