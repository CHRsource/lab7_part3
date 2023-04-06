using cs_lab7_part3;

class Car : Transport, INalog           // автомобиль
{
    public Car(Person owner, double cost, string name, double capacity, double power) : base(owner, cost, name, capacity)
    {
        Power = power;
    }
    public Car() : base() { Power = 0; }
    public double Power { get; set; }   // мощность двигателя в л.с.
    public override void Print()
    {
        Console.WriteLine("Автомобиль");
        base.Print();
        Console.WriteLine("Мощность двигателя в л.с.: " + Power);
    }
    public double Nalog()
    {
        if (Power < 100) return Power * 2.5;
        else if (Power < 150) return Power * 3.5;
        else if (Power < 200) return Power * 5;
        else if (Power < 250) return Power * 7.5;
        else if (Power < 410) return Power * 15;
        else return Power * 300;
    }
}