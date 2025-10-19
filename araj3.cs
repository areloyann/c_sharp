using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            try
            {
                string content = File.ReadAllText("nonexistentfile.txt");
            }
            catch (FileNotFoundException ex)
            {
                throw new ApplicationException("An error occurred while loading the file.", ex);
            }
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine("Caught an application exception: " + ex.Message);
            Console.WriteLine("Inner Exception: " + ex.InnerException?.Message);
        }
    }
}
