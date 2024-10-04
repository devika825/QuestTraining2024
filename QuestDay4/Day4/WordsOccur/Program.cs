using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsOccur
 {
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a really long long text";
            
            string[] words =text.Split(' ');
            string[] wordsFound = new string[words.Length];
            int wordCheckedCount = 0;
            foreach (var word in words)
            {
                if(wordsFound.Contains(word))
                {
                    continue;
                }
                
                    int count = 0;
                    foreach (var item in words)
                    {
                        if (item == word)
                        {
                            count++;

                        }
                    }

                wordsFound[wordCheckedCount] = word;
                wordCheckedCount++;

                    Console.WriteLine($"{word} : {count}");
                  
                
            }
            //for (int i = 0; i < words.Length; i++)
            //{
            //    int count = 0;
            //    string word = words[i];

            //    for (int j = 0; j < words.Length; j++)
            //    {
            //        if (words[j] == word)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"{word}: {count}");
            //}

            
        }
    }
 }
