
Console.WriteLine("Введите своё имя");

var name = Console.ReadLine();

Console.WriteLine("Ваше имя в обратном порядке: ");

for (var i = name!.Length; i > 0; i--)
{
    Console.Write(name[i - 1] + " ");
}

Console.ReadKey();

