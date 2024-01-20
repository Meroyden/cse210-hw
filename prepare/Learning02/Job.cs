public class Job
{
    // ATTRIBUTES (Class Variables) (Fields) (Class State)
        // Declaring a basic data type variable:
        // [Access Type] [Data Type] [Name] ? = [Initalize value]
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    private double _salary;

        // Declaring a class type variable (objects)
        // [Access Type] [Class Type] [Object Name] = new [Constructor([Arguments])]

    private Random rng = new Random();
    private List<int> _sampleList = new List<int>();

    //private Dictionary<string, int> _sampleDict = new Dictionary<string, int>();

    // CONSTRUCTOR (Creates the class. Can initialize any variable and perform any logic necessary to set up the class.)
    // [Access Type] [Name *Same as class*]([Parameters])
    public Job(string jobcompany, string jobjobTitle, int jobstartYear, int jobendYear, double jobsalary)
    {
        _company = jobcompany;
        _jobTitle = jobjobTitle;
        _startYear = jobstartYear;     
        _endYear = jobendYear;
        _salary = jobsalary;
    }

    // METHODS (Class Functions) (Behaviours)
    // [Access Type] [Return Type] [Name]([Paramters])
    public double GetSalary()
    {
        return _salary;
    }

    public void SetSalary(double newSalary)
    {
        _salary = newSalary;
    }

    public double CalculateBonus()
    {
        double bonus = 10000;
        _salary += bonus;        // _salary = _salary + bonus
        return _salary;
    }
}

