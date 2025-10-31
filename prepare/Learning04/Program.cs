using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Kayson", "Math");
        //Console.WriteLine(assignment.GetSummary());

        MathAssignment math = new MathAssignment("Kayson", "Math", "Section 7.3", "Problems 8-19");
        //Console.WriteLine(math.GetHomeworkList());

        WritingAssignment english = new WritingAssignment("Kayson", "English", "World War 2 in context");
        Console.WriteLine(english.GetWritingInformation());
    }
}