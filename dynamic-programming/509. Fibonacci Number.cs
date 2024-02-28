public class Solution {
    public int Fib(int n) {
        
        int last = 1;
        int penultimate = 0;
        int fibonacci = 0;

        if (n <= 1) {
            return n;
        }
        
        for (int i = 2; i <= n; i++) {
            fibonacci = last + penultimate;
            penultimate = last;
            last = fibonacci;
        }

        return fibonacci;
    }
}