namespace ChineseChess {
    using System.Collections.Generic;
    static class RuleHelper {
        public static List<Direction> GetMoves(Side side, Piece piece, List<Piece> pieces) {
            switch(piece.Type) {
                case Pieces.Soldier: {
                    return SoldierRule.GetMoves(side, piece);
                }
                case Pieces.Horse: {
                    return HorseRule.GetMoves(side, piece, pieces);
                }
                case Pieces.Chariot: {
                    return ChariotRule.GetMoves(side, piece);
                }
            }
            return null;
        }
    }
}