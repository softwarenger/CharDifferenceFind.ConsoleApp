Console.Write("Char dizisi kaç elemnlanlı olacak: ");
int a = Convert.ToInt32(Console.ReadLine());
int totalA = 0;
int totalB = 0;
char[] chr = new char[a];

for (int i = 0; i < chr.Length; i++)
{
    Console.Write($" {i + 1}.elamanı seçiniz (A / B) :");
    chr[i] = Convert.ToChar(Console.ReadLine());

}

for (int i = 0; i < chr.Length; i++)
{
    if (chr[i] == 'A')
    {
        totalA++;
    }
    if (chr[i] == 'B')
    {
        totalB++;
    }
}

foreach (var item in chr)
{
    Console.Write($"{item}");
}
Console.WriteLine();
Console.Write(Math.Abs(totalA - totalB));