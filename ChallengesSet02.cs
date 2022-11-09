using System;
using System.Collections.Generic;
//-----------------------------------------------------------------
//ChallengesWithTestsMark8
//public class ChallengesSet02
//
// Name: David Zientara
// Date: 8-3-2022
// Comments: Made changes to the program, per the instructions
//-----------------------------------------------------------------

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (Char.IsLetter(c));
            /*
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                return true;
            return false;
            */
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
            return ((number % 2) == 0);

            //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            return ((num % 2) != 0);

            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            List<double> list = new List<double>();
            if (numbers == null)
                return 0;
            foreach (var n in numbers)
                list.Add(n);
            if (list.Count == 0)
                return 0;
            // Sort the list; get the min + max
            list.Sort();
            return list[0] + list[list.Count-1];
            //return 0;
            //throw new NotImplementedException();
        }
    

        public int GetLengthOfShortestString(string str1, string str2)
        {
            // Use the ternary operator; streamline it:
            return str1.Length < str2.Length ? str1.Length : str2.Length;
            /*
            if (str1.Length < str2.Length)
                return str1.Length;
            return str2.Length;
            */
           // throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int total = 0;
            if (numbers == null)
                return 0;
            // Get the total + return it
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
            // Iterate through array; total the ones
            // that are even
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
            //Sum up the numbers in the array and return if they're odd
            return ((Sum(numbers.ToArray())%2) != 0);
           
            //throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            // Count the positive odds below the number
            // Return count
            for (long i = 0; i < number; i++)
                if ((i % 2) != 0)
                    count++;
            return count;
            //throw new NotImplementedException();
        }
    }
}
