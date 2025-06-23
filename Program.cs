Console.WriteLine("BFS");

var tree = new BinaryTree(new Node(3));
tree.Root.Left = new Node(4);
tree.Root.Left.Left = new Node(6);
tree.Root.Left.Right = new Node(7);
tree.Root.Right = new Node(5);
tree.Root.Right.Left = new Node(8);
tree.Root.Right.Right = new Node(9);

tree.BFS();



class Node(int value)
{
    public int Value { get; set; } = value;
    public Node? Left { get; set; } = null;
    public Node? Right { get; set; } = null;
}

class BinaryTree
{
    public Node Root { get; set; }
    public BinaryTree(Node root)
    {
        this.Root = root;
    }

    public void BFS()
    {
        Queue<Node> queue = new();
        queue.Enqueue(Root);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Value + " ");
            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }
            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }
    }
}