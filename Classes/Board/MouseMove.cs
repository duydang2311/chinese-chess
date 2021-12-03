using System.Drawing;

namespace ChineseChess {
    partial class Board {
        private Piece highlightedPiece;
        public bool OnMouseMove(float x, float y) {
            for(int i = 0 ; i != this.sides.Length; ++i) {
                foreach(Piece piece in this.sides[i]) {
                    if(piece.IsPointCollided(x, y)) {
                        if(piece == highlightedPiece) return false;
                        if(highlightedPiece != null) {
                            highlightedPiece.Highlight = Color.Transparent;
                        }
                        piece.Highlight = System.Drawing.Color.Red;
                        highlightedPiece = piece;
                        return true;
                    }
                }
            }
            if(highlightedPiece != null) {
                highlightedPiece.Highlight = Color.Transparent;
                highlightedPiece = null;
                return true;
            }
            return false;
        }
    }
}
