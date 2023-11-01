using UnityEngine;

public class MySortingMachine
{
    ISort mySort;


    public MySortingMachine(ISort sort)
    {
        mySort = sort;
    }

    public void Sort(int[] arr)
    {
        Debug.Log("=========================¿øº»=========================");
        mySort.SetList(arr);
        mySort.PrintList();

        Debug.Log($"=================={mySort} - Ascending==================");
        mySort.AscendingSort();
        mySort.PrintList();

        Debug.Log($"=================={mySort} - Descending==================");
        mySort.DescendingSort();
        mySort.PrintList();
    }
}
