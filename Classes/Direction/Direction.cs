namespace ChineseChess {
    using System;
    class Direction {
        private int x;
        private int y;
        public Direction(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public int X {
            get => this.x;
            set { this.x = value; }
        }
        public int Y {
            get => this.y;
            set { this.y = value; }
        }
        public Direction Opposite {
            get => new Direction(-this.x, -this.y);
        }
        public Direction Perpendicular {
            get => new Direction(-this.y, this.x);
        }
        public float Length {
            get => (float)Math.Sqrt(this.x * this.x + this.y * this.y);
        }
        public Direction Normalized {
            get {
                int divisor = Util.GCD(this.x, this.y);
                if(divisor == 0) {
                    return new Direction(this.x, this.y);
                }
                return new Direction(this.x / divisor, this.y / divisor);
            }
        }
        public static Direction operator+(Direction a, Direction b) {
            return new Direction(a.X + b.X, a.Y + b.Y);
        }
        public static Direction operator+(Direction a) {
            return a;
        }
        public static Direction operator-(Direction a, Direction b) {
            return new Direction(a.X - b.X, a.Y - b.Y);
        }
        public static Direction operator-(Direction a) {
            return new Direction(-a.X, -a.Y);
        }
        public static Direction operator*(Direction a, Direction b) {
            return new Direction(a.X * b.X, a.Y * b.Y);
        }
        public static Direction operator*(Direction a, int b) {
            return new Direction(a.X * b, a.Y * b);
        }
        public static Direction operator*(int b, Direction a) {
            return new Direction(a.X * b, a.Y * b);
        }
        public static Direction operator/(Direction a, Direction b) {
            return new Direction((int)(a.X / b.X), (int)(a.Y / b.Y));
        }
        public static Direction operator/(Direction a, int b) {
            return new Direction(a.X / b, a.Y / b);
        }
        public static Direction operator/(int b, Direction a) {
            return new Direction(a.X / b, a.Y / b);
        }
        public static Direction Forward(Side side) {
            if(side == Side.Top) {
                return new Direction(0, 1);
            }
            return new Direction(0, -1);
        }
        public static Direction Backward(Side side) {
            return -Direction.Forward(side);
        }
        public static Direction Left(Side side) {
            if(side == Side.Top) {
                return new Direction(1, 0);
            }
            return new Direction(-1, 0);
        }
        public static Direction Right(Side side) {
            return -Direction.Left(side);
        }
        public static Direction Get(Side side, Directions direction) {
            switch(direction) {
                case Directions.Forward: {
                    return Direction.Forward(side);
                }
                case Directions.Backward: {
                    return Direction.Backward(side);
                }
                case Directions.Left: {
                    return Direction.Left(side);
                }
                case Directions.Right: {
                    return Direction.Right(side);
                }
            }
            return null;
        }
    }
}