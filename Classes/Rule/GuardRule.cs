namespace ChineseChess {
    using System.Collections.Generic;
    static class GuardRule {
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction forward = Direction.Forward(piece.Side);
            Direction backward = Direction.Backward(piece.Side);
            Direction left = Direction.Left(piece.Side);
            Direction right = Direction.Right(piece.Side);
            list.AddRange(RuleHelper.GetMoves(piece, pieces, forward + left, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, forward + right, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, backward + left, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, backward + right, 1));
            return list;
        }
    }
}