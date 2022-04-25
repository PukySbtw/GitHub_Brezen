string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

int cislo1 = Convert.ToInt32(input1); 
int cislo2 = Convert.ToInt32(input2);

if (cislo1 > cislo2)
{
    Console.WriteLine($"{cislo1}, {cislo2}");
}
else if (cislo1 < cislo2)
{
    Console.WriteLine($"{cislo2}, {cislo1}");
}