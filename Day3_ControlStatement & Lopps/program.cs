//Day - 3
//Control Statements

 //if-else

Console.Write("Enter Your Attendance Percentage:");
int attendance = Convert.ToInt32(Console.ReadLine());

if (attendance < 75)
{
    Console.WriteLine("Sorry, Your Not Eligibility Due to low attendance");
}
else
{
    Console.Write("Enter Your Marks:");
    int marks = Convert.ToInt32(Console.ReadLine());
    if (marks < 0 || marks > 100)
    {
        Console.WriteLine("Invalid Marks");
        return;
    }
    if (marks > 90)
    {
        Console.WriteLine("Pass: Grade A");
    }

    else if (marks > 69)
    {
        Console.WriteLine("Pass: Grade B");
    }
    else if (marks > 49)
    {
        Console.WriteLine("Pass: Grade C");
    }
    else
    {
        Console.WriteLine("Fail");
    }
}

//Switch Statement

Console.Write("Enter day Number (1 - 7): ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    case 4:
        Console.WriteLine("Thursday");
        break;

    case 5:
        Console.WriteLine("Friday");
        break;

    case 6:
        Console.WriteLine("Saturday");
        break;

    case 7:
        Console.WriteLine("Sunday");
        break;

    default:
        Console.WriteLine("Invalid day Number");
        break;
}


//LOOPING SATEMENT

 //For Loop
Console.Write("Enter a Number: ");
int num = Convert.ToInt32(Console.ReadLine());

int fact = 1;
for (int i = 1; i <= num; i++)
{
    fact = fact * i;
}
Console.WriteLine($"Factorial = {fact}");


//While Loop

Console.Write("Enter your sum of Number: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (num > 0)
{
    int digit = num % 10;
    sum = sum + digit;
    num = num / 10;
}
Console.WriteLine($"Sum of Digit = {sum}");


// foreach 

int[] numbers = { 12, 7, 9, 20, 15, 6 };
int even = 0, odd = 0;
foreach (int n in numbers)
{
    if (n % 2 == 0)
    {
        even++;
        Console.WriteLine($"{n} is Even");
    }
    else
    {
        odd++;
        Console.WriteLine($"{n} is Odd");
    }
}
