public interface ISort
{
    void SetList(int[] arr);

    /// <summary> 1 → 2 → 3 → 4 → …… </summary>
    void AscendingSort();

    /// <summary> 10 → 9 → 8 → 7 → …… </summary>
    void DescendingSort();

    void PrintList();
}