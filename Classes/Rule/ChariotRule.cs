namespace ChineseChess {
    using System.Collections.Generic;
    static class ChariotRule {
        public static List<Direction> GetMoves(Side side, Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Forward(side)));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Backward(side)));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Left(side)));
            list.AddRange(RuleHelper.GetMoves(piece, pieces, Direction.Right(side)));
            return list;
        }
    }
}