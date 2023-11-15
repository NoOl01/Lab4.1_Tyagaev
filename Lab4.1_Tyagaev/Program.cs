Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
Random rnd = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(0, 2);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

double sum = 0;
for (int i = 0; i < mas.Length; i++)
{
    sum += mas[i] * Math.Pow(2, mas.Length - i - 1);
}
int decimalSum = Convert.ToInt32(sum);
int octal = 0;
int counter = 0;
while (decimalSum != 0)
{
    int remainder = decimalSum % 8;
    decimalSum /= 8;
    octal += remainder * (int)Math.Pow(10, counter);
    counter++;
}

Console.WriteLine($"Полученное восьмеричное число: {octal}");
