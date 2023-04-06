using cs_lab7_part3;

class Horse : Transport, INalog         // гужевой транспорт (лошадь)
{
    public Horse(Person owner, double cost, string name, double capacity, int age, double weight) :
        base(owner, cost, name, capacity)
    {
        Age = age;
        Weight = weight;
    }
    public Horse() : base()
    {
        Age = 0;
        Weight = 0;
    }
    public override void Print()
    {
        Console.WriteLine("Лошадь");
        base.Print();
        Console.WriteLine("Возраст: " + Age);
        Console.WriteLine("Вес: " + Weight);
    }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Nalog()
    {
        return 200;
    }
}
