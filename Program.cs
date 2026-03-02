using System;
class Program
{
    static void Main()
    {
        Array1(new int[] { 1, 2, 3 });
        Sum(new int[] { 1, 2, 3 });
    }
    static void Array1(int[] arr)
    {
        foreach(int a in arr)
            Console.WriteLine(a);
    }
    static void Sum(int[] arr)
    {
        int sum = 0;
        for( int i=0;i<arr.Length;i++)
             sum += arr[i];
        Console.WriteLine("sum is:"+sum);

    }
}
