using static LeetCode.Solution;

namespace LeetCode.Util;
public class PrintHelper
{
    public static void PrintTreeDepth(TreeNode treeNode, int depth)
    {
        Queue<TreeNode?> queue = new();
        queue.Enqueue(treeNode);
        PrintTreeLoop(queue, depth);
    }

    private static void PrintTreeLoop(Queue<TreeNode?> queue, int depth)
    {
        if (depth < 1)
        {
            return;
        }

        Queue<TreeNode?> aux = new();
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node is null)
            {
                Console.Write("NULL ");
                continue;
            }
            Console.Write($"{node.val} ");
            aux.Enqueue(node.left);
            aux.Enqueue(node.right);
        }
        Console.Write("\n");
        PrintTreeLoop(aux, depth - 1);
        return;
    }
}
