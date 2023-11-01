public class QuickSort
{
    public int[] List { get; private set; }

    public void SetList(int[] arr)
    {
        List = arr;
    }

    public void Sort(SortOrderType type = SortOrderType.Ascending)
    {
        switch (type)
        {
            case SortOrderType.Ascending:
                Compare = Ascending;
                break;
            case SortOrderType.Descending:
                Compare = Descending;
                break;
            default:
                Compare = Ascending;
                break;
        }
        Sort(List, 0, List.Length - 1);
    }

    #region Sort
    System.Func<int, int, bool> Compare = null;

    void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            Sort(arr, left, pivot - 1);
            Sort(arr, pivot + 1, right);
        }
    }

    int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = (left - 1);

        for (int j = left; j <= (right - 1); j++)
        {
            if (Compare(arr[j], pivot))
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, right);
        return (i + 1);
    }

    void Swap(int[] arr, int a, int b)
    {
        (arr[b], arr[a]) = (arr[a], arr[b]);
    }

    bool Ascending(int a, int b) { return a <= b; }

    bool Descending(int a, int b) { return a >= b; }
    #endregion
}