using System;
class program
{
    public static void Main(string[] args)
    {
        string x = Console.ReadLine();
        int num1 = Convert.ToInt32(x);

        string y = Console.ReadLine();
        int num2 = Convert.ToInt32(y);

        // Calcuting GCD of two number
        int bmm = bmmFunction(num1, num2);
        Console.WriteLine("B.M.M is : " + bmm);

        // Calcuting LCM of two number
        int kmm = kmmFunction(num1, num2, bmm);
        Console.WriteLine("K.M.M is : " + kmm);

        Console.WriteLine("----- Created By Mohammad reza jahanbakhsh -----");
    }

    // GCD function 
    private static int bmmFunction(int num1, int num2) {
        // creating array with flexible(dynamically) size
        List<int> num1Array = new List<int>();
        List<int> num2Array = new List<int>();
        List<int> commonArray = new List<int>();

        for (int i = 1; i <= num1; i++) {
            if (num1 % i == 0) {
                num1Array.Add(i);
            }
        }

        for (int i = 1; i <= num2; i++) {
            if (num2 % i == 0) {
                num2Array.Add(i);
            }
        }

        // put common numbers to commonArray
        for (int i = 0; i < num1Array.Count; i++) {
            for (int j = 0; j < num2Array.Count; j++) {
                if (num1Array[i] == num2Array[j]) {
                    commonArray.Add(num1Array[i]);
                }
            }
        }

        // get GCD
        int bmm = 0;
        for (int i = 0; i < commonArray.Count; i++) {
            if(bmm < commonArray[i]) {
                bmm = commonArray[i];
            }
        }

        return bmm;
    }

    // LCM function
    private static int kmmFunction(int num1, int num2, int bmm) {
        
        // if user give zero
        if(bmm != 0) {
            int kmm = (num1 * num2) / bmm;
            return kmm;
        } else {
            return 0;
        }
    }

}
// Created By Mohammad reza jahanbakhsh