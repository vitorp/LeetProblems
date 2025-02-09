namespace LeetCode;
#pragma warning disable CS8604 // Possible null reference argument.
partial class Solution
{
    // Problem MaxDepth #104
    public int MaxDepth(TreeNode node)
    {
        if (node is null)
        {
            return 0;
        }
        return Math.Max(1 + MaxDepth(node.left), 1 + MaxDepth(node.right));
    }
}
#pragma warning restore CS8604 // Possible null reference argument.
