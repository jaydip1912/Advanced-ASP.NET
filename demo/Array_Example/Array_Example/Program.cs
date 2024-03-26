class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5};
        int i= 0;
        int j= array.Length;

        while (i < array.Length)
        {
            Console.WriteLine(array[i]);
            i++;
        }
    }
}
