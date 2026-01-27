using System;

namespace CheckAnagram
{
    class Program
    {
        static bool Check_Anagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            Dictionary<char, int> freq = new Dictionary<char, int>();

            foreach (char c in s1.ToLower())
            {
                if(freq.ContainsKey(c)){
                    freq[c]++;
                }
                else{
                    freq[c]=1;
                }
            }
            foreach(char c in s2.ToLower()){
                if(!freq.ContainsKey(c)){
                    return false;
                }
                else{
                    freq[c]--;
                }
            }

            foreach (var val in freq)
            {
                if (val.Value != 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";
            Console.WriteLine($"Are '{str1}' and '{str2}' anagrams? {Check_Anagram(str1, str2)}");
        }
    }
}