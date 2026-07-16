public class RightTriangle : Triangle
{
    public RightTriangle()
    {
        _sideA = 3;
        _sideB = 4;
        _sideC = CalculateHypotenuse();
        _height = CalculateHeight();

        List<double> angles = CalculateAngles();
        _angleA = angles[0];
        _angleB = angles[1];
        _angleC = angles[2];

        _area = CalculateArea();
        _perimeter = CalculatePerimeter();

        _color = "blank";
    }
    public RightTriangle(double sideA, double sideB, string color)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = CalculateHypotenuse();
        _height = CalculateHeight();

        List<double> angles = CalculateAngles();
        _angleA = angles[0];
        _angleB = angles[1];
        _angleC = angles[2];

        _area = CalculateArea();
        _perimeter = CalculatePerimeter();

        _color = color;
    }
    public double CalculateHypotenuse()
    {
        double a = _sideA;
        double b = _sideB;
        double cS = a*a + b*b;
        double c = Math.Sqrt(cS);
        return c;
    }
    public override string DisplayInfo()
    {
        return $"Right Triangle: A:{_area:F2}, P:{_perimeter:F2}, Deg:({_angleA:F2}°, {_angleB:F2}°, {_angleC:F2}°), C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"RightTriangle|{_sideA},{_sideB},{_color}";
    }
}