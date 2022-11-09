using System;
using System.Collections.Generic;

//-----------------------------------------------------------------
//ChallengesWithTestsMark8
//public class ChallengesSet05
//
// Name: David Zientara
// Date: 7-7-2022
// Comments: Made changes to the program, per the instructions
//-----------------------------------------------------------------

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int i = startNumber+1;
            while (true)
            { 
                if ((i % n) == 0)
                    break;
                i++;
            }
            return i;
            ////throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var bus in businesses)
            {
                if (bus.TotalRevenue <= 0)
                    bus.Name = "CLOSED";
            }
            ///businesses.
            ///throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            int? prev = null;
            if (numbers == null || numbers.Length <= 0)
                return false;
            foreach (var n in numbers)
            {   if (prev != null && n < prev)
                    return false;
                prev = n;
            }
           
            return true;
            ///throw new NotImplementedException();
        }
       
        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int i,j;
            int sum = 0;
            // Base cases
            if (numbers == null || numbers.Length <= 0)
                return 0;
            // Keep going until we find an even #
            for (i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2) == 0)
                    break;
            }
            // Go through the rest of the loop; sum up next integers
            // and odd integers
            // If integer is even, reset the counter
            for (sum = 0, j = i + 1; j < numbers.Length; j++)
                if ((numbers[j] % 2) != 0 || j == i + 1)
                {
                    sum += numbers[j];
                    if ((j == i + 1) && (numbers[j] % 2) == 0)
                        i = j;
                }
            return sum;
            ///throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            int i = 0;
            string word;
            if (words == null || words.Length <= 0) 
                return sentence;
            foreach (string w in words)
            {
                word = w.Trim();
                //Only add whitespace i is greater than zero
                //and whitespace doesn't exist
                if (i++ > 0 && !word.Equals("") && !word.Equals(" "))
                   sentence += " ";
     
                if (!word.Equals("") && !word.Equals(" "))
                    sentence += word;
            }
            //Only add a period if there's a sentence
            if (!sentence.Equals(""))
               sentence += ".";
            return sentence;
            //throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            int i = 0;
            const int FOUR = 4;
            var ar = new List<double>();
            //Base cases
            if (elements == null || elements.Count <= 0)
                return ar.ToArray();
            if (elements.Count < FOUR)
                return ar.ToArray();

            foreach (double e in elements)
            {
                i++;
                if ((i % FOUR) == 0)
                    ar.Add(e);
            }
            //Convert to an array because that's the return value
            return ar.ToArray(); // lst;
            //throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int i = 0;
            int j;
            if (nums.Length <= 1)
                return false;
            //Iterate through the array
            //Return if two elements equal target #
            for (i = 0; i < nums.Length; i++)
                for (j = i+1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == targetNumber)
                        return true;
                }
            return false;
            //throw new NotImplementedException();
        }
    }
}
