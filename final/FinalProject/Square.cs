public class Square : Rectangle
{
    public Square()
    {
        _sideA = 1;
        _sideB = 1;
        _sideC = 1;
        _sideD = 1;
        _height = 1;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();
        
        _color = "blank";
    }
    public Square(double side, string color)
    {
        _sideA = side;
        _sideB = side;
        _sideC = side;
        _sideD = side;
        _height = side;

        _perimeter = CalculatePerimeter();
        _area = CalculateArea();
        
        _color = color; 
    }
    public override string DisplayInfo()
    {
        return $"Square: A:{_area:F2}, P:{_perimeter:F2}, L:{_sideA:F2}, C:{_color} ";
    }   
    public override string GetSaveString()
    {
        return $"Square|{_sideA},{_color}";
    }
}