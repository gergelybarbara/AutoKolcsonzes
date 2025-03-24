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

var mostBooked = bookings
    .GroupBy(x => x.CarId)
    .OrderByDescending(x => x.Count())
    .First();

var mostBookedCar = cars.First(x=>x.Id==mostBooked.Key);

Console.WriteLine($"\nA legtöbbet foglalt autó: {mostBookedCar}");

var legtobbBevetel = bookings
    .GroupBy(x => x.CarId)
    .OrderByDescending(x => x.Sum(c=>c.TotalPrice))
    .First();

var topCar = cars.First(x => x.Id == legtobbBevetel.Key);
Console.WriteLine($"\nA legtöbb bevételt hozű autó: {topCar}");