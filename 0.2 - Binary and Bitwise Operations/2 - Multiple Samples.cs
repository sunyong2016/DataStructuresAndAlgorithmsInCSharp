﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DataStructuresAndAlgorithms
{
    public  partial class BinaryAndBitwiseOperations
    {
        public void BasicOperations()
        {
            int frAnd6 = 4 & 6;
            int frIOr6 = 4 | 6;
            int frxOr6 = 4 ^ 6;
            int not6 = ~6;
            int frlfSft6 = 4 << 6;
            float frrSft6 = 4 >> 6;
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            string str = " 4 & 6  : " + frAnd6;
            str += "\n 4 | 6  : " + frIOr6;
            str += "\n 4 ^ 6  : " + frxOr6;
            str += "\n ~ 6  : " + not6;
            str += "\n 4 << 6  : " + frlfSft6;
            str += "\n 4 >> 6  : " + frrSft6;

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            MessageBox.Show(str);

            int i = 10;
            int j = i << 1;
            int k = i >> 1;

            int l = i & j;
            int m = i | j;
            int n = ~j;

            // Detect if two integers have opposite signs  
            int x = 2, y = -3;

            bool f = ((x ^ y) < 0); // true iff x and y have opposite signs


            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //char ch1 = 'A';
            //char ch2 = 'B';

            //char ch3 = ch1 << ch2;
            //char ch4 = ch1 >> ch2;
            //char ch5 = ch1 & ch2;

            //Swap With out Temp------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            
            int a = 5;
            int b = 6;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            //  Console.WriteLine(a);
            //  Console.WriteLine(b);

        }

        public void IsPalindromeBinaryNumber()
        {
 
        }

        /*
http://www.exploringbinary.com/binary-multiplication/
============================================================================================================================================================================================================================

There is the design of the circuits to perform the algorithms (full adders, half adders, ripple carry adders, carry-lookahead adders, restoring dividers, non-restoring dividers, etc.). 

Decimal :

11
19.7
+12.8
-----
32.5

Binary:

Step 1:
1011.01
+  11.011
--------
1

Step 2:

1
1011.01
+  11.011
--------
01

Step 3:

1
1011.01
+  11.011
--------
.101


Step 4:

1  1
1011.01
+  11.011
--------
0.101


Step 4:

11  1
1011.01
+  11.011
--------
10.101

Step 5:

11  1
1011.01
+  11.011
--------
110.101

Step 6:

11  1
1011.01
+  11.011
--------
1110.101

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
http://www.ixl.com/math/grade-5
============================================================================================================================================================================================================================
*/
        public long ArithmaticOperationsAdd2BinaryNumbers(long binaryNum1, long binaryNum2)
        {
            return -1;
        }

        public long ArithmaticOperationsSubtract2BinaryNumbers(long binaryNum1, long binaryNum2)
        {
            return -1;
        }

        public long ArithmaticOperationsMultiply2BinaryNumbers(long binaryNum1, long binaryNum2)
        {
            return -1;
        }

        public long ArithmaticOperationsDivide2BinaryNumbers(long binaryNum1, long binaryNum2)
        {
            return -1;
        }

        // http://en.wikipedia.org/wiki/XOR_swap_algorithm
        public void XORSwapAlgorithm(int x, int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }

        //     http://www.dsalgo.com/2013/02/CalculatePower.php.html
        public static void CalculatePower(String[] args)
        {
            int x = 4;
            int y = 10;
            long power = x;
            long answer = 1;

            while (y != 0)
            {
                if ((y & 1) == 1)
                {
                    answer *= power;
                }
                y >>= 1;
                power *= power;
            }

            Console.WriteLine(answer);
        }

        /*
        http://www.careercup.com/question?id=10353662
        "1001"+"101"="1110"
        */

        void Add_Num(int a, int b)
        {
            if (b == 0)
            {
                return;
            }

            int sum = a ^ b;
            int carry = (a & b) << 1;


            Add_Num(sum, carry);

        }

        /**
 * given n find the total number of ones in the binary representation of
 * numbers 1,2,3,...,n
 * 
http://www.dsalgo.com/2013/02/count-number-of-ones-till-n-in-binary.html
 */
        public static void getNumberOfOnesTest(String[] args)
        {
            MessageBox.Show(Convert.ToString(getNumberOfOnes(30)));
        }

        public static int getNumberOfOnes(int num)
        {
            int p = 1, cnt = 0;

            if ((num & 1) != 0)
                cnt++;

            while (1 << (p - 1) < num)
            {
                if ((num & (1 << p)) != 0)
                    cnt += (1 << (p - 1)) * (p) + num % (1 << p) + 1;
                p++;
            }
            return cnt;
        }

        //    http://www.careercup.com/question?id=5707243546738688

        /*
1) XOR all the array elements, let the result of XOR be X1.
2) XOR all numbers from 1 to n, let XOR be X2. 
3) XOR of X1 and X2 gives the missing number.

Time Complexity: O(n)

In method 1, if the sum of the numbers goes beyond maximum allowed integer, then there can be integer overflow and we may not get correct answer. Method 2 has no such problems.

http://www.geeksforgeeks.org/find-the-missing-number/
*/

        int getMissingNo(int[] a, int n)
        {
            int i;
            int x1 = a[0]; /* For xor of all the elemets in arary */
            int x2 = 1; /* For xor of all the elemets from 1 to n+1 */

            for (i = 1; i < n; i++)
            {
                x1 = x1 ^ a[i];
            }
            for (i = 2; i <= n + 1; i++)
            {
                x2 = x2 ^ i;
            }
            return (x1 ^ x2);
        }

        void getMissingNoTest()
        {
            int[] a = { 1, 2, 4, 5, 6 };
            int miss = getMissingNo(a, 5);
        }

        /*
http://www.dsalgo.com/2013/02/next-power-of-two.html
*/

        public static void FindNextPowerOfTwoTest(String[] args)
        {
            long num = 128;
            long result = FindNextPowerOfTwo(num);
            Console.WriteLine(result);
        }

        private static long FindNextPowerOfTwo(long num)
        {
            long result = 1;
            while (num != 0)
            {
                num >>= 1;
                result <<= 1;
            }
            return result;
        }

        /*
===================================================================================================================================================================================================

If we XOR a number with itself odd  number of times the result is 0. 
If we XOR a number with itself even number of times the result is the number itself.

So, if we XOR all the elements in the array, the result is the odd occurring element itself. 

Because all even occurring elements will be XORed with themselves odd number of times, producing 0. 
And the only odd occurring element will be XORed with itself even number of times, producing its own value . 
Also XOR of an element with 0 gives the element itself.

http://www.geeksforgeeks.org/find-the-number-occurring-odd-number-of-times/

=======================================================================================================================================================================================================
*/

        public void NumberOccurringOddNumberOfTimesTest()
        {
            int[] ar = { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 };
            int result = NumberOccurringOddNumberOfTimes(ar);

            MessageBox.Show("Number Occurring Odd Number Of Times " + result);
        }

        int NumberOccurringOddNumberOfTimes(int[] ar)
        {
            int i;
            int res = 0;

            for (i = 0; i < ar.Length; i++)
            {
                res = res ^ ar[i];
            }
            return res;
        }

    }
}