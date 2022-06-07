int FindSum(int m, int n)
{
    if (m > n) return 0;
    return FindSum(m + 1, n) + m;
}

Console.WriteLine(FindSum(4,8));