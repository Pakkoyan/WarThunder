
using MyClassLib.WorldOfTanks;

Console.WriteLine("Hello, World!");

Tank[] battle = new Tank[5];
for (int i = 0; i < 5; i++)
{
    Tank n = new Pantera();
    Tank c = new T34();
    if (n * c)
    {
        Console.WriteLine(n.GetType() + " победил");
    }
    else
    {
        Console.WriteLine(c.GetType() + " победил");
    }
}