using System;

class Program
{
    static void Main()
    {
        try
        {
            throw new InvalidOperationException("Database connection failed.");
        }
        catch (Exception ex) when (ex.Message.Contains("DB"))
        {
            Console.WriteLine("Caught a DB-related exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Caught an exception: " + ex.Message);
        }
    }
}
