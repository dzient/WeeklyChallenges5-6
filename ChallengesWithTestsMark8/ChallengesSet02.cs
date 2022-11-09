using System;
using System.Collections.Generic;
//-----------------------------------------------------------------
//ChallengesWithTestsMark8
//public class ChallengesSet02
//
// Name: David Zientara
// Date: 7-7-2022
// Comments: Made changes to the program, per the instructions
//-----------------------------------------------------------------

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                return true;
            return false;
            //throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            long count = 0;
            foreach (var v in vals)
                count++;

            if ((count % 2) == 0)
                return true;
            return false;
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if ((number % 2) == 0)
                return true;
            return false;
            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if ((num % 2) != 0)
                return true;
            return false;
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            // Convert to a list and add members
            var list = new List<double>();
            if (numbers == null)
                return 0;
            foreach (var n in numbers)
                list.Add(n);
            if (list.Count == 0)
                return 0;
            // Sort the list; get the min
            list.Sort();
            var min = list[0];
            // Reverse the list; get the max
            list.Reverse();
            var max = list[0];
            return (min+max);

            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
                return str1.Length;
            return str2.Length;
           // throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int total = 0;
            if (numbers == null)
                return 0;
            foreach (var n in numbers)
                total += n;
            return total;
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            int total = 0;
            if (numbers == null)
                return 0;
            foreach (var n in numbers)
                if ((n % 2) == 0)
                    total += n;
   
            return total;
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            var n = Sum(numbers.ToArray());
            if ((n % 2) != 0)
                return true;
            return false;
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            for (long i = 0; i < number; i++)
                if ((i % 2) != 0)
                    count++;
            return count;
            //throw new NotImplementedException();
        }
    }
}
