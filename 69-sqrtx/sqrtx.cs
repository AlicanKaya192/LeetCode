public class Solution {
    public int MySqrt(int x) {
        if (x < 2) return x;

        long r = x;

        while (r * r > x) {
            r = (r + x / r) / 2;
        }

        return (int)r;
    }
}