using System;
// C# 1.0 のころは Generic がなかったので
// メソッドのパラメータや戻り値の型ごとに
// 新しいデリゲート型の宣言が必要だった
// delegate int Op(int a, int b);
// C# 2.0 で Generic が入り型をパラメータができるようになった。
// delegate T Op<T>(T a, T b);
// ということは、パラメータ数と戻り値ごとに
// Generic 化されたデリゲートがひとつあれば十分
// そこで .NET が標準でデリゲート型を提供している
// 戻り値がないデリゲート: Action
// 戻り値があるデリゲート: Func<TResut>
class Program
{
    public static void Main()
    {
        //複合デリゲート
        //デリゲートは複数のデリゲートを+=統合できる
        //もちろん文法上はデリゲート配列もOK
        //Action[]actions=new Action[3]{M1,M2,M3};

        // Action[] actions = new Action[3] { M1, M2, M3 };
        // しかし、一般的にデリゲートの配列は使わない
        // 代わりに複合デリゲートを使う
        // デリゲートは複数のデリゲートを += 結合できる
        Action action = M1;
        action += M2;
        action += M3;
        action(); // M1, M2, M3
        // 追加したデリゲートは -= で解除できる
        action -= M2;
        action(); // M1, M3

    }
     public static void M1() => Console.WriteLine("M1");
    public static void M2() => Console.WriteLine("M2");
    public static void M3() => Console.WriteLine("M3");
   
}