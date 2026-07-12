public class IsoTriangle : Triangle
{
        public IsoTriangle()
    {
        _sideA = 1;
        _sideB = 2;
        _sideC = _sideB;
        _height = CalculateHeight();

        List<double> angles = CalculateAngles();
        _angleA = angles[0];
        _angleB = angles[1];
        _angleC = angles[2];

        _area = CalculateArea();
        _perimeter = CalculatePerimeter();

        _color = "blank";
    }
    public IsoTriangle(string color, double baseS, double side)
    {
        _sideA = baseS;
        _sideB = side;
        _sideC = side;
        _height = CalculateHeight();
        
        _angleA = CalculatePoint(baseS, _height);
        _angleB = CalculateAngle();
        _angleC = CalculateAngle();

        _color = color;
    }
    public IsoTriangle(double baseS, double height, string color)
    {
        _sideA = baseS;
        _sideB = CalculateSides(height, baseS);
        _sideC = CalculateSides(height, baseS);
        _height = height;
        _angleA = CalculatePoint(baseS, height);
        _angleB = CalculateAngle();
        _angleC = CalculateAngle();
        
        _color = color;
    }
    public override double CalculateHeight()
    {
        double height = 1;
        return height;
    }
    public double CalculateSides(double height, double baseS)
    {
        double side = 1;
        return side;
    }
    public double CalculatePoint(double baseS, double height)
    {
        double point = 50;
        return point;
    }  
    public double CalculateAngle()
    {
        double angle = 65;
        return angle;
    }
}