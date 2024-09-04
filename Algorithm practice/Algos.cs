using System;
using System.Text.RegularExpressions;

namespace Algorithm_practice
{
    public static class Algos
    {
        public static List<int> FindIntegersInAString(string input)
        {
            // Define a regex pattern to match sequences of digits
            string pattern = @"\d+";

            // Find all matches using Regex
            var matches = Regex.Matches(input, pattern);

            // Store the extracted numbers
            List<int> numbers = new List<int>();

            foreach (Match match in matches)
            {
                // Convert the matched string to an integer and add it to the list
                numbers.Add(int.Parse(match.Value));
            }

            return numbers;
        }

        public static List<int> FindNumbersInString(string input)
        {
            List<int> numbers = new List<int>();
            string currentNumber = "";  // To store the digits as we find them

            foreach (char c in input)
            {
                // Check if the character is a digit
                if (char.IsDigit(c))
                {
                    currentNumber += c;  // Add the digit to the current number
                }
                else
                {
                    // If we've built a number, add it to the list and reset
                    if (currentNumber != "")
                    {
                        numbers.Add(int.Parse(currentNumber));
                        currentNumber = "";  // Reset for the next number
                    }
                }
            }

            // Check if there's any remaining number after the loop
            if (currentNumber != "")
            {
                numbers.Add(int.Parse(currentNumber));
            }

            return numbers;

        }

        public static List<char> FindCommonCharacters(List<string> input)
        {
            // Convert all strings to lowercase for case-insensitivity
            for (int i = 0; i < input.Count; i++)
            {
                input[i] = input[i].ToLower();
            }

            // Create a list to store common characters
            List<char> commonChars = new List<char>();

            // Get the first string and work with it
            string firstString = input[0];

            // Iterate over each character in the first string
            foreach (char c in firstString)
            {
                // Assume the character is common
                bool isCommon = true;

                // Check if this character exists in all other strings
                for (int i = 1; i < input.Count; i++)
                {
                    // If the character is not found, it's not common
                    if (!input[i].Contains(c))
                    {
                        isCommon = false;
                        break;
                    }
                    else
                    {
                        // Remove the first occurrence of the character to handle duplicates properly
                        int index = input[i].IndexOf(c);
                        if (index != -1)
                        {
                            input[i] = input[i].Remove(index, 1);
                        }
                    }
                }

                // If the character is common, add it to the list
                if (isCommon)
                {
                    commonChars.Add(c);
                }
            }

            return commonChars;
        }


        public static List<char> FindCommonChars(List<string> input)
        {
            // Convert all strings to lowercase for case-insensitivity
            for (int i = 0; i < input.Count; i++)
            {
                input[i] = input[i].ToLower();
            }

            // Dictionary to store minimum frequency of each character
            Dictionary<char, int> commonChars = new Dictionary<char, int>();

            // Initialize the frequency dictionary with the first string
            foreach (char c in input[0])
            {
                if (commonChars.ContainsKey(c))
                    commonChars[c]++;
                else
                    commonChars[c] = 1;
            }

            // Process each of the other strings
            for (int i = 1; i < input.Count; i++)
            {
                // Create a temporary dictionary to track frequency in the current string
                Dictionary<char, int> currentFreq = new Dictionary<char, int>();

                foreach (char c in input[i])
                {
                    if (currentFreq.ContainsKey(c))
                        currentFreq[c]++;
                    else
                        currentFreq[c] = 1;
                }

                // Update commonChars dictionary to keep minimum counts
                foreach (var key in new List<char>(commonChars.Keys))
                {
                    if (currentFreq.ContainsKey(key))
                        commonChars[key] = Math.Min(commonChars[key], currentFreq[key]);
                    else
                        commonChars.Remove(key); // Remove characters not found in the current string
                }
            }

            // Create a list to store the result
            List<char> result = new List<char>();

            // Build the result list based on the frequency in the commonChars dictionary
            foreach (var entry in commonChars)
            {
                for (int i = 0; i < entry.Value; i++)
                {
                    result.Add(entry.Key);
                }
            }

            return result;

        }

        //Nearest Sq
        public static int nearest_Sqrt(int n)
        {
            //first check for the square root of the number
            double num = Math.Sqrt(n);
            double result = Math.Round(num);

            return (int)Math.Pow(result, 2);
        }

        //Nth Fibo Series
        public static int NthFib(int n)
        {
            //Fibonacci series
            //0,1,1,2,3,5,8,13,21
            int a = 0;
            int c = 0;
            int b = 1;

            if (n == 0)
                return 0;
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;

            }
            return b;
        }
        //Two Sum

        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
                for (int j = 0; j < numbers.Length; j++)
                    if (numbers[i] + numbers[j] == target)
                        return new int[] { numbers[i], numbers[j] };
            return new int[] { 0 };
        }

        //missing letter

        public static char MChar(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i + 1] - str[i] > 1)
                    return (char)(str[i] + 1);
            }
            return ' ';
        }

        //count occurance

        public static Dictionary<char, int> LCount(string word)
        {
            var str = "AabbCCDDEEgghh";
            return word.GroupBy(x => char.ToLower(x)).ToDictionary(b => b.Key, b => b.Count());
        }


        //vowel count

        public static int VowelCount(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            return word.Count(x => vowels.Contains(x));
        }

        //IsPrime

        public static bool IsPrime(int n)
        {
            //check to see if ther number is < 1;
            if (n <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //fibonacci

        public static void FiboNumbers(int n)
        {
            //0,1,1,2,3,5,8,13...
            int fN = 0;
            int sN = 1;
            Console.WriteLine(fN);
            Console.WriteLine(sN);
            for (int i = 2; i < n; i++)
            {
                int next = fN + sN;
                Console.WriteLine(next);
                fN = sN;
                sN = next;
            }

        }

        //palindrome

        public static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (char.ToLower(str[left]) != char.ToLower(str[right]))
                {
                    return false;
                }
                left++;
                right--;

            }

            return true;


        }

        //reverse string

        public static string RevString(string str)
        {
            //Firslty split the 	string
            string[] word = str.Split(' ');
            return string.Join(" ", word.Select(x => new string(x.Reverse().ToArray())));
            //char[] rev = str.ToCharArray();
            //Array.Reverse(rev);
            //return new string(rev);
        }

        //They gave me an invalid url and asked me to return the first number within the url.
        //Example.www.goggle1.com/axxess2.

        public static int ExtNum(string str)
        {
            var num = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    num += str[i];
            }
            return int.Parse(num);
        }
        
    }
}

