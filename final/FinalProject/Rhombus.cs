public class Rhombus : Parallelogram
{
    public Rhombus()
    {
        _sideA = 1;
        _sideB = 1;
        _sideC = 1;
        _sideD = 1;

        _angle = 60;
        _inverseAngle = 180 - _angle;

        _height = CalculateHeight();

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = "blank";
    }
    public Rhombus(double sides, double angle, string color)
    {
        _sideA = sides;
        _sideB = sides;
        _sideC = sides;
        _sideD = sides;

        _angle = angle;
        _inverseAngle = 180 - _angle;

        _height = CalculateHeight();

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = color;
    }
    public Rhombus(string color, double sides, double height)
    {
        _sideA = sides;
        _sideB = sides;
        _sideC = sides;
        _sideD = sides;

        _angle = CalculateAngle();
        _inverseAngle = 180 - _angle;

        _height = height;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = color;
    }

    public double CalculateAngle()
    {
        double aRad = Math.Asin(_height / _sideA);
        double angle = aRad * 180 / Math.PI;
        return angle;
    }
    public override string DisplayInfo()
    {
        return $"Rhombus: A:{_area:F2}, P:{_perimeter:F2}, B:{_sideA:F2}, H:{_height:F2}, C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"Rhombus|{_color},{_sideA},{_height}";
    }
}