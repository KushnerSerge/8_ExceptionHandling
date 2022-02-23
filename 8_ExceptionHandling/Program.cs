// See https://aka.ms/new-console-template for more information
using _8_ExceptionHandling;
using System.Diagnostics;

Console.WriteLine("Hello, World!");



ExperimentExceptions obj = new ExperimentExceptions();
int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7, 7, 8, 9 };
//obj.arrayOperations(arr, 0);

//ExperimentExceptions.readAndwriteFromFile();

// Bank Account Practice

BankAccount user = new BankAccount("Corina", "parola", 12000);
//user.Login("parola");

// Try-Catch-Example
try
{
    for (int i = 1; i <= 3; i++)
    {
        user.Login("parola1");
    }
}
catch (AccountLoginException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Message was sent to technical department");
}


// ----------------- INNER EXCEPTION EXAMPLE ------------------------
Console.WriteLine(" ----------------- INNER EXCEPTION EXAMPLE ------------------------");
Console.WriteLine("------------------ throw ---------------------------------------");
// Good Practice

try
{
    try
    {
        for (int i = 1; i <= 3; i++)
        {
            user.Login("parola1");
            if (user.logedIn == true) break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Loggin excpetion: {ex.Message}");
        throw;
    }
    user.WithDraw(14000);
}
catch (Exception ex)
{
    Console.WriteLine("External exception : " + ex.GetType().Name);
    Console.WriteLine("Inner exception : " + ex.InnerException?.GetType().Name);
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Operation closed");
}

Console.WriteLine("------------------ throw ex ---------------------------------------");
// bad example, anti pattern, deoarece se pierde StakeTrace -ul

try
{
    try
    {
        for (int i = 1; i <= 3; i++)
        {
            user.Login("parola1");
            if (user.logedIn == true) break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Loggin excpetion: {ex.Message}");
        throw ex;
    }
    user.WithDraw(14000);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Operation closed");
}

Console.WriteLine("------------------ throw new Exception(outer exception) ---------------------------------------");
// Good Practice

try
{
    try
    {
        for (int i = 1; i <= 3; i++)
        {
            user.Login("parola1");
            if (user.logedIn == true) break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Loggin excpetion: {ex.Message}");
        throw new Exception("User cannot log in", ex);
    }
    user.WithDraw(14000);
}
catch (Exception ex) when(ex.Message.Contains("User") || ex is NotEnoughMoneyException)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Operation closed");
}
