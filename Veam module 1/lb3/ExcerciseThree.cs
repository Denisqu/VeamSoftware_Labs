using System;
using System.Collections.Generic;
using System.Linq;
namespace VeamSoftware_Labs.Veam_module_1.lb3
{
    public class ExcerciseThree
    {
        private static string sentence = "Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена";

        public static void PrintResult()
        {
            foreach (var group in Analyzer.Analyze(sentence))
            {
                Console.WriteLine($"Group {group.GroupNumber}. Length {group.WordLength}, Count {group.words.Count}");

                foreach (var word in group.words)
                {
                    Console.WriteLine(word);
                }
                
                Console.WriteLine("");
            }
        }
        
    }

    public class Analyzer
    {
        public static List<WordGroup> Analyze(string sentence)
        {
            void SplitByWords(string s, out string[] splittedStrings)
            {
                
                List<char> charsToRemove = new List<char>()
                {
                    '!',
                    '?',
                    ',',
                    '.',
                    ';',
                    ':',
                    '-'
                };

                string clearedString = Filter(s, charsToRemove);
                splittedStrings = clearedString.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            }
            
            SplitByWords(sentence, out var words);
            
            
            List<WordGroup> wordGroups = new List<WordGroup>();
            
            foreach (var word in words)
            {
                int wordLength = word.Length;

                var localGroup = (from gr in wordGroups where gr.WordLength == wordLength select gr).FirstOrDefault();

                if (localGroup == null)
                {
                    WordGroup newGroup = new WordGroup(wordLength, wordGroups.Count + 1);
                    newGroup.words.Add(word);
                    wordGroups.Add(newGroup);
                    
                    continue;
                }
                
                localGroup.words.Add(word);

            }

            wordGroups.Sort((group1, group2) =>
            {
                if (group1.words.Count > group2.words.Count)
                {
                    return -1;
                }
                if (group1.words.Count < group2.words.Count)
                {
                    return 1;
                }
                return 0;
            });

            return wordGroups;
        }
        
        private static string Filter(string str, List<char> charsToRemove)
        {
            foreach (char c in charsToRemove) {
                str = str.Replace(c.ToString(), String.Empty);
            }
 
            return str;
        }
        
    }

    public class WordGroup
    {
        public int WordLength { get; }
        public int GroupNumber { get; }
        public List<string> words = new();

        public WordGroup(int wordLength, int groupNumber)
        {
            WordLength = wordLength;
            GroupNumber = groupNumber;
        }

    }
    
    
    
    
}