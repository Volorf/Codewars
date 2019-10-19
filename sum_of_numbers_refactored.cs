using System;

static class Sum {
    
    public static int GetSum (int a, int b) {

        // Set min and max from given numbers
        var minNum = (a < b) ? a : b;
        var maxNum = (a > b) ? a : b;

        var sum = 0;

        // Sum all the range from min to max
        while(minNum <= maxNum) {
            sum += minNum;
            minNum++;
        }
        return sum;
    }
}