public class EqualTriangle : IsoTriangle
{
    
    public EqualTriangle() 
    {
        _sideA = 1;
        _sideB = 1;
        _sideC = 1;
        _height = CalculateHeight();

        _angleA = 60;
        _angleB = 60;
        _angleC = 60;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();

        _color = "blank";
    }
    public EqualTriangle(double side, string color) 
    {
        _sideA = side;
        _sideB = side;
        _sideC = side;
        _height = CalculateHeight();

        _angleA = 60;
        _angleB = 60;
        _angleC = 60;
        
        _color = color;
    }
    public override string DisplayInfo()
    {
        return $"Equalateral Triangle: A:{_area:F2}, P:{_perimeter:F2}, Deg:(all: 60°), C:{_color} ";
    }
    public override string GetSaveString()
    {
        return $"EqualTriangle|{_sideA},{_color}";
    }
}