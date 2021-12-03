using System.Drawing;

namespace ChineseChess {
    class PieceHelper {
        public static Image GetImage(SideColor color, Pieces piece) {
            switch(piece) {
                case Pieces.General: {
                    if(color == SideColor.Black) {
                        return ChineseChess.Properties.Resources.black_general;
                    }
                    return ChineseChess.Properties.Resources.red_general;
                }
                case Pieces.Guard: {
                    if(color == SideColor.Black) {
                        return ChineseChess.Properties.Resources.black_guard;
                    }
                    return ChineseChess.Properties.Resources.red_guard;
                }
                case Pieces.Elephant: {
                    if(color == SideColor.Black) {
                        return ChineseChess.Properties.Resources.black_elephant;
                    }
                    return ChineseChess.Properties.Resources.red_elephant;
                }
                case Pieces.Chariot: {
                    if(color == SideColor.Black) {
                        return ChineseChess.Properties.Resources.black_chariot;
                    }
                    return ChineseChess.Properties.Resources.red_chariot;
                }
                case Pieces.Horse: {
                    if(color == SideColor.Black) {
                        return ChineseChess.Properties.Resources.black_horse;
                    }
                    return ChineseChess.Properties.Resources.red_horse;
                }
                case Pieces.Cannon: {
                    if(color == SideColor.Black) {
                        return ChineseChess.Properties.Resources.black_cannon;
                    }
                    return ChineseChess.Properties.Resources.red_cannon;
                }
                case Pieces.Soldier: {
                    if(color == SideColor.Black) {
                        return ChineseChess.Properties.Resources.black_soldier;
                    }
                    return ChineseChess.Properties.Resources.red_soldier;
                }
            }
            return null;
        }
    }
}