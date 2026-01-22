

public class Job
{
    public string _jobTitle;
    public string _company; 
    public int _startYear; 
    public int _endYear;
    public Job()
    { 
       _jobTitle = ""; 
       _company = ""; 
       _startYear = 0;
       _endYear = 0;
    }
    public void DisplayJob() { Console.WriteLine($"{_jobTitle} at {_company} ({_startYear} - {_endYear})"); }
}