public class Trapezoid : FlatShapes
{
    protected double _sideA; //top length
    protected double _sideB; //right length
    protected double _sideC; //bottom length
    protected double _sideD; //left length
    protected double _height; 
    public Trapezoid()
    {
        _sideA = 3;
        _sideB = 1;
        _sideC = 2;
        _sideD = 1;

        _height = CalculateHeight();

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = "blank";
    }
    public Trapezoid(double sideA, double sideB, double sideC, double sideD, string color)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        _sideD = sideD;

        _height = CalculateHeight();

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = color;
    }
    public Trapezoid(double top, double bottom, double height, string color)
    {
        _height = height;

        _sideA = bottom;
        _sideC = top;
        double sides = CalculateSides();
        _sideB = sides;
        _sideD = sides;


        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = color;
    }
    public override double CalculateArea()
    {
        // ((top+botton)h)/2
        double area = ((_sideA+_sideC)*_height)/2;
        return area;
    }
    public override double CalculatePerimeter()
    {
        double perimeter = _sideA + _sideB + _sideC + _sideD;
        return perimeter;
    }
    public virtual double CalculateHeight()
    {
        double d = _sideC -_sideA;
        double x = (_sideD*_sideD - _sideB*_sideB + d*d)/(2*d);
        double height = Math.Sqrt(_sideD*_sideD - x*x);
        return height;
    }
    public virtual double CalculateSides()
    {
        // |top-bottom| /2
        double x = Math.Abs(_sideC - _sideA) / 2;
        // sqrt(height^2+ (^^^) ^2)
        double sides = Math.Sqrt(_height*_height + x*x);
        return sides;
    }
    public override string DisplayInfo()
    {
        return $"Trapezoid: A:{_area:F2}, P:{_perimeter:F2}, H:{_height:F2}, C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"Trapezoid|{_sideA},{_sideB},{_sideC},{_sideD},{_color}";
    }
}