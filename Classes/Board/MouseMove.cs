using System.Windows.Forms;

namespace ChineseChess {
    partial class Board {
        public void OnMouseMove(float x, float y) {
            for(int i = 0 ; i != this.sides.Length; ++i) {
                foreach(Piece piece in this.sides[i]) {
                    if(piece.IsPointCollided(x, y)) {
                        piece.Highlight = System.Drawing.Color.Red;
                        break;
                    }
                }
            }
        }
    }
}
