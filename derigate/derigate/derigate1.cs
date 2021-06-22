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
        Action a = M;
        a();
        Func<int, int, int> op = Add;
        Console.WriteLine($"op(3, 5)={op(3, 5)}");
    }
    public static void M() => Console.WriteLine("M");
    public static int Add(int a, int b) => a + b;
}