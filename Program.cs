
Console.WriteLine("Build binary tree with preorder and inorder");


public class Alg
{
    public List<TreeNode> Tree = new();
    //o(N 2)
    public static TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        if (inorder.Length == 0)
        {
            return null;
        }

        if (preorder.Length == 1)
        {
            return new TreeNode(preorder[0]);
        }

        var rootValue = preorder[0];
        preorder = [.. preorder.Skip(1)];
        bool found = false; int indexInorder = 0;

        while(!found)
        {
            if (inorder[indexInorder] == rootValue) found = true;
            else indexInorder++;
        }

        TreeNode node = new TreeNode(rootValue);

        node.left = BuildTree(preorder, [.. inorder.Take(inorder.Length - indexInorder)]);
        node.right = BuildTree(preorder, [.. inorder.Skip(indexInorder + 1)]);

        return node;
    }

    //OPTIMIZED
    public static TreeNode? BuildTreeEfficient(int[] preorder, int[] inorder)
    {
        var memory = new Dictionary<int, int>();

        for (int i = 0; i < inorder.Length; i++)
        {
            memory[inorder[i]] = i;
        }

        var root = BuildRecursively(preorder, inorder, 0, inorder.Length - 1, memory);
    }

    private static object BuildRecursively(int[] preorder, int[] inorder, int leftPointer, int rightPointer, 
        Dictionary<int, int> memory)
    {
        throw new NotImplementedException();
    }

    public static void InvertBinaryTree(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        // Swap the left and right children
        var temp = root.left;
        root.left = root.right;
        root.right = temp;
        // Recursively invert the left and right subtrees
        InvertBinaryTree(root.left);
        InvertBinaryTree(root.right);
    }

    public static TreeNode? CreateBinarySearchTree(int[] values)
    {

    }
}

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int x)
    {
        val = x;
        left = null;
        right = null;
    }
}