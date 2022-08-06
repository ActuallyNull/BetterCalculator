using System;
using System.IO;

String add = "Addition -- +";
String minus = "Substraction -- -";
String multi = "Multiplication -- x";
String div = "Division -- /";
String mod = "Modulo -- %";
String areatxt = "Area";
String choice;

static void ClearCurrentConsoleLine()
{
    int currentLineCursor = Console.CursorTop;
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, currentLineCursor);
}
void areacalc() 
{
    Console.WriteLine("Enter radius");
    double radius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter mesurement (ex. cm, dm, m, km)");
    String mesurment = Console.ReadLine();
    double area = Math.PI * (radius * radius);
    Console.WriteLine("The area of your circle is " + area + mesurment);
}
void Addition()
{
    Console.Clear();
    Console.WriteLine("Input your first term");
    double term1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input your second term");
    double term2 = Convert.ToDouble(Console.ReadLine());
    double sum = (term1 + term2) + 0.000000000000001;
    Console.WriteLine("Calculating.");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating..");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating...");
    Thread.Sleep(1000);
    Console.WriteLine("The sum to " + term1 + " + " + term2 + " = " + sum);
}
void Substraction()
{
    Console.Clear();
    Console.WriteLine("Input your first term");
    double term1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input your second term");
    double term2 = Convert.ToDouble(Console.ReadLine());
    double sum = (term1 - term2) + 0.000000000000001;
    Console.WriteLine("Calculating.");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating..");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating...");
    Thread.Sleep(1000);
    Console.WriteLine("The sum to " + term1 + " - " + term2 + " = " + sum);
}

void Multiplication()
{
    Console.Clear();
    Console.WriteLine("Input your first term");
    double term1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input your second term");
    double term2 = Convert.ToDouble(Console.ReadLine());
    double sum = (term1 * term2) + 0.000000000000001;
    Console.WriteLine("Calculating.");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating..");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating...");
    Thread.Sleep(1000);
    Console.WriteLine("The sum to " + term1 + " * " + term2 + " = " + sum);
}

void Division()
{
    Console.Clear();
    Console.WriteLine("Input your first term");
    double term1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input your second term");
    double term2 = Convert.ToDouble(Console.ReadLine());
    double sum = (term1 / term2) + 0.000000000000001;
    Console.WriteLine("Calculating.");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating..");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating...");
    Thread.Sleep(1000);
    Console.WriteLine("The sum to " + term1 + " / " + term2 + " = " + sum);
}
void Modulo()
{
    Console.Clear();
    Console.WriteLine("Input your first term");
    double term1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input your second term");
    double term2 = Convert.ToDouble(Console.ReadLine());
    double sum = (term1 % term2);
    Console.WriteLine("Calculating.");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating..");
    Thread.Sleep(1000);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    ClearCurrentConsoleLine();
    Console.WriteLine("Calculating...");
    Thread.Sleep(1000);
    if (sum == 0)
    {
        Console.WriteLine("There is no reminder for this equation (0)");
    }
    else 
    {
        Console.WriteLine("The Modulo of " + term1 + " and " + term2 + " is " + sum);
    }
}

void perimiterOfparrallelogram() 
{
    

}

Console.WriteLine("###############################");
Console.WriteLine("Calculator");
Console.WriteLine("###############################");
Console.WriteLine("\n\n\n\n");
Console.WriteLine("Type " + add + " for additions");
Console.WriteLine("Type " + minus + " for substractions");
Console.WriteLine("Type " + multi + " for multiplications");
Console.WriteLine("Type " + div + " for divisions");
Console.WriteLine("Type " + mod + " for modulos");
Console.WriteLine("Type " + areatxt + " for finding the area of a circle");
choice = Console.ReadLine();

    switch (choice)
    {
        case "Addition":
        Addition();
            break;
        case "addition":
        Addition();
            break;
        case "Substraction":
        Substraction();
            break;
        case "substraction":
        Substraction();
            break;
        case "Multiplication":
        Multiplication();
            break;
        case "multiplication":
        Multiplication();
            break;
        case "Division":
        Division();
            break;
        case "division":
        Division();
            break;
        case "Modulo":
        Modulo();
            break;
        case "modulo":
        Modulo();
            break;
        case "area":
        areacalc();
            break;
        case "Area":
        areacalc();
            break;
    default:
            Console.WriteLine("Incorrect Input");
            Thread.Sleep(2000);
            Console.WriteLine("The process will now be terminated");
            Console.Beep();
            Thread.Sleep(2000);
            Console.Clear();
            Environment.Exit(69);
            break;
    }