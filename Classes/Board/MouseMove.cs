using System.Drawing;

namespace ChineseChess {
    partial class Board {
        private Piece highlightedPiece;
        public Piece HighlightedPiece {
            get => this.highlightedPiece;
            set {
                if(this.highlightedPiece != null) {
                    if(this.highlightedPiece != this.selectedPiece) {
                        this.highlightedPiece.Highlight = Color.Transparent;
                    }
                }
                this.highlightedPiece = value;
                if(value != null) {
                    if(this.highlightedPiece != this.selectedPiece) {
                        this.highlightedPiece.Highlight = Color.Red;
                    }
                }
            }
        }
        public bool OnMouseMove(float x, float y) {
            if(this.game.Ended) {
                if(this.highlightedPiece is not null) {
                    this.HighlightedPiece = null;
                }
                return false;
            }
            Piece newHighlightedPiece = null;
            for(int i = 0 ; i != this.sides.Length; ++i) {
                foreach(Piece piece in this.sides[i]) {
                    if(piece.IsPointCollided(x, y) && piece.Side == this.game.TurnSide) {
                        newHighlightedPiece = piece;
                        break;
                    }
                }
            }
            bool res = (this.highlightedPiece != newHighlightedPiece);
            this.HighlightedPiece = newHighlightedPiece;
            return res;
        }
    }
}
