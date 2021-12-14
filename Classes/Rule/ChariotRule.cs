namespace ChineseChess {
    using System.Collections.Generic;
    static class ChariotRule {
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Forward(piece.Side)));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Backward(piece.Side)));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Left(piece.Side)));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Right(piece.Side)));
            return list;
        }
    }
}