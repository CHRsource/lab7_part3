using cs_lab7_part3;

class Stead : Holding, INalog           // участок земли
{
    public Stead(Person owner, double cost, double area)
    {
        Owner = owner;
        Cost = cost;
        Area = area;
    }
    public Stead() : this(new Person(), 0, 0) { }
    public override void Print()
    {
        Console.WriteLine("Участок земли");
        base.Print();
        Console.WriteLine("Площадь: " + Area);
    }
    public double Area { get; set; }        // площадь
    public double Nalog()
    {
        if (Owner.Age() >= 65 || Owner.Age() >= 60 && Owner.Gender == 'ж')
            return 0;
        return Cost * 0.003;
    }
}