using System;
using System.Collections.Generic;
using System.Linq;
namespace VeamSoftware_Labs.Veam_module_1.lb3
{
    public class ExcerciseFour
    {
        public static void PrintResult()
        {
            string sentence = "This dog eats too much";

            foreach (var page in Converter.Convert(sentence, 2))
            {
                foreach (var word in page)
                {
                    Console.Write($"{word} ");
                }
                
                Console.WriteLine(String.Empty);
            }
            
        }
    }

    public static class Converter
    {
        private static readonly Dictionary<string, string> englishToRussian = new()
        {
            {
                "this", "эта"
            },
            {
                "dog", "собака"
            },
            {
                "eats", "ест"
            },
            {
                "too", "слишком"
            },
            {
                "much", "много"
            }
            
        };
        
        public static List<List<string>> Convert(string sentence, int n)
        {
            var translatedAndUpperWordsPerPage =
                sentence.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)
                    .Select((v, i) => new
                    {
                        val = englishToRussian[v.ToLower()].ToUpper(),
                        idx = i
                    })
                    .GroupBy(x => x.idx / n)
                    .Select(g => g.Select(y => y.val).ToList())
                    .ToList();

            return translatedAndUpperWordsPerPage;
        }
    }


    
        

    
    
}