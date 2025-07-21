using System; // говорят по хорошему лучше его юзать, но с C#9 необязателен
//using static System.Console; //доступно только с C# 10 (.NET 6 (core))
//using System.Console; - так не работает

class Lmao // класс пишем с большой буквы
{
    static void lulz(string i)
    {
        Console.Write("какой ты RYTP хочеш? ");
        string j = Console.ReadLine();
        Console.WriteLine(j + i);

        // только с C# 10 (.NET 6 (core))
        /*
        Write("какой ты RYTP хочеш? ");
        string j = Console.ReadLine();
        WriteLine(j + i);
        */
        
        // только c C#9 (.NET 5 (core))
        /*
        System.Console.Write("какой ты RYTP хочеш? ");
        string j = System.Console.ReadLine();
        System.Console.WriteLine(j+i);
        */
    }
    static void Main()
    {
        lulz(" RYTP");
    }
}
