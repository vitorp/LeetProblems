namespace LeetCode;
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8603 // Possible null reference return.
partial class Solution
{
    // Problem InvertTree #226
    private static void InvertTreeLoop(TreeNode node)
    {
        if (node is not null)
        {
            (node.right, node.left) = (node.left, node.right);
            InvertTreeLoop(node.left);
            InvertTreeLoop(node.right);
        }
    }

    public TreeNode InvertTree(TreeNode root)
    {
        if (root is not null)
        {
            InvertTreeLoop(root);
        }
        return root;
    }

    // Solution with single method
    public TreeNode InvertTreeAlternative(TreeNode root)
    {
        if (root is null)
        {
            return null;
        }
        (root.right, root.left) = (root.left, root.right);
        InvertTreeAlternative(root.left);
        InvertTreeAlternative(root.right);
        return root;
    }
}
#pragma warning restore CS8603 // Possible null reference return.
#pragma warning restore CS8604 // Possible null reference argument.
