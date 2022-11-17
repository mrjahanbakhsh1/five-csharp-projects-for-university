using System;
class program 
{
    public static void Main(string[] args) {
        string x = Console.ReadLine();
        double money = Convert.ToDouble(x);

        string y = Console.ReadLine();
        double annualInterest = Convert.ToDouble(y);

        string z = Console.ReadLine();
        double plannedMoney = Convert.ToDouble(z);


        double time = calcutFunction(money, annualInterest, plannedMoney);
        Console.WriteLine("After " + time + " Years");
        Console.WriteLine("----- Created By Mohammad reza jahanbakhsh -----");
    }

    private static double calcutFunction(double money, double annualInterest, double plannedMoney) {
        double iterat = 0;
        while(money <= plannedMoney) {
            iterat++;
            money = money + (money * (annualInterest / 100));
        }

        return iterat;
    }
}