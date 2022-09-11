using System;

namespace CBS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the amount of values:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] a= new int[N];
            int i, min, max, sum = 0, mid;
            for( i=  0; i<N; i++)
            {
                a[i]=i;
            }
            for (i = 0, min = a[0], max= a[0]; i < N; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
                sum += a[i];
            }
            mid = sum/N;
            Console.WriteLine("Масив:");
            for (i = 0; i < N; i++)
            {
                Console.Write("{0}\t", a[i]);
            }
            Console.WriteLine("min = {0} \nmax = {1}\nsum = {2}\nmid = {3}", min, max, sum, mid);
        }
    }
}
