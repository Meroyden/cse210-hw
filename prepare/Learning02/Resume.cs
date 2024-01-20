public class Resume
{
    public string _firstName;
    public string _lastName;
    private List<Job> _jobs = new();
    public Resume(){}
   public void AddJob(Job jobjob)
   {
        _jobs.Add(jobjob);
   }

}