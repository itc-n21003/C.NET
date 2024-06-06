using System;
public class Hello{
    public static void Main(){
        var data = Console.ReadLine();
        string[] team = data.Split(',');
        
        data = Console.ReadLine();
        string[] enemies = data.Split(',');
        
        foreach (var str in enemies) {
            Console.WriteLine(str + "が現れた！");
        }
        
        var num = enemies.Length;
        Console.WriteLine("敵は" + num + "匹");
        
        var random = new Random();
        var rand = 0;
        var attack = "";
        
        foreach(var str in team) {
            rand = random.Next(num);
            attack = enemies[rand];
            Console.WriteLine(str + "の攻撃！");
            Console.WriteLine(attack + "に会心の一撃！");
        }
    }
}

