using System.Drawing;

namespace ChineseChess {
    partial class Board {
        private Piece highlightPiece;
        public bool OnMouseMove(float x, float y) {
            for(int i = 0 ; i != this.sides.Length; ++i) {
                foreach(Piece piece in this.sides[i]) {
                    if(piece.IsPointCollided(x, y)) {
                        if(piece == highlightPiece) return false;
                        if(highlightPiece != null) {
                            highlightPiece.Highlight = Color.Transparent;
                        }
                        piece.Highlight = System.Drawing.Color.Red;
                        highlightPiece = piece;
                        return true;
                    }
                }
            }
            if(highlightPiece != null) {
                highlightPiece.Highlight = Color.Transparent;
                highlightPiece = null;
                return true;
            }
            return false;
        }
    }
}
