public class Triangle : FlatShapes
{
    protected double _sideA;
    protected double _sideB;
    protected double _sideC;
    protected double _height;
    protected double _angleA; //opposite side a
    protected double _angleB; //opposite side b
    protected double _angleC; //opposite side c
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
        double area = (_sideA * _height) / 2;
        return area;
    }
    public List<double> CalculateAngles()
    {
        double a = _sideA;
        double b = _sideB;
        double c = _sideC;
        // A = cos^-1((b^2 + c^2 -a^2)/(2*b*c))
        double angleA = Math.Acos((b*b + c*c - a*a) / (2*b*c)) *180.0/Math.PI;
        // B = cos^-1((a^2 + c^2 -b^2)/(2*a*c))
        double angleB = Math.Acos((a*a + c*c - b*b) / (2*a*c)) *180.0/Math.PI;
        // C = cos^-1((a^2 + b^2 -c^2)/(2*a*b))
        double angleC = Math.Acos((a*a + b*b - c*c) / (2*a*b)) *180.0/Math.PI;
        
        List<double> angles = [angleA, angleB, angleC];
        return angles;
    }
    public virtual double CalculateHeight()
    {
        double a = _sideA;
        double b = _sideB;
        double c = _sideC;
        // 
        double s = (a+b+c) / 2;
        double ar = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
        double height = (2.0 * ar) / a;

        return height;
    }
    public override string DisplayInfo()
    {
        return $"Triangle: A:{_area:F2}, P:{_perimeter:F2}, H:{_height:F2} Deg:({_angleA:F2}°, {_angleB:F2}°, {_angleC:F2}°), C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"Triangle|{_sideA},{_sideB},{_sideC},{_color}";
    }
}