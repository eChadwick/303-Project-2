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
        string Decode(string input) { return ""; }
        string Encode(string input) { return ""; }

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
    }
}

