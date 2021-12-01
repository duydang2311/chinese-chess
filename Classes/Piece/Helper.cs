using System.Drawing;

namespace ChineseChess {
    class PieceHelper {
        public static Image GetImage(Side side, Pieces piece) {
            switch(piece) {
                case Pieces.General: {
                    if(side == Side.Black) {
                        return ChineseChess.Properties.Resources.black_general;
                    }
                    return ChineseChess.Properties.Resources.red_general;
                }
                case Pieces.Guard: {
                    if(side == Side.Black) {
                        return ChineseChess.Properties.Resources.black_guard;
                    }
                    return ChineseChess.Properties.Resources.red_guard;
                }
                case Pieces.Elephant: {
                    if(side == Side.Black) {
                        return ChineseChess.Properties.Resources.black_elephant;
                    }
                    return ChineseChess.Properties.Resources.red_elephant;
                }
                case Pieces.Chariot: {
                    if(side == Side.Black) {
                        return ChineseChess.Properties.Resources.black_chariot;
                    }
                    return ChineseChess.Properties.Resources.red_chariot;
                }
                case Pieces.Horse: {
                    if(side == Side.Black) {
                        return ChineseChess.Properties.Resources.black_horse;
                    }
                    return ChineseChess.Properties.Resources.red_horse;
                }
                case Pieces.Cannon: {
                    if(side == Side.Black) {
                        return ChineseChess.Properties.Resources.black_cannon;
                    }
                    return ChineseChess.Properties.Resources.red_cannon;
                }
                case Pieces.Soldier: {
                    if(side == Side.Black) {
                        return ChineseChess.Properties.Resources.black_soldier;
                    }
                    return ChineseChess.Properties.Resources.red_soldier;
                }
            }
            return null;
        }
    }
}