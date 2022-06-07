void FindEven(int m, int n)
{
    if(m > n) return;
    if(m%2 == 0) Console.Write($"{m}, ");
    FindEven(m+1,n);
}

FindEven(4,8);