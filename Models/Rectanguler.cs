namespace oop1.Models.Accountant.Developer.Employee.Shape.Square.Rectanguler;
 using oop1.Models.Accountant.Developer.Employee.Shape;

    public class Rectanguler:Shape
    {
        public Rectanguler (int heigt,int width)
        {
            Heigt =heigt;
            Width = width;

        }
        public override int GetArea()
        {
            return Width*Heigt;
        }
    }
