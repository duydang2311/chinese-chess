namespace ChineseChess {
    using System.Collections.Generic;
    static class GuardRule {
        public static List<Direction> GetMoves(Side side, Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction forward = Direction.Forward(side);
            Direction backward = Direction.Backward(side);
            Direction left = Direction.Left(side);
            Direction right = Direction.Right(side);
            list.AddRange(RuleHelper.GetMoves(piece, pieces, forward + left, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, forward + right, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, backward + left, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, backward + right, 1));
            return list;
        }
    }
}