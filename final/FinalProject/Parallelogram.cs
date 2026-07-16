public class Parallelogram : Trapezoid
{
    protected double _angle;
    protected double _inverseAngle;

    public Parallelogram()
    {
        _sideA = 2; //base
        _sideB = 1; //left
        _sideC = 2; //top
        _sideD = 1; //right

        _angle = 60;
        _inverseAngle = 180 - _angle;

        _height = CalculateHeight();

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = "blank";  
    }
    public Parallelogram(double horizontal, double vertical, double angle, string color)
    {
        _sideA = horizontal; //base
        _sideB = vertical; //left
        _sideC = horizontal; //top
        _sideD = vertical; //right

        _angle = angle;
        _inverseAngle = 180 - _angle;

        _height = CalculateHeight();

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = color;
    }
    public Parallelogram(double horizontal, double height, string color)
    {
        _sideA = horizontal; //base
        _sideC = horizontal; //top

        _height = height;

        _angle = 60;
        _inverseAngle = 180 - _angle;

        _sideB = CalculateSides(); //left
        _sideD = CalculateSides(); //right

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = color;
        
    }
    public override double CalculateSides()
    {
        double a = Math.Min(_angle, _inverseAngle);
        // s = h/sin(angle)
        double aRad = a *Math.PI / 180;
        double sides = _height/ Math.Sin(aRad);
        return sides;
    }
    public override double CalculateHeight()
    {
        double aRad = _angle * Math.PI /180;
        double height = _sideB * Math.Sin(aRad);
        return height;
    }

    public override string DisplayInfo()
    {
        return $"Parallelogram: A:{_area:F2}, P:{_perimeter:F2}, B:{_sideA:F2}, H:{_height:F2}, C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"Parallelogram|{_sideA},{_sideB},{_angle},{_color}";
    }
}