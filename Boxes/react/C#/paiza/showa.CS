// 西暦年から昭和年を求める
// 実行するたびに1926年から1988年までの西暦年をランダムに選んで表示します。
// ここにコードを追加して、昭和年を計算し「西暦W年は昭和S年です」と表示してください。

// なお、昭和年は、「seireki - 1925」で求めることができます。

// プログラムを実行して、正しく出力されれば演習課題クリアです！
using System;
public class Program
{
    public static void Main()
    {
        var random = new Random();
        var seireki = random.Next(0, 63) + 1926;
        Console.Write("西暦" + seireki + "年は");

        // 昭和年を計算
        var showa = 0;
        showa = seireki - 1925;
        Console.WriteLine("昭和" + showa + "年です");
    }
}
