using System;
public class Job
{
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public override string ToString()
    {
        return $"{JobTitle} ({Company}) {StartYear}-{EndYear}";
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }
}