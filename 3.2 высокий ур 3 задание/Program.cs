Console.WriteLine("введите натуральное число:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("числа удовлетворяющие условию:");
for (int i = 1; i <= n; i++)
{
    int square = i * i;
    string number = i.ToString();
    string lastsquare = square.ToString().Substring(square.ToString().Length-number.Length);
    if (number == lastsquare) Console.WriteLine(i);
}