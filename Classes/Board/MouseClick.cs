using System.Drawing;

namespace ChineseChess {
    partial class Board {
        Piece selectedPiece;
        public Piece SelectedPiece {
            get => this.selectedPiece;
            set {
                if(this.selectedPiece != null) {
                    this.selectedPiece.Highlight = Color.Transparent;
                }
                this.selectedPiece = value;
                if(value != null) {
                    this.selectedPiece.Highlight = Color.Green;
                }
            }
        }
        public bool OnMouseClick() {
            Piece before = this.selectedPiece;
            this.SelectedPiece = this.highlightedPiece;
            this.UpdateGuide(this.selectedPiece);
            return (before != this.selectedPiece);
        }
    }
}
