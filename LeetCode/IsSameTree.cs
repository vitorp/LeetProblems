namespace LeetCode;
#pragma warning disable CS8604 // Possible null reference argument.
partial class Solution
{
    // Problem IsSameTree #100
    private void EnqueueTree(TreeNode node, Queue<int?> queue)
    {
        if (node is null)
        {
            queue.Enqueue(null);
            return;
        }
        Console.WriteLine($"Stacking: {node.val}");
        queue.Enqueue(node.val);
        EnqueueTree(node.left, queue);
        EnqueueTree(node.right, queue);
        return;
    }

    private bool CompareTreeQueue(TreeNode node, Queue<int?> queue)
    {
        if (!queue.TryDequeue(out int? num))
            return false;
        if (node is null || num is null)
            return (node is null && num is null);

        if (node.val == num)
        {
            return CompareTreeQueue(node.left, queue) && CompareTreeQueue(node.right, queue); ;
        }
        return false;
    }

    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Queue<int?> queue = new();
        EnqueueTree(p, queue);
        return CompareTreeQueue(q, queue);
    }
}
#pragma warning restore CS8604 // Possible null reference argument.
