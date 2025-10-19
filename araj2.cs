using System;

class InvalidGradeException : Exception
{
    public InvalidGradeException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            int grade = -10; 
            if (grade < 0 || grade > 100)
            {
                throw new InvalidGradeException("Grade must be between 0 and 100.");
            }
            Console.WriteLine("Grade is valid: " + grade);
        }
        catch (InvalidGradeException ex)
        {
            Console.WriteLine("Invalid grade: " + ex.Message);
        }
    }
}
