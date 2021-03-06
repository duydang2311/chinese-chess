namespace ChineseChess {
    using System.Collections.Generic;
    using System.Linq;
    partial class Board {
        public void UpdateGuide(Piece piece) {
            if(piece == null) {
                this.guide.Clear();
                return;
            }
            List<Direction> moves = RuleHelper.GetMoves(piece, this.sides[0].Concat(this.sides[1]).ToList());
            Direction location = new Direction(piece.Location.X, piece.Location.Y);
            for(int j = 0; j != moves.Count; ++j) {
                moves[j] = moves[j] + location;
            }
            this.guide.Points = moves;
        }
    }
}