class Fox : Animal
{
    public Fox(string name) : base(name){}
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says ringa-dinga-dinga-ding.");
    }
}