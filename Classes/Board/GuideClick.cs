namespace ChineseChess {
    partial class Board {
        private void OnGuideClick(object sender, GuideClickEventArgs e) {
            if(this.selectedPiece == null) return;
            this.selectedPiece.Location = new System.Drawing.Point(e.X, e.Y);
        }
    }
}