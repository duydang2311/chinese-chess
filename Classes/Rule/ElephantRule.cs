namespace ChineseChess {
    using System.Collections.Generic;
    static class ElephantRule {
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction fl = Direction.Forward(piece.Side) + Direction.Left(piece.Side);
            Direction fr = Direction.Forward(piece.Side) + Direction.Right(piece.Side);
            Direction bl = Direction.Backward(piece.Side) + Direction.Left(piece.Side);
            Direction br = Direction.Backward(piece.Side) + Direction.Right(piece.Side);
            list.AddRange(RuleHelper.GetMoves(piece, pieces, fl * 2, fl, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, fr * 2, fr, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, bl * 2, bl, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, br * 2, br, 1));
            return list;
        }
    }
}