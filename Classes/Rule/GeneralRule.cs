namespace ChineseChess {
    using System.Collections.Generic;
    static class GeneralRule {
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction min = new Direction(Board.Cols / 2 - 1, (Board.Rows - 7) * (int)piece.Side);
            Direction max = new Direction(Board.Cols / 2 + 1, (Board.Rows - 3) * (int)piece.Side + 2);
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Forward(piece.Side), min, max, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Backward(piece.Side), min, max, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Left(piece.Side), min, max, 1));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Right(piece.Side), min, max, 1));
            return list;
        }
    }
}