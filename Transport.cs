#pragma warning disable
class Transport : Holding       // Транспортное средство
{
    public Transport(Person owner, double cost, string name, double capacity)
    {
        Owner = owner;
        Cost = cost;
        Name = name;
        Capacity = capacity;
    }
    public Transport() : this(new Person(), 0, "undefined", 0) { }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Название: " + Name);
        Console.WriteLine("Грузоподъемность в кг.: " + Capacity);
    }
    public string Name { get; set; }        // название
    public double Capacity { get; set; }        // грузоподъемность
}
