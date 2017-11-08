using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _303_Project_2
{
    class BinaryTree<T>
    {
        BTNode<T> root;
    }

    class BTNode<T> {
        T data;
        BTNode<T> left;
        BTNode<T> right;
    }
}
