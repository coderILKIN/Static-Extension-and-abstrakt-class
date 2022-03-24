using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Extensions
{
    static class Extension
    {


        public static string customContains(this string word,string findword)
        {
            
                StringBuilder stringBuilder = new StringBuilder();
                word = word.ToLower();
                string[] words = word.Split();
                

            foreach (string word1 in words)
            {
                stringBuilder.Append(char.ToUpper(word[0]));
                for (int i = 1; i < word.Length; i++)
                {
                    stringBuilder.Append(word[i]);
                }


                if (word != words[words.Length - 1])
                {
                    stringBuilder.Append(" ");
                }

            }


            return stringBuilder.ToString();



        }
        


    }
}
