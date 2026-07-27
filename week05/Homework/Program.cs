using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Jack Smith", "School");

        Console.WriteLine (assignment.GetSummary());
        Console.WriteLine("");

        MathAssignment maths = new MathAssignment("John Doe", "Maths Test", "7.1", "1-5");
        
        Console.WriteLine (maths.GetSummary());
        Console.WriteLine (maths.GetHomeworkList());
        Console.WriteLine ("");

        WritingAssignment writing = new WritingAssignment("Johnny Jon Jon", "History", "A History Book");

        Console.WriteLine (writing.GetSummary());
        Console.WriteLine (writing.GetWritingInformation());

    }
}