class Sphere : Circle
{
    public Sphere(double r) : base(r)
    { }
    public override double Area()
    {
        // 4*pi*r^2
        double area = (4 * Math.PI * _radius * _radius);
        return area;
    }
}
