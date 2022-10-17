Console.WriteLine("Введите слово палиндром");
string a=Console.ReadLine();
int count = 0;
string[] b= a.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < b.Length; i++)
{
    if (b[i] == new string(b[i].Reverse().ToArray()))
    {
        count++;
    }
}
Console.WriteLine($"Количество палиндромов - {count}");




