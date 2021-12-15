namespace ChineseChess {
    partial class Board {
        private void OnGuideClick(object sender, GuideClickEventArgs e) {
            if(this.selectedPiece == null) return;
            this.selectedPiece.Capture(e.X, e.Y);
            this.HighlightedPiece = null; // workaround for MouseClick
        }
    }
}