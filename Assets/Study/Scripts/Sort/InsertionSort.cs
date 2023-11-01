using System;

public class InsertionSort
{
    public int[] List { get; private set; }


    public void SetList(int[] arr)
    {
        List = arr;
    }

    public void Sort(bool isAscending)
    {
        if (isAscending) 
        { Compare = Ascending; }
        else 
        { Compare = Descending; }
        
        Sort();
    }

    #region Sort
    Func<int, int, bool> Compare = null;

    void Sort()
    {
        int n = List.Length;

        for (int i = 1; i < n; i++)
        {
            int key = List[i];
            int j = i - 1;

            while (j >= 0 && Compare(List[j], key))
            {
                List[j + 1] = List[j];
                j--;
            }
            List[j + 1] = key;
        }
    }

    bool Ascending(int a, int b) { return a > b; }

    bool Descending(int a, int b) { return a < b; }
    #endregion
}