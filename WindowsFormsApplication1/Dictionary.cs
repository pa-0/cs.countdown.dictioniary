using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountdownApp
{
    class Dictionary : IDictionary
    {
        protected List<string> Words;

        public List<string> Load(string filePath)
        {
            Words = new List<string>(File.ReadAllLines(filePath));
            return Words;
        }

        public string MatchWord(List<string> letters)
        {
            //find the longest word that contains all the characters in the list of letters
            string match = "";

            //TODO search via regular expressions and the like to find the best match
            foreach (var s in letters)
            {
                match += s;
            }

            return match;
        }
    }
}
