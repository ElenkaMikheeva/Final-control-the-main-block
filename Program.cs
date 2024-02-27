using System;

public class Program
{
    public static void Main()
    {
        string[] array = {"123", "-2", "2", "Kazan", "gfj", "computer science"};
        Console.WriteLine(string.Join(",", NewArray(array)));
    }

    static string[] NewArray(string[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int curIdx = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                result[curIdx] = arr[i];
                curIdx++;
            }
        }

        return result;
    }
}