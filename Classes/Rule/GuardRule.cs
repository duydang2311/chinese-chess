namespace ChineseChess {
    using System.Collections.Generic;
    static class GuardRule {
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction forward = Direction.Forward(piece.Side);
            Direction backward = Direction.Backward(piece.Side);
            Direction left = Direction.Left(piece.Side);
            Direction right = Direction.Right(piece.Side);
            Direction min = new Direction(Board.Cols / 2 - 1, (Board.Rows - 7) * (int)piece.Side);
            Direction max = new Direction(Board.Cols / 2 + 1, (Board.Rows - 3) * (int)piece.Side + 2);
            list.AddRange(RuleHelper.GetMoves(piece, pieces, forward + left, min, max, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, forward + right, min, max, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, backward + left, min, max, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, backward + right, min, max, 1));
            return list;
        }
    }
}