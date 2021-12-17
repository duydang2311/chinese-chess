namespace ChineseChess {
    partial class Board {
        private void OnGuideClick(object sender, GuideClickEventArgs e) {
            if(this.selectedPiece == null) return;
            Piece capturing = this.selectedPiece.Capture(e.X, e.Y);
            this.HighlightedPiece = null; //workaround for MouseClick
            this.game.SwitchTurn();
            if(capturing is null) {
                return;
            }
            this.game.UpdateSidePoint(capturing);
            this.captured[(int)capturing.Side].Add(capturing);
            if(capturing.Type == Pieces.General) {
                this.game.End();
            }
        }
    }
}