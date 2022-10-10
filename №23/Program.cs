Console.WriteLine("Введите число");
double Number;
if (double.TryParse(Console.ReadLine(), out Number))
{
    Print(Number);
    static void Print(double Number)
    {  Console.Write($"{Number} ==> ");
       for(double i=1; i<Number; i++)
        {
          Console.Write($"{double.Pow(i,3)}, ");
        }
        Console.Write($"{double.Pow(Number,3)}. ");
    }
}
else
{
    Console.WriteLine("Ошибка ввода!");
}