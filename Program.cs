using KolcsonzoCA;
using System.Text;
using System.Xml.Linq;

List<Kolcsonzes> kolcsonzesek = new List<Kolcsonzes>();

using (var sr = new StreamReader(@"..\..\..\src\kolcsonzes.txt", Encoding.UTF8))
{
    sr.ReadLine();
    while (!sr.EndOfStream)
    {
        kolcsonzesek.Add(new Kolcsonzes(sr.ReadLine()));
    }
}

Console.WriteLine($"4. feladat: {kolcsonzesek.Count} db kölcsönzés.");

Console.Write("5. feladat: Adjon meg egy nevet: ");
var f5 = Console.ReadLine();

bool van = false;

foreach (var item in kolcsonzesek)
{
    if (item.Name.ToLower() == f5.ToLower())
    {
        Console.WriteLine($"A keresett néven {item.TakeOutHour}:{item.TakeOutMinute} - {item.ReturnHour}:{item.ReturnMinute} bérelt!");
        van = true;
    }
}


var f6 = kolcsonzesek.Where(x => x.Name.Contains(',')).ToList();

Console.WriteLine($"6. feladat: Aznap {f6.Count} db külföldi és {kolcsonzesek.Count - f6.Count} db magyar kölcsönzött!");
