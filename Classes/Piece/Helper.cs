using System.Drawing;

namespace ChineseChess {
    class PieceHelper {
        public const int MAX_SIZE = 90;
        public static Image red_cannon = new Bitmap(ChineseChess.Properties.Resources.red_cannon, MAX_SIZE, MAX_SIZE);
        public static Image red_chariot = new Bitmap(ChineseChess.Properties.Resources.red_chariot, MAX_SIZE, MAX_SIZE);
        public static Image red_general = new Bitmap(ChineseChess.Properties.Resources.red_general, MAX_SIZE, MAX_SIZE);
        public static Image red_elephant = new Bitmap(ChineseChess.Properties.Resources.red_elephant, MAX_SIZE, MAX_SIZE);
        public static Image red_horse = new Bitmap(ChineseChess.Properties.Resources.red_horse, MAX_SIZE, MAX_SIZE);
        public static Image red_soldier = new Bitmap(ChineseChess.Properties.Resources.red_soldier, MAX_SIZE, MAX_SIZE);
        public static Image red_guard = new Bitmap(ChineseChess.Properties.Resources.red_guard, MAX_SIZE, MAX_SIZE);
        public static Image black_cannon = new Bitmap(ChineseChess.Properties.Resources.black_cannon, MAX_SIZE, MAX_SIZE);
        public static Image black_chariot = new Bitmap(ChineseChess.Properties.Resources.black_chariot, MAX_SIZE, MAX_SIZE);
        public static Image black_general = new Bitmap(ChineseChess.Properties.Resources.black_general, MAX_SIZE, MAX_SIZE);
        public static Image black_elephant = new Bitmap(ChineseChess.Properties.Resources.black_elephant, MAX_SIZE, MAX_SIZE);
        public static Image black_horse = new Bitmap(ChineseChess.Properties.Resources.black_horse, MAX_SIZE, MAX_SIZE);
        public static Image black_soldier = new Bitmap(ChineseChess.Properties.Resources.black_soldier, MAX_SIZE, MAX_SIZE);
        public static Image black_guard = new Bitmap(ChineseChess.Properties.Resources.black_guard, MAX_SIZE, MAX_SIZE);
        public static Image GetImage(SideColor color, Pieces piece) {
            switch(piece) {
                case Pieces.General: {
                    if(color == SideColor.Black) {
                        return black_general;
                    }
                    return red_general;
                }
                case Pieces.Guard: {
                    if(color == SideColor.Black) {
                        return black_guard;
                    }
                    return red_guard;
                }
                case Pieces.Elephant: {
                    if(color == SideColor.Black) {
                        return black_elephant;
                    }
                    return red_elephant;
                }
                case Pieces.Chariot: {
                    if(color == SideColor.Black) {
                        return black_chariot;
                    }
                    return red_chariot;
                }
                case Pieces.Horse: {
                    if(color == SideColor.Black) {
                        return black_horse;
                    }
                    return red_horse;
                }
                case Pieces.Cannon: {
                    if(color == SideColor.Black) {
                        return black_cannon;
                    }
                    return red_cannon;
                }
                case Pieces.Soldier: {
                    if(color == SideColor.Black) {
                        return black_soldier;
                    }
                    return red_soldier;
                }
            }
            return null;
        }
    }
}