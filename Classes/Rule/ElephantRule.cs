namespace ChineseChess {
    using System.Collections.Generic;
    static class ElephantRule {
        public static List<Direction> GetMoves(Side side, Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction fl = Direction.Forward(side) + Direction.Left(side);
            Direction fr = Direction.Forward(side) + Direction.Right(side);
            Direction bl = Direction.Backward(side) + Direction.Left(side);
            Direction br = Direction.Backward(side) + Direction.Right(side);
            list.AddRange(RuleHelper.GetMoves(piece, pieces, fl * 2, fl, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, fr * 2, fr, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, bl * 2, bl, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, br * 2, br, 1));
            return list;
        }
    }
}