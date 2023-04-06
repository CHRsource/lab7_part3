using cs_lab7_part3;

class Worker : Person, INalog      // рабочий на окладе с премией
{
    public double Salary { get; set; }
    public int Bonus { get; set; }
    public Worker() : this("noname", "", new DateTime(), 'м', 0, 0) { }
    public Worker(string fn, string sn, DateTime d, char s, double sal, int p) :
        base(fn, sn, d, s)
    {
        Salary = sal;
        Bonus = p;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Оклад: " + Salary);
        Console.WriteLine("Премия: " + Bonus);
    }
    public double TotalPay()            // весь заработок = оклад + премия
    {
        return Salary * (1 + Bonus / 100.0);
    }
    public double Nalog()
    {
        return TotalPay() * 0.13;
    }
}
