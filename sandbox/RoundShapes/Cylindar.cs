class Cylindar : Circle
{
    private double _height;
    public Cylindar(double r, double h) : base(r)
    {
        _height = h;
    }
    public override double Area()
    {
        // 2πrh + 2πr^2
        double area = (2.0* Math.PI * _radius * _height) + (2.0 * Math.PI * _radius* _radius);
        return area;
    }
}