using MatematikaLibraries;  

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MatematikaLibraries.Calculate.FPB(60, 45));
            Console.WriteLine(MatematikaLibraries.Calculate.KPK(12, 8));
            Console.WriteLine(MatematikaLibraries.Calculate.Turunan(new int[] { 1, 4, -12, 9 }));
            Console.WriteLine(MatematikaLibraries.Calculate.Integral(new int[] {4 ,6 ,-12 ,9 }));
        }
    }
}