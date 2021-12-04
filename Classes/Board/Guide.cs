namespace ChineseChess {
    using System.Collections.Generic;
    using System.Linq;
    partial class Board {
        public void UpdateGuide(Piece piece) {
            if(piece == null) {
                this.guide.Clear();
            }
            for(int i = 0; i != this.sides.Length; ++i) {
                if(this.sides[i] == null) continue;
                int index = this.sides[i].IndexOf(piece);
                if(index == -1) continue;
                List<Direction> moves = RuleHelper.GetMoves((Side)i, piece, this.sides[0].Concat(this.sides[1]).ToList());
                Direction location = new Direction(piece.Location.X, piece.Location.Y);
                for(int j = 0; j != moves.Count; ++j) {
                    moves[j] = moves[j] + location;
                }
                piece.Location = new System.Drawing.Point(moves[moves.Count - 1].X, moves[moves.Count - 1].Y);
                this.guide.Points = moves;
                break;
            }
        }
    }
}