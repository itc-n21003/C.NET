using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int array = new int[3];

        // 配列の要素ごとに値を代入
        array[0] = 5;
        array[1] = 10;

        // 初期データを指定 
        int array2 = new int[] { 0, 5, 10 };
        string[] cats = { "黒猫", "三毛猫", "ぶち", "はちわれ" };

        // ジャグ配列での初期化
        int[][] jagged = new int[][]
        {
    new[] {1, 2, 3},
    new[] {4, 5, 6, 7}
        };

        // 四角配列での初期化
        int[,] grid = new int[,]
        {
    {1, 1, 1},
    {2, 2, 2},
    {3, 3, 3}
        };
    }
}