namespace ChineseChess {
    using System.Collections.Generic;
    static class CannonRule {
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction[] directions = new Direction[4];
            for(int i = 0; i != 4; ++i) {
                directions[i] = Direction.Get(piece.Side, (Directions)i);
                list.AddRange(RuleHelper.GetMoves(piece, pieces, directions[i]));
            }
            return list;
        }
    }
}