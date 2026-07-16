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
        
        List<double> angles = CalculateAngles();
        _angleA = angles[0];
        _angleB = angles[1];
        _angleC = angles[2];

        _area = CalculateArea();
        _perimeter = CalculatePerimeter();

        _color = color;
    }
    public IsoTriangle(double baseS, double height, string color)
    {
        _sideA = baseS;
        _sideB = CalculateSides(height, baseS);
        _sideC = CalculateSides(height, baseS);

        _height = height;

        List<double> angles = CalculateAngles();
        _angleA = angles[0];
        _angleB = angles[1];
        _angleC = angles[2];
        
        _area = CalculateArea();
        _perimeter = CalculatePerimeter();
        
        _color = color;
    }
    public double CalculateSides(double height, double baseS)
    {
        // cut it in half and it becomes a right triangle.
        double hb = _sideA / 2;
        double side = Math.Sqrt(hb*hb + _height*_height);
        return side;
    }
    public override string DisplayInfo()
    {
        return $"Isosoles Triangle: A:{_area:F2}, P:{_perimeter:F2} Deg({_angleA:F2}°, {_angleB:F2}°, {_angleC:F2}°), C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"IsoTriangle|{_sideA},{_height},{_color}";
    }
}