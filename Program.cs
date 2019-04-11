using System;
using System.Collections.Generic;

namespace classes {
public class Company
{

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<employee> employees = new List<employee>();
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created
    
        The constructor will set the value of the public properties
    */
    public Company (string name, DateTime startDate ){

    }

}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of a company. Name it whatever you like.
        Company BigBossIndustry = new Company("Big Boss Industry", DateTime.Now);
        // Create three employees
        employee HulkHogan = new employee(){
            firtsName = "Hulk",
            lastName = "Hogan",
            title = "The Hulkster",
            startDate = DateTime.Now,
        };

        employee BarryBenson = new employee(){
            firtsName = "Barry",
            lastName = "Benson",
            title = "The Bee",
            startDate = DateTime.Now,
        };

        employee DonaldDuck = new employee(){
            firtsName = "Donald",
            lastName = "Duck",
            title = "Lead Project Manager",
            startDate = DateTime.Now,
        };
        // Assign the employees to the company

        BigBossIndustry.employees.Add(HulkHogan);
        BigBossIndustry.employees.Add(BarryBenson);
        BigBossIndustry.employees.Add(DonaldDuck);
        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        foreach(employee employee in BigBossIndustry.employees){
            Console.WriteLine($"{employee.firtsName} {employee.lastName} works for Big Boss Industry as {employee.title} ");
        }
    }
}
}