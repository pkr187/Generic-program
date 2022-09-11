namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArr = { 'a', 'b' };
            printIntArr(intArr);
            printDoubleArr(doubleArr);
            printCharArr(charArr);
        }
        static void printIntArr(int[] Arr)
        {
            foreach (var data in Arr )
            {
                Console.WriteLine(data);
            }
        }
        static void printDoubleArr(double[] arr )
        {
            foreach (var data in arr )
            {
                Console.WriteLine(data);
            }
        }
        static void printCharArr(char[] arr )
        {
            foreach (var datat in arr )
            {
                Console .WriteLine (datat);
            }
        }
            
    }
}