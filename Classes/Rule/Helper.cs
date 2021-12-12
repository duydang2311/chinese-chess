namespace ChineseChess {
    using System.Collections.Generic;
    static class RuleHelper {
        public static List<Direction> GetMoves(Side side, Piece piece, List<Piece> pieces) {
            switch(piece.Type) {
                case Pieces.Soldier: {
                    return SoldierRule.GetMoves(side, piece);
                }
                case Pieces.Horse: {
                    return HorseRule.GetMoves(side, piece, pieces);
                }
                case Pieces.Chariot: {
                    return ChariotRule.GetMoves(side, piece, pieces);
                }
            }
            return null;
        }
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces, Direction direction, int steps = -1) {
            List<Direction> moves = new List<Direction>();
            int x = piece.Location.X;
            int y = piece.Location.Y;
            Direction block = new Direction(11, 11);
            Direction temp;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X - x, p.Location.Y - y);
                if(DirectionHelper.Compare(direction, temp.Normalized)) {
                    if(temp.Length < block.Length) {
                        block = temp;
                    }
                }
            }
            block += direction;
            temp = direction;
            while(DirectionHelper.Validate(piece, temp) && !DirectionHelper.Compare(temp, block)) {
                moves.Add(temp);
                temp += direction;
            }
            return moves;
        }
    }
}