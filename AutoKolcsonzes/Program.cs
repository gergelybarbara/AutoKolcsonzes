using AutoKolcsonzes.Models;

var cars = new List<Car>();

var sorok = File.ReadAllLines("cars_extended.csv").Skip(1);
foreach (var s in sorok)
{
    cars.Add(new Car(s));
}

var bookings = new List<Booking>();

var sorok2 = File.ReadAllLines("bookings_extended.csv").Skip(1);
foreach (var s in sorok2)
{
    bookings.Add(new Booking(s));
}

var arSzerint = cars
    .OrderByDescending(x => x.DailyPrice);

foreach (var ar in arSzerint)
{
    Console.WriteLine(ar + " / " + ar.DailyPrice);
}

foreach (var s in bookings)
{
    var car = cars
        .Where(x=>x.Id==s.CarId).FirstOrDefault();
    Console.WriteLine($"{car.Brand} \t{car.Model}, \t{s.StartDate:yyyy-MM-dd} - {s.EndDate:yyyy-MM-dd}");
}

