using System;

namespace homework6
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      var director = new Director(true, null);
      var chief = new Chief(false, director);
      var employee = new Employee(false, chief);
      
      employee.CreateStatement(100);
      employee.SignIn(employee.Statement);
      
      Console.WriteLine(employee.Statement.ToString());
    }
  }
}