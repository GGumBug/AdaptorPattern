using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insertionSortAdaptor : ISort
{
    private InsertionSort _insertionSort;
    private BubbleSort _bubbleSort;

    public insertionSortAdaptor()
    {
        _insertionSort = new();
        _bubbleSort = new();
    }
    
    public void SetList(int[] arr)
    {
        _insertionSort.SetList(arr);
    }

    public void AscendingSort()
    {
        _insertionSort.Sort(true);
    }

    public void DescendingSort()
    {
        _insertionSort.Sort(false);
    }

    public void PrintList()
    {
        _bubbleSort.SetList(_insertionSort.List);
        _bubbleSort.PrintList();
    }
}
