using System;
class program 
{
    public static void Main(string[] args) {
        string x = Console.ReadLine();
        double a = Convert.ToDouble(x);

        calcutFunction(a);
        Console.WriteLine("----- Created By Mohammad reza jahanbakhsh -----");
    }

    private static void calcutFunction(double a) {
        double pow2 = Math.Pow(a, 2);
        double pow3 = Math.Pow(a, 3);
        Console.WriteLine("Power 2 : " + pow2 + " ,power 3 " + pow3);
    }
}