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

        _color = "blank";
    }
    public EqualTriangle(double s, string color) 
    {
        _sideA = s;
        _sideB = s;
        _sideC = s;
        _height = CalculateHeight();

        _angleA = 60;
        _angleB = 60;
        _angleC = 60;
        
        _color = color;
    }
    public override string DisplayInfo()
    {
        return $"Equalateral Triangle: A:{_area}, P:{_perimeter}, C:{_color}";
    }
}