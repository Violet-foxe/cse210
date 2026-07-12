public class Trapezoid : FlatShapes
{
    protected double _sideA; //top length
    protected double _sideB; //right length
    protected double _sideC; //bottom length
    protected double _sideD; //left length
    public Trapezoid()
    {
        _sideA = 2;
        _sideB = 1;
        _sideC = 3;
        _sideD = 1;
    }
    public override double CalculateArea()
    {
        // top length, bottom length
        double area = 1;
        return area;
    }
    public override double CalculatePerimeter()
    {
        double perimeter = _sideA + _sideB + _sideC + _sideD;
        return perimeter;
    }
}