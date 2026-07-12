public class Triangle : FlatShapes
{
    protected double _sideA;
    protected double _sideB;
    protected double _sideC;
    protected double _height;
    protected double _angleA;
    protected double _angleB;
    protected double _angleC;
    public Triangle()
    {
        _sideA = 2;
        _sideB = 3;
        _sideC = 4;
        _height = CalculateHeight();

        List<double> angles = CalculateAngles();
        _angleA = angles[0];
        _angleB = angles[1];
        _angleC = angles[2];

        _area = CalculateArea();
        _perimeter = CalculatePerimeter();

        _color = "blank";
    }
    public Triangle(double sideA, double sideB, double sideC, string color)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        _height = CalculateHeight();

        List<double> angles = CalculateAngles();
        _angleA = angles[0];
        _angleB = angles[1];
        _angleC = angles[2];

        _area = CalculateArea();
        _perimeter = CalculatePerimeter();

        _color = color;
    }
    public override double CalculatePerimeter()
    {
        double perimeter = _sideA+_sideB+_sideC;
        return perimeter;
    }
    public override double CalculateArea()
    {
        double area = _sideA * _height;
        return area;
    }
    public List<double> CalculateAngles()
    {
        double angleA = 50;
        double angleB = 60;
        double angleC = 70;
        List<double> angles = [angleA, angleB, angleC];
        return angles;
    }
    public virtual double CalculateHeight()
    {
        double height = 1;
        return height;
    }
}