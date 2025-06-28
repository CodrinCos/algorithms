
Console.WriteLine("Reverse linked list");

var start = new Node(1);

var currentNode = new Node(2);
start.Next = currentNode;
for (int i=3; i<10; i++)
{
    var nodeToAdd = new Node(i);
    currentNode.Next = nodeToAdd;
    currentNode = currentNode.Next;
}

currentNode = start;
while (currentNode != null)
{
    Console.Write(currentNode.Value + " ");
    currentNode = currentNode.Next;
}

Console.WriteLine("Reversed");
var newStart = ReverseLinkedList(start);

currentNode = newStart;
while (currentNode != null)
{
    Console.Write(currentNode.Value + " ");
    currentNode = currentNode.Next;
}

Node ReverseLinkedList(Node head)
{
    // Initialize three pointers: curr, prev and next
    Node curr = head;
    Node prev = null;
    Node next;

    // Traverse all the nodes of Linked List
    while (curr != null)
    {

        // Store next
        next = curr.Next;

        // Reverse current node's next pointer
        curr.Next = prev;

        // Move pointers one position ahead
        prev = curr;
        curr = next;
    }

    // Return the head of reversed linked list
    return prev;
}

public class Node 
{
    public Node(int value)
    {
        Value = value;   
    }
    public int Value { get; set; }
    public Node? Next { get; set; }
}