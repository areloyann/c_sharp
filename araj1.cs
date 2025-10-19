using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = null;
        
        try
        {
            reader = new StreamReader("example.txt");
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        finally
        {
            if (reader != null)
            {
                reader.Close();
                Console.WriteLine("Reader closed.");
            }
        }
    }
}
