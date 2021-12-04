namespace ChineseChess {
    using System;
    using System.Collections.Generic;
    static class HorseRule {
        public static List<Direction> FilterPos(Side side, Piece piece, List<Piece> pieces) {
            List<Direction> filtered = new List<Direction>(4);
            Direction location = new Direction(piece.Location.X, piece.Location.Y);
            Direction temp;
            Array directionsEnum = Enum.GetValues(typeof(Directions));
            bool[] blocked = new bool[4]{false, false, false, false};
            int cnt = 0;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X, p.Location.Y) - location;
                if(temp.X > 1 || temp.X < -1 || temp.Y > 1 || temp.Y < -1) continue;
                foreach(Directions direction in directionsEnum) {
                    if(!blocked[(int)direction] && DirectionHelper.Compare(temp, Direction.Get(side, direction))) {
                        // filtered.Add(temp);
                        blocked[(int)direction] = true;
                        ++cnt;
                    }
                }
            }
            foreach(Directions direction in directionsEnum) {
                if(!blocked[(int)direction]) {
                    filtered.Add(Direction.Get(side, direction));
                }
            }
            return filtered;
        }
        public static List<Direction> GetMoves(Side side, Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>(4);
            List<Direction> filtered = HorseRule.FilterPos(side, piece, pieces);
            if(filtered.Count == 0) return list;
            Direction temp;
            foreach(Direction p in filtered) {
                temp = p * 2 + p.Perpendicular;
                if(DirectionHelper.Validate(piece, temp)) {
                    list.Add(temp);
                }
                temp = p * 2 - p.Perpendicular;
                if(DirectionHelper.Validate(piece, temp)) {
                    list.Add(temp);
                }
            }
            return list;
        }
    }
}