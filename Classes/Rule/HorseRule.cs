namespace ChineseChess {
    using System;
    using System.Collections.Generic;
    static class HorseRule {
        private static List<Direction> FilterPos(Piece piece, List<Piece> pieces) {
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
                    if(!blocked[(int)direction] && DirectionHelper.Compare(temp, Direction.Get(piece.Side, direction))) {
                        blocked[(int)direction] = true;
                        ++cnt;
                    }
                }
            }
            foreach(Directions direction in directionsEnum) {
                if(!blocked[(int)direction]) {
                    filtered.Add(Direction.Get(piece.Side, direction));
                }
            }
            return filtered;
        }
        private static Piece GetCollidedPiece(Direction location, List<Piece> pieces) {
            foreach(Piece piece in pieces) {
                if(piece.Location.X == location.X && piece.Location.Y == location.Y) {
                    pieces.Remove(piece);
                    return piece;
                }
            }
            return null;
        }
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>(4);
            List<Direction> filtered = HorseRule.FilterPos(piece, pieces);
            List<Piece> closePieces = new List<Piece>();
            if(filtered.Count == 0) return list;
            Direction temp;
            Piece collided;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X - piece.Location.X, p.Location.Y - piece.Location.Y);
                if(temp.Length > 3) {
                    continue;
                }
                closePieces.Add(p);
            }
            foreach(Direction p in filtered) {
                temp = p * 2 + p.Perpendicular;
                if(DirectionHelper.Validate(piece, temp)) {
                    collided = HorseRule.GetCollidedPiece(temp + piece.Location, closePieces);
                    if(collided is null || collided.Side != piece.Side) {
                        list.Add(temp);
                    }
                }
                temp = p * 2 - p.Perpendicular;
                if(DirectionHelper.Validate(piece, temp)) {
                    collided = HorseRule.GetCollidedPiece(temp + piece.Location, closePieces);
                    if(collided is null || collided.Side != piece.Side) {
                        list.Add(temp);
                    }
                }
            }
            return list;
        }
    }
}