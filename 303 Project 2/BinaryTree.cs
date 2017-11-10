namespace _303_Project_2
{
    class BinaryTree<T>
    {
        BTNode<T> root = new BTNode<T>();

        public BTNode<T> Root { get => root; set => root = value; }
    }

    class BTNode<T> {
        T data;
        BTNode<T> left;
        BTNode<T> right;

        public T Data { get => data; set => data = value; }
        public BTNode<T> Left { get => left; set => left = value; }
        public BTNode<T> Right { get => right; set => right = value; }
    }
}
