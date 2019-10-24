using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Trezeo_T_A
{
    public class ProcessFile
    {
        public void Word_Unique_First(string fileName)
        {
            var wordDictionary = new Dictionary<string, int>();
            Console.WriteLine(DateTime.Now);
            using (StreamReader reader = new StreamReader(new FileStream(fileName, FileMode.Open)))
            {
                string word = "";
                while (!reader.EndOfStream)
                {
                    var character = (char)reader.Read();
                    if (Char.IsLetterOrDigit(character))
                    {
                        word += character;
                    }
                    else
                    {
                        word = word.ToLower();
                        if (wordDictionary.ContainsKey(word))
                        {
                            wordDictionary[word]++;
                        }
                        else
                        {
                            wordDictionary.Add(word, 1);
                        }
                        word = "";
                    }
                }
            }
            Console.WriteLine(wordDictionary.FirstOrDefault(x => x.Value == 1).Key);
            Console.WriteLine(DateTime.Now);
            Console.ReadKey();
        }

    }
}
