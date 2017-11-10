using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _303_Project_2
{
    class MorseHandler
    {
        void IngestData() { }
        String Decode(string input) { return ""; }

        List<string> morse_codes;
        BinaryTree<char> decoding_tree;

        public MorseHandler(String path)
        {
            foreach (String line in File.ReadLines(path))
            {
                Char alpha = line[0];
                String morse = line.Substring(1);
                morse_codes[alpha - 'a'] = morse;
            }
        }

        String Encode(String input)
        {
            var code = new List<String>(input.Count());
            foreach (Char c in input)
                code.Add(morse_codes[c - 'a']);

            return String.Join(" ", code);
        }
    }
}

