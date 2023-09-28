Console.Clear();
int[] array = { 12, 23, 32, 67, 44, 55, 67, 8 };
             // 0   1   2   3   4   5   6   7
int n = array.Length;
int find = 67;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}