public class Resume
{
   public string _Name ;
   public string _Prenoms; 
   public List<Job> _Jobs= new   List<Job>();
   public void Display()
   {
     Console.WriteLine($"name: {_Name} {_Prenoms}");
     Console.WriteLine("Jobs:");
      foreach (Job job in _Jobs)
      {
         job.Display();
      }
     
   }
}
