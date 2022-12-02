int[] array = { 1, 2, 3, 4, 6, 7, 86, 56, 5, 467, 3, 36578 };

int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine("искомое число находится в массиве под индексом " + index);
        break;
    }
    index++;
    
}