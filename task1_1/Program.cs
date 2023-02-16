int Max(int agr1,int agr2,int agr3)
{
    int result = agr1;
    if (agr2>result) result = agr2;
    if(agr3>result) result = agr3;
    return result;
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 83;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 36;
int max1 = Max (a1,b1,c1);
int max2 = Max (a2,b2,c3);
int max3 = Max (a3,b3,c3);
int max = Max (max1,max2,max3);
Console.WriteLine( max );