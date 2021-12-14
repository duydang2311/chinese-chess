namespace ChineseChess {
    using System;
    public static class Util {
        public static int GCD(int a, int b) {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while(a != 0 && b != 0) {
                if(a > b) {
                    a %= b;
                } else {
                    b %= a;
                }
            }
            return a | b;
        }
    }
}