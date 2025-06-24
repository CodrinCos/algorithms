Console.WriteLine("Graph basics");
var node1 = new Node("A");
var node2 = new Node("B");
var node3 = new Node("C");
var node4 = new Node("D");
var node5 = new Node("E");
var node6 = new Node("F");
var node7 = new Node("G");

node1.AdjacencyList.Add(node2);
node1.AdjacencyList.Add(node3);
node1.AdjacencyList.Add(node4);

node2.AdjacencyList.Add(node5);
node2.AdjacencyList.Add(node6);

node4.AdjacencyList.Add(node7);

//Console.WriteLine("BFS");

//Queue<Node> queue = new Queue<Node>();
//queue.Enqueue(node1);
//node1.IsVisited = true;

//Console.Write(node1.Value + " ");

//while (queue.Count > 0)
//{
//    Node currentNode = queue.Dequeue();
//    foreach (Node node in currentNode.AdjacencyList)
//    {
//        if (!node.IsVisited)
//        {
//            queue.Enqueue(node);
//            node.IsVisited = true;
//            Console.Write(node.Value + " ");
//        }
//    }
//}

Console.WriteLine("DFS");

var traversal = new List<string>();

Graph.DFS(node1, traversal);

foreach (var item in traversal)
{
    Console.Write(item + " ");
}




class Node(string value)
{
    public string Value { get; } = value;
    public List<Node> AdjacencyList { get; set; } = new List<Node>();
    public bool IsVisited { get; set; } = false;
}

class Graph
{
    public static void DFS(Node node, List<string> traversal)
    {
        node.IsVisited = true;
        traversal.Add(node.Value);
        foreach (Node adjacentNode in node.AdjacencyList)
        {
            if (!adjacentNode.IsVisited)
            {
                DFS(adjacentNode, traversal);
            }
        }
    }
}