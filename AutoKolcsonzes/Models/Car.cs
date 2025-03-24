using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzes.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int Year { get; set; }
        public int DailyPrice { get; set; }

        public Car(string sor)
        {
            var t = sor.Split(";");
            Id = Convert.ToInt32(t[0]);
            Brand = t[1];
            Model = t[2];
            LicensePlate = t[3];
            Year = Convert.ToInt32(t[4]);
            DailyPrice = Convert.ToInt32(t[5]);
        }

        public override string? ToString()
        {
            return $"{LicensePlate}-{Brand}";
        }
    }
}
