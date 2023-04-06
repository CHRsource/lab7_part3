using cs_lab7_part3;

class SmallShip : Transport, INalog     // лодка, катер
{
    public SmallShip(Person owner, double cost, string name, double capacity, int paddle, double power) :
        base(owner, cost, name, capacity)
    {
        Paddle = paddle;
        Power = power;
    }
    public int Paddle { get; set; }         // количество весел в лодке
    public double Power { get; set; }       // мощность двигателя в л.с.
    public override void Print()
    {
        Console.WriteLine("Лодка / катер");
        base.Print();
        Console.WriteLine("Количество весел в лодке: " + Paddle);
        Console.WriteLine("Мощность двигателя в л.с.: " + Power);
    }
    public double Nalog()
    {
        if (Power == 0) return 200;
        else if (Power < 100) return Power * 10;
        else if (Power < 300) return Power * 20;
        else return Power * 200;
    }
}
