class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the firs number");
        double num1=double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Operator(+,-,*,/)");
        char op=char.Parse(Console.ReadLine());

        Console.WriteLine("Enter the firs number");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0;
        switch (op) 
        {
            case '+':
            result = num1+num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                result = num1 / num2;
                break;

                default: 
                Console.WriteLine("Invalid operator");
                return;
        }
        Console.WriteLine($"Result: {result}");
    }
}
