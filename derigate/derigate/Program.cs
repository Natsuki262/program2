using System;
delegate void D();
//デリゲート
//デリゲートは型なので型の宣言が必要
//デリゲート型はメソッドのパラメータや戻り値を表す
//パラメータを受け取らず戻血がないデリゲートの宣言


    class Program
    {
       public static void Main(string[] args)
        {
            //デリゲート型の変数を作ることができる
           // D d;//デリゲート型の　d変数を用意

            //デリゲート型の変数の中身はメソッドを指すオブジェクト
            //d=new D(M);
        //デリゲートは一般的な変数同様に Varで型推論可能

        //Var d=new D(M);

        //デリゲート型が明示的ならnewは省略可能
        D d = M;//こっちの方が一般的

        // var 型推論と new 省略の両方はできない
        // var d = M; // エラー 型が不明

        //デリゲートからメソッドを呼び出す
        d();
            //デリゲートは一般的な変数と同様に Varで型
            
        }
    public static void M()
    {
        Console.WriteLine("M() メソッド");
    }
}

