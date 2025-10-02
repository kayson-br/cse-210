using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"\nCompany: {_company}\nJob Title: {_jobTitle}\nDuration: {_startYear} - {_endYear}");
    }
}