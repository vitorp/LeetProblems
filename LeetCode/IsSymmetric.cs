namespace LeetCode;
#pragma warning disable CS8604 // Possible null reference argument.
partial class Solution
{
    // Problem IsSymmetric #101
    private void StackTree(TreeNode node, Stack<int?> stack)
    {
        if (node is null)
        {
            stack.Push(null);
            return;
        }
        stack.Push(node.val);
        StackTree(node.left, stack);
        StackTree(node.right, stack);
        return;
    }

    private bool UnstackTree(TreeNode node, Stack<int?> stack)
    {
        if (node is null)
        {
            Console.WriteLine("NULL");
            return stack.TryPop(out int? num) && num is null;
        }

        if (UnstackTree(node.left, stack) && UnstackTree(node.right, stack))
        {
            if (stack.TryPop(out int? current) && current is not null)
            {
                Console.WriteLine($"{current} == {node.val}");
                return current == node.val;
            }
        }
        return false;
    }
    public bool IsSymmetric(TreeNode root)
    {
        if (root is null)
        {
            return true;
        }
        Stack<int?> stack = new();
        StackTree(root.left, stack);
        return UnstackTree(root.right, stack) && stack.Count == 0;
    }
}
#pragma warning restore CS8604 // Possible null reference argument.
