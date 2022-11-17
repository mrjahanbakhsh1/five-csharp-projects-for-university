using System; // created by Mohammad reza jahanbakhsh
class program
{
    public static void Main(string[] args)
    {
        // get all day of life from user
        Console.WriteLine("Your Days Of Life : ");
        string num = Console.ReadLine();
        double x = Convert.ToDouble(num);

        // years
        double realYear = x / 365; // convert day of life to year
        double year = Math.Round(realYear, 2); // show just two decimal places for my number
        double yearForMounth = year % 1; // get decimal place (after dot)

        // Mounths
        double realMounth = yearForMounth * 12;
        double mounth = Math.Round(realMounth, 2);
        double mounthForWeek = mounth % 1;

        // weeks
        double realWeek = mounthForWeek * 4.3;
        double week = Math.Round(realWeek, 2);
        double weekForDay = week % 1;

        // days
        double realDay = weekForDay * 7;

        // print 
        Console.WriteLine("------Print------");
        Console.WriteLine(Math.Floor(year) + " Year" );
        Console.WriteLine(Math.Floor(mounth) + " Mounth");
        Console.WriteLine(Math.Floor(week) + " Week") ;
        Console.WriteLine(Math.Floor(realDay) + " Day");
        Console.WriteLine("----- Created By Mohammad reza jahanbakhsh -----");
    }
}