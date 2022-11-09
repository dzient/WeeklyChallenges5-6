using System;
using System.Collections.Generic;

//-----------------------------------------------------------------
//ChallengesWithTestsMark8
//public class ChallengesSet06
//
// Name: David Zientara
// Date: 7-7-2022
// Comments: Made changes to the program, per the instructions
//-----------------------------------------------------------------

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
                return false;
            //If ignoreCase, Convert everything to uppercase; otherwise do comparison 
            if (ignoreCase)
            {
                foreach (var w in words)
                    if (w != null && (w.ToUpper()).Equals(word.ToUpper()))
                        return true;
            }
            else
            {
                foreach (var w in words)
                    if (w != null && w.Equals(word))
                        return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            // Base cases
            if (num <= 1)
                return false;
            if (num <= 3)
                return true;
            //Return false if number is divisible 
            //By number less than itself; else
            //Return true
            for (int i = 2; i < num; i++)
                if ((num % i) == 0)
                    return false;
            return true;
           // throw new NotImplementedException();
        }
        

        public int IndexOfLastUniqueLetter(string str)
        {
            int[] letters = new int[26];
            int last, i = 0;
            // Initialize to -1:
            for (i = 0; i < letters.Length; i++)
                letters[i] = -1;
            str = str.ToUpper();
            // -1 denotes that no value was put in array, so put a value in it
            // -2 denotes a duplicate; don't put value in array
            // Everything else denotes a value; don't put anything in it
            for (i = 0; i < str.Length; i++)
                if (letters[(str[i] - 65)] == -1)
                    letters[(str[i] - 65)] = i;
            else if (letters[(str[i] - 65)] == i-1)
                    letters[(str[i] - 65)] = -2;
            last = -1;
            for (i = 0; i < letters.Length; i++)
                if (letters[i] > last)
                    last = letters[i];
            return last;
             //   throw new NotImplementedException();
        }
        
        public int MaxConsecutiveCount(int[] numbers)
        {
            int? prev = null;
            int i = 0;
            int j = 0;
            int maxcount = 0;
            //Base cases
            if (numbers == null || numbers.Length == 0)
                return 0;

            foreach (var n in numbers)
            {
                if (n == prev)
                    j++;
                else
                    j = 1;
                prev = n;
                if (j > maxcount)
                    maxcount = j;
            }
            return maxcount;

            //throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            int i = 0;

            var ar = new List<double>();
            //Base cases
            if (elements == null || n <= 0)
                return ar.ToArray();
            if (n == 1)
                return elements.ToArray();
          
            //Add each nth element to array
            foreach (double e in elements)
            {
                i++;
                if ((i % n) == 0)
                    ar.Add(e);
            }
            //Return an array, because that's the return value
            return ar.ToArray(); // lst;
            ///throw new NotImplementedException();
        }
    }
}
