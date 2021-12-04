namespace ChineseChess {
    using System.Drawing;
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
        public bool OnMouseClick(float x, float y) {
            Piece before = this.selectedPiece;
            if(before != null) {
                if(before != this.highlightedPiece) {
                    this.guide.OnMouseClick(x, y);
                }
            } else {
                this.UpdateGuide(this.highlightedPiece);
            }
            this.SelectedPiece = this.highlightedPiece;
            return (before != this.selectedPiece);
        }
    }
}
