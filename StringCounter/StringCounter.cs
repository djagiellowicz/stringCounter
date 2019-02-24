using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCounter
{
    class StringCounter
    {
        // =================================== Dictionary
        public static void PrintOccurencesFromDict(string toCount)
        {
            Dictionary<char, int> occurenceDictionary = GetDictOfOccurences(toCount);

            // ====== THIS IS NOT NEEDED, occurenceDictionary, could be passed to below foreach, it just sorts list made from Dictionary
            List<KeyValuePair<char, int>> AlfabeticalySortedKeyValueList = occurenceDictionary.ToList();
            AlfabeticalySortedKeyValueList.Sort(ComparatorToSortAlfabeticaly);
            // ====== THIS IS NOT NEEDED, occurenceDictionary, could be passed to below foreach

            foreach (KeyValuePair<char, int> value in AlfabeticalySortedKeyValueList)
            {
                Console.WriteLine($"{value.Key} appeared: {value.Value} times");
            }
        }

        private static Dictionary<char, int> GetDictOfOccurences(string toCount)
        {
            toCount = toCount.ToLower();
            int TO_COUNT_LENGTH = toCount.Length;
            Dictionary<char, int> occurenceDictionary = new Dictionary<char, int>();

            for (int i = 0; i < TO_COUNT_LENGTH; i++)
            {
                if (occurenceDictionary.ContainsKey(toCount[i]))
                {
                    occurenceDictionary[toCount[i]]++;
                }
                else
                {
                    occurenceDictionary.Add(toCount[i], 1);
                }
            }
            return occurenceDictionary;
        }

        // ====== THIS IS NOT NEEDED, comparator to sort list made from dictionary
        private static int ComparatorToSortAlfabeticaly(KeyValuePair<char, int> x, KeyValuePair<char, int> y)
        {
            return x.Key.CompareTo(y.Key);
        }

        // =================================== Dictionary
        // =================================== List
        public static void PrintOccurencesWithList(string toCount)
        {
            toCount = toCount.ToLower();
            List<char> listOfUsedChars = new List<char>();
            int numberOfOccurences;
            bool wasAlreadyUsed;
            char charAtI;

            for (int i = 0; i < toCount.Length; i++)
            {
                wasAlreadyUsed = false;
                numberOfOccurences = 0;
                charAtI = toCount[i];

                foreach (char character in listOfUsedChars)
                {
                    if (character == charAtI)
                    {
                        wasAlreadyUsed = true;
                        break;
                    }
                }

                if (!wasAlreadyUsed)
                {
                    for (int j = i; j < toCount.Length; j++)
                    {
                        if (charAtI == toCount[j])
                        {
                            numberOfOccurences++;
                        }
                    }
                    listOfUsedChars.Add(toCount[i]);
                    Console.WriteLine($"{charAtI} appeared: {numberOfOccurences}");
                }     
            }
        }
        // =================================== List
    }
}        

