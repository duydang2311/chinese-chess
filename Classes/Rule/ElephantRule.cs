namespace ChineseChess {
    using System.Collections.Generic;
    static class ElephantRule {
        public static List<Direction> GetMoves(Side side, Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction forward = Direction.Forward(side);
            Direction backward = Direction.Backward(side);
            Direction left = Direction.Left(side);
            Direction right = Direction.Right(side);
            list.AddRange(RuleHelper.GetMoves(piece, pieces, (forward + left) * 2, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, (forward + right) * 2, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, (backward + left) * 2, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, (backward + right) * 2, 1));
            return list;
        }
    }
}