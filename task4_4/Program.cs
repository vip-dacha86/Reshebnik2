void FillArrey(int[]collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 20);
        //index = index=1;
        index++;
    }
}
void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int []array = new int [20];
FillArrey(array);
PrintArray(array);