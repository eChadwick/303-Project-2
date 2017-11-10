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

        String[] morse_codes = new String[26];
        BinaryTree<Char> decoding_tree = new BinaryTree<Char>();

        public MorseHandler(String path)
        {
            foreach (String line in File.ReadLines(path))
            {
                Char alpha = line[0];
                String morse = line.Substring(1);
                morse_codes[alpha - 'a'] = morse;

                var current_node = decoding_tree.Root;
                foreach (Char data in morse)
                {
                    if (data == '.')
                    {
                        if (current_node.Left == null)
                        {
                            current_node.Left = new BTNode<Char>();
                        }
                        current_node = current_node.Left;
                    }
                    else if (data == '_')
                    {
                        if (current_node.Right == null)
                        {
                            current_node.Right = new BTNode<Char>();
                        }
                        current_node = current_node.Right;
                    }
                }
                current_node.Data = alpha;
            }
        }
    }
}

