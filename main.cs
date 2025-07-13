using System; // говорят по хорошему лучше его юзать, но с C#9 необязателен
class Lmao // класс пишем с большой буквы
{
    static void lulz(string i="")
    {
        Console.Write("какой ты RYTP хочеш? ");
        string j = Console.ReadLine();
        Console.WriteLine(j + i);

        //// только c C#9 (.NET 5)
        //System.Console.Write("какой ты RYTP хочеш? ");
        //string j = System.Console.ReadLine();
        //System.Console.WriteLine(j+i);
    }
    static void Main(string[] args)
    {
        lulz(" RYTP");
    }
}
