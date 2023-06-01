using Microsoft.AspNetCore.Mvc;
using oop1.Models;
using oop1.Models.Accountant.Developer.Employee;
using oop1.Models.Accountant.Developer.Employee.Shape;
using oop1.Models.Accountant.Developer.Employee.Shape.Square;
using oop1.Models.Accountant.Developer.Employee.Shape.Square.Rectanguler;
namespace oop1.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
     private static readonly List<Employee> EmployeeDatabase = new List<Employee>();

    public double salary { get; private set; }

    [HttpGet()]
     public List<int> GetEmployee(int id)
     {
        Employee employee =new Employee();
        employee.Id =id;
        employee.Name ="EMPLOYEE";
        employee.GetName();
        
        EmployeeDatabase.Add(employee);
        return employee.id ;
        Employee d =new Developer();
        d.Id=id;
        d.Name ="Developer Employee";
        d.Salary=salary ;
        d.Position="It";
        Employee accountant = new Accountent();
        accountant.GetName("1", 1);
        EmployeeDatabase.Add(accountant);
        accountant.commition=1000;
         List<Shape> shapes =new List<Shape>();
         Square square = new Square(5);
         shapes.Add(square);
         Rectanguler rectanguler = new Rectanguler(10,2);
         shapes.Add(rectanguler);
         List<int> shapeResults = new List<int>();

        foreach (Shape shape in shapes)
        {
            shapeResults.Add(shape.GetArea());
        }

        return shapeResults;
     }

}
     
