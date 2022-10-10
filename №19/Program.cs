Console.WriteLine("Введите пятизначное число");
int Number = int.Parse(Console.ReadLine() ?? ""); 
if (Number >= 10000)
{
 int num4_1;
 int num2_1; 
 int num3_1; 
 int num5_1;
 int result1; 
 int result2; 
 int result3; 
 int result4;  
 result1 = Number / 10000;
 num2_1  = Number % 10000;
 result2 = num2_1 / 1000;
 num3_1 = num2_1 % 1000;
 result3 = num3_1 / 100;
 num4_1 = num3_1 % 100;
 result4 = num4_1 / 10;
 num5_1 = num4_1 % 10;
  if (result1 == num5_1)
 {
    if (result2 == result4)
     {
        Console.WriteLine("Число является палиндромом.");
     }
    else
     {
        Console.WriteLine("Число НЕ является палиндромом.");
     }
 }
 else
    {
        Console.WriteLine("Число НЕ является палиндромом.");
    }
        
        
}
else
{
 Console.WriteLine("Число НЕ является пятизначным.");
}