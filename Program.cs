using cs_lab7_part3;
using System.Collections.Immutable;

Person p1 = new("Иван", "Кукин", new DateTime(1950, 4, 1), 'м'),
    p2 = new("Людмила", "Кукина", new DateTime(1965, 5, 1), 'ж');
Building b1 = new(p1, 1500000, "Зайцева, 17"),
    b2 = new(p2, 1500000, "Зайцева, 17");
Stead s1 = new(p1, 250000, 300),
    s2 = new(p2, 250000, 300),
    s3 = new(p1, 300000, 1000);
Horse horse = new(p1, 20000, "Ромашка", 0, 7, 250);
Car car = new(p1, 10000, "ЗАЗ-965", 0, 27);
SmallShip smallship = new(p1, 25000, "лодка с мотором", 0, 0, 15);
Worker w1 = new(p1.FirstName, p1.LastName, p1.BirthDay, p1.Gender, 30000, 25),
    w2 = new(p2.FirstName, p2.LastName, p2.BirthDay, p2.Gender, 35000, 0);

Holding[] array1 = new Holding[] { b1, b2, s1, s2, s3, horse, car, smallship };
double sum = 0;
for (int i = 0; i < array1.Length; i++)
    sum += array1[i].Cost;
Console.WriteLine($"Общая стоимость имущества = {sum} руб.");

INalog[] array2 = new INalog[] { b1, b2, s1, s2, s3, horse, car, smallship, w1, w2 };
double nalog = 0;
for (int i = 0; i < array2.Length; i++)
    nalog += array2[i].Nalog();
Console.WriteLine($"Налог, который заплатила семья Кукиных = {nalog} руб.");

Console.WriteLine("Массив до сортировки");
for (int i = 0; i < array1.Length; i++)
{
    array1[i].Print();
    Console.WriteLine();
}
Array.Sort(array1);
Console.WriteLine("\nВывод отсортированного массива");
for (int i = 0; i < array1.Length; i++)
{
    array1[i].Print();
    Console.WriteLine();
}
