using System;
using System.Text;
using UnityEngine;

public class SelectionSort : ISort
{
    public int[] List { get; private set; }


    public void SetList(int[] arr)
    {
        List = arr;
    }

    public void AscendingSort()
    {
        Compare = Ascending;
        Sort();
    }

    public void DescendingSort()
    {
        Compare = Descending;
        Sort();
    }

    public void PrintList()
    {
        StringBuilder sb = new();

        foreach (var i in List)
        {
            sb.Append($"{i}, ");
            Console.WriteLine(i);
        }
        sb.Remove(sb.Length - 2, 2);

        Debug.Log(sb.ToString());
    }


    #region Sort
    static Func<int, int, bool> Compare = null;

    void Sort()
    {
        int n = List.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < n; j++)
            {
                if (Compare(List[j], List[min]))
                    min = j;
            }

            (List[i], List[min]) = (List[min], List[i]);
        }
    }

    bool Ascending(int a, int b) { return a < b; }

    bool Descending(int a, int b) { return a > b; }
    #endregion
}