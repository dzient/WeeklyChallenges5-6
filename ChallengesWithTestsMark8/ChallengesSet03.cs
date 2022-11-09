using System;
using System.Collections.Generic;

//-----------------------------------------------------------------
//ChallengesWithTestsMark8
//public class ChallengesSet03
//
// Name: David Zientara
// Date: 7-7-2022
// Comments: Made changes to the program, per the instructions
//-----------------------------------------------------------------

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var v in vals)
                if (!v)
                    return true;
            return false;
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            long sum = 0;

            if (numbers == null)
                return false;
            foreach (var v in numbers)
                sum += v;
            if ((sum % 2) != 0)
                return true;
            return false;
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            int i;
            bool a, b, c;
            a = b = c = false;
            if (password == null)
                return false;
            //Set everything to false, then
            //set to true if condition is met
            for (i = 0; i < password.Length; i++)
                if (password[i] >= 'A' && password[i] <= 'Z')
                    a = true;

            for (i = 0; i < password.Length; i++)
                if (password[i] >= 'a' && password[i] <= 'z')
                    b = true;

            for (i = 0; i < password.Length; i++)
                if (password[i] >= '0' && password[i] <= '9')
                    c = true;

            return (a && b && c);
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            return (dividend / divisor);
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums[nums.Length - 1] - nums[0]);
            //throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 1; i < 100; i += 2)
                list.Add(i);
            return list.ToArray();
            //throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // Use the built-in method to convert to uppercase
            int i;
            i = 0;
            foreach (var word in words)
                words[i++] = word.ToUpper();
            return;
            throw new NotImplementedException();
        }
    }
}
