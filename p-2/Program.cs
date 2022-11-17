using System;
class program 
{
    public static void Main(string[] args) {
        string x = Console.ReadLine();
        double a = Convert.ToDouble(x);

        string y = Console.ReadLine();
        double b = Convert.ToDouble(y);

        string z = Console.ReadLine();
        double c = Convert.ToDouble(z);

        double delta = (b*b) - (4*a*c);
        myfunction(a, b, c, delta);
        Console.WriteLine("----- Created By Mohammad reza jahanbakhsh -----");
    }

    private static void myfunction(double a, double b, double c, double delta) {
        if(delta > 0) {
            double x1 = (-b + Math.Sqrt(delta)) / 2*a;
            double x2 = (-b - Math.Sqrt(delta)) / 2*a;
            Console.WriteLine("x1 : " + x1 + " ,x2 : " + x2);
        } else if(delta == 0) {
            double x12 = -b/2*a;
            Console.WriteLine("x12 : " + x12);
        } else {
            Console.WriteLine("Rishe Nadarad !");
        }
    }

}