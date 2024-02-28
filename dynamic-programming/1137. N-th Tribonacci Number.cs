public class Solution {
    public int Tribonacci(int n) {

        if (n == 0) return 0;
        if (n <= 2) return 1;

        int tribonacci = 0;
        int last = 1;
        int penultimate = 1;
        int thirdToLast = 0;

        for (int i = 3; i <= n; i++) {
            tribonacci = last + penultimate + thirdToLast;
            thirdToLast = penultimate;
            penultimate = last;
            last = tribonacci;
        }

        return tribonacci;
    }
}