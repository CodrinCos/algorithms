Console.WriteLine("Build binary tree with preorder and inorder");


public class Alg
{
    public List<TreeNode> Tree = new();
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