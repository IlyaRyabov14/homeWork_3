// Формула для расстояния между двумя точками в 3-х измерениях, т.е. (x1, y1, z1) и (x2, y2, z2) была получена из теоремы Пифагора, которая такова:
//Расстояние = √ (x2-x1)^2+ (y2-y1)^2+ (z2-z1)^2

float x1 = 7;
float y1 = -5;
float z1 = 0;
float x2 = 1;
float y2 = -1;
float z2 = 9;

double Result;
Result = double.Pow(double.Pow((x2-x1), 2)+ double.Pow((y2-y1), 2)+ double.Pow((z2-z1), 2), 0.5);  

Console.WriteLine($"Растояние между точками будет составлять {Result}");




