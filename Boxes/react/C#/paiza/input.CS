// 標準入力で値を取得する
// 複数行の取得（3 \n イヌ\nサル\nトリ)
using System;
public class Program
{
    public static void Main()
    {
        var num = 0;
        num = int.Parse(Console.ReadLine());

        var data = "";
        // data = Console.ReadLine();
        for (var i = 0; i < num; i++)
        {
            data = Console.ReadLine();
            Console.WriteLine(data);
        }
    }
}