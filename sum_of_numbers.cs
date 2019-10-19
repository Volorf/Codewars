using System;

static class Sum {
    
    public static int GetSum (int a, int b) {
        // Check a case where a and b are the same numbers. Zero case.
        if (a == b) {
            return a;
        }

        // Make two vars to work with further calculations. 
        // The first one is always less than the second.
        var firstValue = (a < b) ? a : b;
        var secondValue = (a > b) ? a : b;

        // Calculate a number of all numbers 
        // in the given range with different cases
        // There are three possible cases.

        // First case: all given numbers are positive (or the firstValue equals 0).
        // We need to check only the firstValue because it's obviuosly 
        // that the secondValue should be more (a case where they are the same 
        // we process in the Zero case statement above)
        if (firstValue >= 0) {
            var sum = SumPositive (firstValue, secondValue);
            return sum;
        }

        // The second case where both values are negative (or the secondValue equals 0).
        if (secondValue <= 0) {
            var sum = SumNegative (firstValue, secondValue);
            return sum;
        }

        // The third case where the firstValue is negative and the secondValue is positive.
        if (firstValue < 0 && secondValue > 0) {
            var sumPositiveRange = SumPositive (0, secondValue);
            var sumNegativeRange = SumNegative (firstValue, 0);
            var sum = sumPositiveRange + sumNegativeRange;
            return sum;
        }

        // Sum positive numbers method
        int SumPositive (int _fNum, int _sNum) {
            var fNum = _fNum;
            var sNum = _sNum;
            var deltaNum = sNum - fNum;
            var sum = sNum;
            for (int i = 0; i < deltaNum; i++) {
                sNum--;
                sum += sNum;
            }
            return sum;
        }

        // Sum negative numbers method
        int SumNegative (int _fNum, int _sNum) {
            var fNum = _fNum;
            var sNum = _sNum;
            var deltaNum = Math.Abs(fNum - sNum);
            var sum = fNum;
            for (int i = 0; i < deltaNum; i++) {
                fNum++;
                sum += fNum;
            }
            return sum;
        }

        return 0;

    }
}