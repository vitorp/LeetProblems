namespace LeetCode;

#pragma warning disable CS8603 // Possible null reference return.
partial class Solution
{
    // Problem BuildTree #105
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public Stack<int> Stack = new Stack<int>();

    private TreeNode BuildNode(Queue<int> preorder, Queue<int> inorder)
    {
        if (preorder.Count < 1)
        {
            return null;
        }
        TreeNode node = new(preorder.Dequeue());
        Stack.Push(node.val); // Stacks to check when left side is done
        // If inorder == preorder there is no node to the left
        if (node.val != inorder.Peek())
        {
            node.left = BuildNode(preorder, inorder);
        }
        Stack.Pop(); // Pops after left is done
        inorder.Dequeue(); // inorder is always equal to current node here

        // if there is something in the stack that is different from inorder
        // that means there is a subtree to the right of the current node
        if (!Stack.TryPeek(out int top) || top != inorder.Peek())
        {
            node.right = BuildNode(preorder, inorder);
        }
        return node;
    }
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        Queue<int> preorderQueue = new(preorder);
        Queue<int> inorderQueue = new(inorder);
        return BuildNode(preorderQueue, inorderQueue);
    }
}
#pragma warning restore CS8603 // Possible null reference return.
