#pragma warning disable
using cs_lab7_part3;

class Building : Holding, INalog        // здания, сооружения
{
    public Building(Person owner, double cost, string address)
    {
        Owner = owner;
        Cost = cost;
        Address = address;
    }
    public Building() : this(new Person(), 0, "undefined") { }
    public override void Print()
    {
        Console.WriteLine("Здание");
        base.Print();
        Console.WriteLine("Адрес: " + Address);
    }
    public string Address { get; set; }         // адрес
    public double Nalog()
    {
        if (Owner.Age() >= 65 || Owner.Age() >= 60 && Owner.Gender == 'ж')
            return 0;
        return Cost * 0.015;
    }
}