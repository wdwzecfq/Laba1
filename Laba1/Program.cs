Console.Write("Длина окружности = ");

double C = Convert.ToDouble(Console.ReadLine());
double PI = Math.PI;
double r = C / (2 * PI);
double S = PI * Math.Pow(r, 2);

Console.WriteLine($"Площадь круга = {S}.");