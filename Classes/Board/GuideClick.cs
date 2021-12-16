namespace ChineseChess {
    partial class Board {
        private void OnGuideClick(object sender, GuideClickEventArgs e) {
            if(this.selectedPiece == null) return;
            Piece capturing = this.selectedPiece.Capture(e.X, e.Y);
            this.HighlightedPiece = null; //workaround for MouseClick
            if(capturing is not null) {
                return;
            }
            this.captured[(int)capturing.Side].Add(capturing);
        }
    }
}