namespace oop1.Models.Accountant.Developer.Employee.Shape;

    public class Shape
    {
        public int Heigt {get;protected set;}
        public int Width {get;protected set;}
         public virtual int GetArea()
         {
          return Heigt *Heigt;
         }
         
    }
