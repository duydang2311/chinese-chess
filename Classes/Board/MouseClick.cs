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
            }
            this.SelectedPiece = this.highlightedPiece;
            if(this.selectedPiece != before) {
                this.UpdateGuide(this.highlightedPiece);
                return true;
            }
            return false;
        }
    }
}
