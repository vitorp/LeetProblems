using System.Text;

namespace LeetCode;
partial class Solution
{
    // Problem DecodeString #394
    public string DecodeString(string s)
    {
        Stack<string> stringStack = new();
        Stack<int> repeatStack = new();
        StringBuilder result = new();
        StringBuilder aux = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (Char.IsNumber(s[i]))
            {
                int start = i;
                i++;
                while (Char.IsNumber(s[i]))
                {
                    i++;
                }
                repeatStack.Push(int.Parse(s.Substring(start, i - start)));
            }
            if (s[i] == ']')
            {
                while (stringStack.TryPop(out string str))
                {
                    if (str == "[")
                    {
                        break;
                    }
                    aux.Insert(0, str);
                }
                repeatStack.TryPop(out int times);
                string subStr = aux.ToString();
                aux.Clear();
                while (times > 1)
                {
                    stringStack.Push(subStr);
                    times--;
                }
                stringStack.Push(subStr);
            }
            else
            {
                stringStack.Push(s[i].ToString());
            }
        }
        foreach (string str in stringStack)
        {
            result.Insert(0, str);
        }
        return result.ToString();
    }
}
