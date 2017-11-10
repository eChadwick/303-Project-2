using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _303_Project_2
{
    /// <summary>
    /// Class to handle encoding of a word in alpha characters to morse code or decoding of a morse word  to alpha characters.
    /// </summary>
    class MorseHandler
    {
        String[] morse_codes = new String[26];
        BinaryTree<Char> decoding_tree = new BinaryTree<Char>();
        /// <summary>
        /// Constructs a MorseHandler using the given morse code translation file.
        /// </summary>
        /// <param name="path">Path to translation file.</param>
        public MorseHandler(String path)
        {
            foreach (String line in File.ReadLines(path))
            {
                Char alpha = line[0];
                String morse = line.Substring(1);
                morse_codes[alpha - 'a'] = morse;

                var current_node = decoding_tree.Root;
                foreach (Char data in morse)
                    if (data == '.')
                    {
                        if (current_node.Left == null)
                            current_node.Left = new BTNode<Char>();

                        current_node = current_node.Left;
                    }
                    else if (data == '_')
                    {
                        if (current_node.Right == null)
                            current_node.Right = new BTNode<Char>();

                        current_node = current_node.Right;
                    }

                current_node.Data = alpha;
            }
        }

        public String Encode(String input)
        {
            var code = new List<String>(input.Length);
            foreach (Char c in input.ToLower())
                code.Add(morse_codes[c - 'a']);

            return String.Join(" ", code);
        }

        public String Decode(String input)
        {
            var builder = new StringBuilder();
            var current_node = decoding_tree.Root; 
            foreach (Char c in input)
            {
                if (c == '.')
                    current_node = current_node.Left;
                else if (c == '_')
                    current_node = current_node.Right;
                else if (c == ' ')
                {
                    builder.Append(current_node.Data);
                    current_node = decoding_tree.Root;
                }
                else
                    throw new Exception("Unexpected character " + c);
            }
            builder.Append(current_node.Data);

            return builder.ToString();
        }

    }
}

