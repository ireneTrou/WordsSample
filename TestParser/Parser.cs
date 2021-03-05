using System;
using System.Collections.Generic;
using System.Text;

namespace TestParser
{
    public class Parser
    {
        private static List<string> Punctuation = new List<string>() {".",",",";","!","?",":"};
        /// <summary>
        /// parse the text and return unique words with their count in the text 
        /// word's derivatives are count as separate words
        /// text is assumed to be written grammaticaly correct
        /// </summary>
        /// <param name="text">text as input</param>
        /// <returns></returns>
        public static SortedDictionary<string, int> Parse(string text)
        {
            var parsed = new SortedDictionary<string, int>();

            if (!string.IsNullOrEmpty(text))
            {
                foreach (var pu in Punctuation)
                {
                    text = text.Replace(pu, "");
                }
                text = text.Replace(" - ", " ").Replace(Environment.NewLine," ");

                var words = text.Split(new char[] { ' ' });

                foreach (var word in words)
                {
                    if (word != "")
                    {
                        if (parsed.ContainsKey(word))
                        {
                            parsed[word] += 1;
                        }
                        else
                        {
                            parsed[word] = 1;
                        }
                    }
                }
            }
            return parsed;
        }
    }
}
