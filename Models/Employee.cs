using System;
using Microsoft.AspNetCore.Mvc;
using oop1.Models;
using oop1.Models.Accountant.Developer;

using oop1.Models.Accountant;
using oop1.Models.Accountant.Developer.Employee;

namespace oop1.Models.Accountant.Developer.Employee;

    public class Employee
{
    

    public int Id  { get; set; }
    public List<int> id { get; internal set; }
    public  string Name { get; set; }
    public double Salary {get;set;}
    public string Position { get; set; }
    public int commition { get; internal set; }

    public String GetName()
    {
        return Name;
    }
    public string GetName(int id)
     {
     return Name;
     }
     public string GetName(string Name , int id){
        return Name;
     }
}
 