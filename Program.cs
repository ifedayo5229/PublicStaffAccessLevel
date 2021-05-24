using System;

namespace Accessmodifires
{
    class Program
    {
        static void Main(string[] args)
        {
            StaffDetails staff = new StaffDetails();
             staff.Name = "IFEDAYO ADE";
            staff.Location = "Canada";
            staff.Age = 32;
            staff.GetStaffDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
            // Console.WriteLine("Hello World!");
        }
    }
     public class StaffDetails
    {
       public string Name;
       public string Location;
       public int Age;
       public void GetStaffDetails()
       {
           Console.WriteLine("Name: " + Name);
           Console.WriteLine("Location: " + Location);
           Console.WriteLine("Age: " + Age);
        }
    }

}
