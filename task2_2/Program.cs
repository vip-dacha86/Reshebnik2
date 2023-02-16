// Максимальное число из 9 чисел
int Max (int agr1, int agr2, int agr3)
{
    int result = agr1;
    if (agr2 > result) result = agr2;
    if (agr3 > result) result = agr3;
    return result;
}              //0  1  2  3  4  5  6  7  8
int [] array = {11,201,31,41,15,61,107,18,19};
int result = Max (
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
    );
Console.WriteLine(result);