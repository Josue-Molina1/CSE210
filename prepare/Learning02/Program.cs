public class Job (
    public string _company;
    public string _jobTitle
    public int _startYear;
    public int _endYear;
//constructor


    public Job()
    {

    }

    public void Display()// method
    {
        Console.WriteLine($"{_jobTitle}({_companyName}) {_startYear}-{_endYear}");
    }
)