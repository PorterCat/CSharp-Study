
internal class Program
{
    private unsafe static void Main(string[] args)
    {
        int[] y = new int[3] { 1, 2, 3 }; // определяем переменную

        
        fixed (int* x = &y[0])
        {
            ulong addr = (ulong)x;
            Console.WriteLine(addr);
        }

        fixed (int* x = &y[1])
        {
            ulong addr = (ulong)x;
            Console.WriteLine(addr);
        }

        fixed (int* x = &y[2])
        {
            ulong addr = (ulong)x;
            Console.WriteLine(addr);
        }

    }
}