namespace AgeCalculator;
class Program
{

    static void Main(string[] args)
    {   
    TimesTables();
    Console.ReadKey(true);
    }

    static void TimesTables()
    {
        /*
        VARIABLES
            num, i, result
        BEGIN
            INPUT "Enter the number: ", num
            FOR i = 0 to 10
                result := num * i
                OUTPUT num, "*", i, "=", result
            END FOR
        END
        */
        int number, result;
        Console.WriteLine("Enter the number");
        number = Convert.ToInt32( Console.ReadLine() );

        for(int i = 0; i <= 10; i++)
        {
            result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }

    }

    static void AgeCalculator()
    {    
        string name;
        int yearOfBirth;
        string birthdayThisYear;
        int age;
        int currentYear;

        Console.WriteLine("What is your name?");
        name = Console.ReadLine();

        Console.WriteLine("What is your year of birth?");
        yearOfBirth = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine("Have you had a birthday this year");
        birthdayThisYear = Console.ReadLine().ToLower();
        currentYear = DateTime.Now.Year;
        
        if(birthdayThisYear == "yes" || birthdayThisYear == "y")
        {
            age = currentYear - yearOfBirth;
        }
        else
        {
            age = currentYear - yearOfBirth - 1;
        }
            Console.WriteLine($"You are {age} years old");

        if(age < 18)
        {
            Console.WriteLine($"You are a junior, {name}");
        }
        else if(age >= 18 && age < 30)
        {
            Console.WriteLine($"You are a young adult, {name}");
        }
        else if (age >= 30 && age < 60)
        {
            Console.WriteLine($"You are an adult, {name}");
        }
        else
        {
            Console.WriteLine($"You are a senior, {name}");
        }
   }
}
