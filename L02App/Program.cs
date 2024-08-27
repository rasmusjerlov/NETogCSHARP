

    using System.Reflection.Emit;

    // Fibonacci();
    // Fibonacci_Recur(0, 1, 8);
    var birthday = new DateTime(2000, 02, 22);
    calculateAge(birthday, out int alder);
    Console.WriteLine(alder);
    
    
    static void Fibonacci()
    {
        Console.WriteLine("Enter a number larger than 0. \n0 to exit program!");

        string input = Console.ReadLine();

        int num = int.Parse(input);
        int a = 0;
        int b = 1;
        for (int i = 0; i < num; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
            Console.WriteLine(a);
        }
    }

    
    static void Fibonacci_Recur(int a, int b, int n)
    {
        if (n == 0)
        {
            return;
        }

        Console.WriteLine(a);
        Fibonacci_Recur(b, a + b, n - 1);
    }

    static void calculateAge(DateTime birthdateInput, out int alder)
    {
        var today = DateTime.Today;
        var age = today.Year - birthdateInput.Year;
        alder = age;
        if (DateTime.Now < birthdateInput.AddYears(age))
        {
            age--;
        }
    }
