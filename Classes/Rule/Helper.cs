namespace ChineseChess {
    using System.Collections.Generic;
    static class RuleHelper {
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            switch(piece.Type) {
                case Pieces.Soldier: {
                    return SoldierRule.GetMoves(piece);
                }
                case Pieces.Horse: {
                    return HorseRule.GetMoves(piece, pieces);
                }
                case Pieces.Chariot: {
                    return ChariotRule.GetMoves(piece, pieces);
                }
                case Pieces.Guard: {
                    return GuardRule.GetMoves(piece, pieces);
                }
                case Pieces.Elephant: {
                    return ElephantRule.GetMoves(piece, pieces);
                }
                case Pieces.Cannon: {
                    return CannonRule.GetMoves(piece, pieces);
                }
            }
            return null;
        }
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces, Direction direction, int steps = -1) {
            List<Direction> moves = new List<Direction>();
            int x = piece.Location.X;
            int y = piece.Location.Y;
            Piece blockPiece = null;
            Direction block = new Direction(11, 11);
            Direction temp;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X - x, p.Location.Y - y);
                if(DirectionHelper.Compare(direction.Normalized, temp.Normalized)) {
                    if(temp.Length < block.Length) {
                        block = temp;
                        blockPiece = p;
                    }
                }
            }
            if(blockPiece is not null && blockPiece.Side != piece.Side) {
                block += direction;
            }
            temp = direction;
            while(steps-- != 0 && DirectionHelper.Validate(piece, temp) && !DirectionHelper.Compare(temp, block)) {
                moves.Add(temp);
                temp += direction;
            }
            return moves;
        }
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces, Direction direction, Direction restricted, int steps = -1) {
            List<Direction> moves = new List<Direction>();
            int x = piece.Location.X;
            int y = piece.Location.Y;
            Piece blockPiece = null;
            Direction block = new Direction(11, 11);
            Direction temp;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X - x, p.Location.Y - y);
                if(DirectionHelper.Compare(temp, restricted)) {
                    return moves;
                }
                if(DirectionHelper.Compare(direction.Normalized, temp.Normalized)) {
                    if(temp.Length < block.Length) {
                        block = temp;
                        blockPiece = p;
                    }
                }
            }
            if(blockPiece is not null && blockPiece.Side != piece.Side) {
                block += direction;
            }
            temp = direction;
            while(steps-- != 0 && DirectionHelper.Validate(piece, temp) && !DirectionHelper.Compare(temp, block)) {
                moves.Add(temp);
                temp += direction;
            }
            return moves;
        }
    }
}