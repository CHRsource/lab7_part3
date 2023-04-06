#pragma warning disable
abstract class Holding : IComparable<object>      // имущество
{
    public Person Owner { get; set; }       // владелец
    public double Cost { get; set; }        // стоимость
    public virtual void Print()
    {
        Owner.Print();
        Console.WriteLine("Стоимость имущества: " + Cost);
    }
    public int CompareTo(object obj)
    {
        Holding h = obj as Holding;
        return Cost.CompareTo(h.Cost);
    }
}
