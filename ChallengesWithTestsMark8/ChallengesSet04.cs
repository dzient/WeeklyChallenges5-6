using System;
using System.Collections;
//-----------------------------------------------------------------
//ChallengesWithTestsMark8
//public class ChallengesSet04
//
// Name: David Zientara
// Date: 7-7-2022
// Comments: Made changes to the program, per the instructions
//-----------------------------------------------------------------

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int n in numbers)
            {
                if ((n % 2) == 0)
                    sum += n;
                else
                    sum -= n;
            }
            return sum;
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int len = str1.Length;
            if (str2.Length < len)
                len = str2.Length;
            if (str3.Length < len)
                len = str3.Length;
            if (str4.Length < len)
                len = str4.Length;
            return len;
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;
            if (number2 < smallest)
                smallest = number2;
            if (number3 < smallest)
                smallest = number3;
            if (number4 < smallest)
                smallest = number4;
            return smallest;

            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            ArrayList sides = new ArrayList();
            sides.Add(sideLength1);
            sides.Add(sideLength2);
            sides.Add(sideLength3);
            sides.Sort();
            int[] ar = new int[3];

            int i = 0;
            foreach (int s in sides)
                ar[i++] = s;

            int sumsides = ar[0] + ar[1];
            if (sumsides > ar[2])
                return true;
            return false;

            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            double i;
            return double.TryParse(input, out i);
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int i, j;
            i = j = 0;
            foreach (var o in objs)
            {
                i++;
                if (o == null)
                    j++;
            }
            if (j > (i / 2))
                return true;
            return false;
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            double i = 0;
            if (numbers == null)
                return 0;
            foreach (double n in numbers)
            {
                if ((n % 2) == 0)
                {
                    i++;
                    sum += n;
                }

            }
            if (i == 0)
                return 0;
            return (sum / i);
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            if (number <= 1)
                  return 1;
            int fact = 1;
            for (int i = 2; i <= number; i++)
                fact *= i;
            return fact;
            throw new NotImplementedException();
        }
        
    }
}
